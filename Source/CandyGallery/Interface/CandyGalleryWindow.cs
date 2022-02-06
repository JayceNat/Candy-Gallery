using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using CandyGallery.Helpers;
using CandyGallery.Models;
using CandyGallery.Serialization;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace CandyGallery.Interface
{
    public partial class CandyGalleryWindow : Form
    {
        #region Public Variables

        private Point _mouseDown;
        public UserSettings UserSettings;
        public const int HT_CAPTION = 0x2;
        public const int CS_DBLCLKS = 0x8;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WS_MINIMIZEBOX = 0x20000;
        public static string CandyGalleryFolderName = @"\CandyGallery";
        public static string GifsFolderName = CandyGalleryFolderName + @"\CandyGalleryGifs\";
        public static string VideosFolderName = CandyGalleryFolderName + @"\CandyGalleryVideos\";
        public static string OtherFolderName = CandyGalleryFolderName + @"\CandyGalleryOther\";
        public readonly RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override CreateParams CreateParams
        {
            // Used for minimizing the Gallery
            get
            {
                var cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName),
                ButtonBorderStyle.Solid);
        }

        #endregion

        public CandyGalleryWindow(UserSettings temporaryUserSettings)
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            Cursor.Current = Cursor;
            UserSettings = temporaryUserSettings;
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(UserSettings.StartFolderPath) || !Directory.Exists(UserSettings.StartFolderPath))
            {
                var result = MessageBox.Show(
                    @"Please specify the folder containing your gallery (select the top-most folder in the hierarchy).",
                    @"Specify Default Start Folder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result != DialogResult.Cancel)
                {
                    var folderInit = new FolderBrowserDialog();
                    if (folderInit.ShowDialog() == DialogResult.OK)
                    {
                        UserSettings.StartFolderPath = folderInit.SelectedPath;
                    }
                    else
                    {
                        Close();
                    }

                    folderInit.Dispose();
                }
                else
                {
                    Close();
                    Environment.Exit(0);
                }
            }

            if (Screen.PrimaryScreen.Bounds.Width < Width)
            {
                Width = Screen.PrimaryScreen.Bounds.Width;
            }

            if (Screen.PrimaryScreen.Bounds.Height < Height)
            {
                Height = Screen.PrimaryScreen.Bounds.Height;
            }

            UserSettings.PerSessionSettings.CurrentWorkingDirectory = UserSettings.StartFolderPath;
            UserSettings.PerSessionSettings.NewestMediaList = null;
            UserSettings.PerSessionSettings.OldestMediaList = null;
            UserSettings.PerSessionSettings.UserHasGifsFolder =
                Directory.Exists(UserSettings.StartFolderPath + GifsFolderName);
            UserSettings.PerSessionSettings.UserHasVideosFolder =
                Directory.Exists(UserSettings.StartFolderPath + VideosFolderName);
            UserSettings.PerSessionSettings.UserHasOtherFolder =
                Directory.Exists(UserSettings.StartFolderPath + OtherFolderName);
            LoadColorOntoInterface(CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName));

            picBxCandyGallery.ContextMenuStrip = toolStripContextMenuPicturebox;
            lblCurrentMediaPath.Text = "";
            txtFilterResultsByCount.Text = UserSettings.LimitCurrentMediaCount.ToString();
            chkEnableShortcutType.CheckedChanged -= EnableShortcuts_CheckedChanged;
            chkEnableShortcutType.Checked = UserSettings.IncludeShortcutMediaType;
            chkEnableShortcutType.CheckedChanged += EnableShortcuts_CheckedChanged;
            chkApplyImageFilter.Checked = UserSettings.ApplyImageFilter;
            picBxCandyGallery.MouseMove += PictureBox_MouseMove;
            picBxCandyGallery.MouseDown += PictureBox_MouseDown;
            FormClosing += CandyGallery_FormClosing;

            if (chkApplyImageFilter.Checked)
            {
                btnFilterStrengthUp.Show();
                btnFilterStrengthDown.Show();
                lblCurrentFilterStrength.Show();
                lblCurrentFilterStrength.Text = UserSettings.ImageFilterAmount.ToString();
            }

            switch (UserSettings.SlideShowSpeed.ToString())
            {
                case "0":
                    lblCurrentSlideSpeed.Text = @"MIN";
                    break;
                case "12":
                    lblCurrentSlideSpeed.Text = @"MAX";
                    break;
                default:
                    lblCurrentSlideSpeed.Text = UserSettings.SlideShowSpeed.ToString();
                    break;
            }

            if (UserSettings.PreserveSessionHistory && UserSettings.PerSessionSettings.BackList.Any())
            {
                lblCurrentMediaPath.Text = UserSettings.PerSessionSettings.BackList[0];
                UserSettings.PerSessionSettings.BackList.RemoveAt(0);
                if (CandyGalleryHelpers.IsVideoTypeMedia(lblCurrentMediaPath.Text) || CandyGalleryHelpers.IsShortcutTypeMedia(lblCurrentMediaPath.Text))
                {
                    picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
                }
                else
                {
                    LoadItemIntoViewer(lblCurrentMediaPath.Text);
                }
            }
            else
            {
                picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
            }

            var styledUsername = "";
            foreach (var character in UserSettings.UserName)
            {
                styledUsername += character.ToString().ToUpper() + " ";
            }

            lblUsername.Text = styledUsername;
            if (UserSettings.UserAvatarKey <= imageListAvatars.Images.Count)
            {
                picBxUserAvatar.Image = imageListAvatars.Images[UserSettings.UserAvatarKey - 1];
            }
            else
            {
                UserSettings.UserAvatarKey = 1;
                picBxUserAvatar.Image = imageListAvatars.Images[0];
            }

            if (UserSettings.SidePanelCollapsed)
            {
                CollapseSidePanel(true);
            }

            if (UserSettings.UnseenItems == null || UserSettings.UnseenItems.Count == 0)
            {
                var cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                UserSettings.UnseenItems = new List<string>();
                GenerateUnseenItems(new DirectoryInfo(UserSettings.StartFolderPath));
                Cursor.Current = cursor;
            }

            btnRandomize.Focus();
        }

        #region Generic UI Events
        // **************************************************************************************************

        public void CandyGalleryWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region UI Textbox and Label Event Handlers

        // **************************************************************************************************

        #region UI Textboxes

        // **************************************************************************************************

        private void FilterResultsByCount_TextChanged(object sender, EventArgs e)
        {
            UserSettings.PerSessionSettings.EnableHotKeys = false;
            txtFilterResultsByCount.Focus();
            if (int.TryParse(txtFilterResultsByCount.Text, out var num))
            {
                if (num > 99)
                {
                    num = 99;
                }
                else if (num < 0)
                {
                    num = 1;
                }

                txtFilterResultsByCount.Text = num.ToString();
                UserSettings.PerSessionSettings.NewestMediaList = null;
                UserSettings.PerSessionSettings.OldestMediaList = null;
                UserSettings.LimitCurrentMediaCount = num;
            }
            else
            {
                txtFilterResultsByCount.Text = UserSettings.LimitCurrentMediaCount.ToString();
            }
            UserSettings.PerSessionSettings.EnableHotKeys = true;
        }

        // **************************************************************************************************

        #endregion

        #region UI Labels

        // **************************************************************************************************

        private void CurrentMediaPath_Click(object sender, EventArgs e)
        {
            ResetImageIntoView();
            openFileDialog.InitialDirectory = UserSettings.StartFolderPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog.FileName;

                AddCurrentItemToBackList();
                lblCurrentMediaPath.Text = file;
                LoadItemIntoViewer(file);
            }

            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        // **************************************************************************************************

        #endregion

        #region UI Button Event Handlers

        // **************************************************************************************************

        private void ExitGallery_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizeGallery_Click(object sender, EventArgs e)
        {
            if (UserSettings.PerSessionSettings.GalleryMaximized)
            {
                WindowState = FormWindowState.Normal;
                UserSettings.PerSessionSettings.GalleryMaximized = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                UserSettings.PerSessionSettings.GalleryMaximized = true;
            }

            btnRandomize.Focus();
        }

        private void MinimizeGallery_Click(object sender, EventArgs e)
        {
            btnRandomize.Focus();
            WindowState = FormWindowState.Minimized;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            using (var settings = new CandySettingsWindow())
            {
                settings.ShowDialog();
                if (UserSettings.PerSessionSettings.ResetCandyGallery)
                {
                    Close();
                }
                UserSettings.UserName = Program.CandyGalleryWindow.UserSettings.UserName;
                UserSettings.Pass = Program.CandyGalleryWindow.UserSettings.Pass;
            }

            btnRandomize.Focus();
        }

        private void MultiRandomizer_Click(object sender, EventArgs e)
        {
            using (var multiRandom = new CandyMultipleRandomWindow())
            {
                multiRandom.ShowDialog();
            }

            btnRandomize.Focus();
        }

        private void ViewFavorites_Click(object sender, EventArgs e)
        {
            using (var favoritesWindow = new CandyFavoritesWindow())
            {
                favoritesWindow.ShowDialog();
            }

            btnRandomize.Focus();
        }

        private void FilterByCountIncrease_Click(object sender, EventArgs e)
        {
            if (UserSettings.LimitCurrentMediaCount < 99)
            {
                txtFilterResultsByCount.Text = (UserSettings.LimitCurrentMediaCount + 1).ToString();
            }
        }

        private void FilterByCountDecrease_Click(object sender, EventArgs e)
        {
            if (UserSettings.LimitCurrentMediaCount > 1)
            {
                txtFilterResultsByCount.Text = (UserSettings.LimitCurrentMediaCount - 1).ToString();
            }
        }

        #region SlideShow Buttons

        // **************************************************************************************************

        private void SlideSpeedUp_Click(object sender, EventArgs e)
        {
            if (UserSettings.SlideShowSpeed + 1 > 11)
            {
                UserSettings.SlideShowSpeed = 12;
                lblCurrentSlideSpeed.Text = @"MAX";
            }
            else
            {
                UserSettings.SlideShowSpeed += 1;
                lblCurrentSlideSpeed.Text = UserSettings.SlideShowSpeed.ToString();
            }

            btnRandomize.Focus();
        }

        private void SlideSpeedDown_Click(object sender, EventArgs e)
        {
            if (UserSettings.SlideShowSpeed - 1 <= 0)
            {
                UserSettings.SlideShowSpeed = 0;
                lblCurrentSlideSpeed.Text = @"MIN";
            }
            else
            {
                UserSettings.SlideShowSpeed -= 1;
                lblCurrentSlideSpeed.Text = UserSettings.SlideShowSpeed.ToString();
            }

            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        #region Image Filtering Buttons

        // **************************************************************************************************

        private void FilterStrengthUp_Click(object sender, EventArgs e)
        {
            var originalCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (lblCurrentMediaPath.Text != "")
            {
                if (UserSettings.ImageFilterAmount + 5 >= 100)
                {
                    UserSettings.ImageFilterAmount = 100;
                    lblCurrentFilterStrength.Text = @"MAX";
                }
                else
                {
                    UserSettings.ImageFilterAmount += 5;
                    lblCurrentFilterStrength.Text = UserSettings.ImageFilterAmount.ToString();
                }

                var filteredImage = ApplyFilterToImage(lblCurrentMediaPath.Text);
                picBxCandyGallery.Image = filteredImage ?? picBxCandyGallery.ErrorImage;
            }

            Cursor.Current = originalCursor;
            btnRandomize.Focus();
        }

        private void FilterStrengthDown_Click(object sender, EventArgs e)
        {
            var originalCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (lblCurrentMediaPath.Text != "")
            {
                if (UserSettings.ImageFilterAmount - 5 <= 5)
                {
                    UserSettings.ImageFilterAmount = 5;
                    lblCurrentFilterStrength.Text = @"MIN";
                }
                else
                {
                    UserSettings.ImageFilterAmount -= 5;
                    lblCurrentFilterStrength.Text = UserSettings.ImageFilterAmount.ToString();
                }

                var filteredImage = ApplyFilterToImage(lblCurrentMediaPath.Text);
                picBxCandyGallery.Image = filteredImage ?? picBxCandyGallery.ErrorImage;
            }

            Cursor.Current = originalCursor;
            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        #region Bottom Control Bar Buttons

        // **************************************************************************************************

        private void Randomize_Click(object sender, EventArgs e)
        {
            if (chkFilterByNewest.Checked)
            {
                if (UserSettings.PerSessionSettings.NewestMediaList == null)
                {
                    GetNewestItems();
                }
            }
            else if (chkFilterByOldest.Checked)
            {
                if (UserSettings.PerSessionSettings.OldestMediaList == null)
                {
                    GetOldestItems();
                }
            }
            else if (chkFilterByUnseen.Checked)
            {
                if (UserSettings.UnseenItems == null || UserSettings.UnseenItems.Count == 0)
                {
                    var result = MessageBox.Show(
                    $"Unseen items list is empty! Would you like to refresh it?",
                    $"All Items Seen!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        var cursor = Cursor.Current;
                        Cursor.Current = Cursors.WaitCursor;
                        UserSettings.UnseenItems = new List<string>();
                        GenerateUnseenItems(new DirectoryInfo(UserSettings.StartFolderPath));
                        Cursor.Current = cursor;
                    }
                }
            }

            Randomize();
            btnRandomize.Focus();
        }

        private void ShowCollapseSideBar_Click(object sender, EventArgs e)
        {
            if (UserSettings.SidePanelCollapsed)
            {
                CollapseSidePanel(false);
                UserSettings.SidePanelCollapsed = false;
            }
            else
            {
                CollapseSidePanel(true);
                UserSettings.SidePanelCollapsed = true;
            }

            btnRandomize.Focus();
        }

        private void AddNewFavorite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblCurrentMediaPath.Text))
            {
                var index = UserSettings.UserFavorites.Count + 1;
                SetFavoriteAtNumber(index);
            }

            btnRandomize.Focus();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (UserSettings.PerSessionSettings.ForwardList.Any())
            {
                ResetImageIntoView();
                AddCurrentItemToBackList();
                lblCurrentMediaPath.Text =
                    UserSettings.PerSessionSettings.ForwardList[UserSettings.PerSessionSettings.ForwardList.Count - 1];
                UserSettings.PerSessionSettings.ForwardList.RemoveAt(
                    UserSettings.PerSessionSettings.ForwardList.Count - 1);
                LoadItemIntoViewer(lblCurrentMediaPath.Text);
            }
            else
            {
                btnRandomize.PerformClick();
            }

            btnRandomize.Focus();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (UserSettings.PerSessionSettings.BackList.Any())
            {
                ResetImageIntoView();
                UserSettings.PerSessionSettings.ForwardList.Add(lblCurrentMediaPath.Text);
                lblCurrentMediaPath.Text = UserSettings.PerSessionSettings.BackList[0];
                UserSettings.PerSessionSettings.BackList.RemoveAt(0);
                LoadItemIntoViewer(lblCurrentMediaPath.Text);
            }

            btnRandomize.Focus();
        }

        private void ResetPathToDefault_Click(object sender, EventArgs e)
        {
            btnAllType.PerformClick();
            btnRandomize.Focus();
        }

        private void SetPathToFolderOfCurrentMedia_Click(object sender, EventArgs e)
        {
            var currentMedia = lblCurrentMediaPath.Text;
            if (!string.IsNullOrWhiteSpace(currentMedia))
            {
                chkFilterByUnseen.Checked = false;
                chkFilterByNewest.Checked = false;
                chkFilterByOldest.Checked = false;
                ResetFolderTypeButtonsColor();
                btnAllType.ForeColor = Color.Black;
                btnAllType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);

                if (CandyGalleryHelpers.IsVideoTypeMedia(currentMedia))
                {
                    MessageBox.Show(
                        @"Error: Cannot set path to current item of video type!",
                        @"Current Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserSettings.PerSessionSettings.CurrentWorkingDirectory = Path.GetDirectoryName(currentMedia);
                    UserSettings.PerSessionSettings.NewestMediaList = null;
                    UserSettings.PerSessionSettings.OldestMediaList = null;
                }
            }

            btnRandomize.Focus();
        }

        private void SetPathToParentOfCurrentMedia_Click(object sender, EventArgs e)
        {
            var currentMedia = lblCurrentMediaPath.Text;
            if (!string.IsNullOrWhiteSpace(currentMedia))
            {
                chkFilterByUnseen.Checked = false;
                chkFilterByNewest.Checked = false;
                chkFilterByOldest.Checked = false;
                ResetFolderTypeButtonsColor();
                btnAllType.ForeColor = Color.Black;
                btnAllType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);

                UserSettings.PerSessionSettings.CurrentWorkingDirectory =
                    Directory.GetParent(Path.GetDirectoryName(currentMedia)).FullName;
                UserSettings.PerSessionSettings.NewestMediaList = null;
                UserSettings.PerSessionSettings.OldestMediaList = null;
            }

            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        // **************************************************************************************************

        #endregion

        #region UI CheckBox Event Handlers

        // **************************************************************************************************

        private void Slideshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSlideShow.Checked && UserSettings.PerSessionSettings.CurrentWorkingDirectory.EndsWith("ZV"))
            {
                chkSlideShow.Checked = false;
                btnRandomize.Focus();
                return;
            }
            if (chkSlideShow.Checked)
            {
                btnSlideSpeedDown.Show();
                btnSlideSpeedUp.Show();
                lblCurrentSlideSpeed.Show();
                while (chkSlideShow.Checked)
                {
                    if (ModifierKeys == Keys.Alt || !chkSlideShow.Checked) //it should stop now
                    {
                        chkSlideShow.Checked = false;
                        btnSlideSpeedDown.Hide();
                        btnSlideSpeedUp.Hide();
                        lblCurrentSlideSpeed.Hide();
                        break;
                    }
                    else
                    {
                        Application.DoEvents();
                        btnRandomize.PerformClick();
                        System.Threading.Thread.Sleep(3000 - UserSettings.SlideShowSpeed * 250);
                    }
                }
            }
            else
            {
                btnSlideSpeedDown.Hide();
                btnSlideSpeedUp.Hide();
                lblCurrentSlideSpeed.Hide();
            }

            btnRandomize.Focus();
        }

        private void ApplyImageFilter_CheckedChanged(object sender, EventArgs e)
        {
            var originalCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            UserSettings.ApplyImageFilter = chkApplyImageFilter.Checked;
            if (UserSettings.ApplyImageFilter && !string.IsNullOrWhiteSpace(lblCurrentMediaPath.Text))
            {
                btnFilterStrengthUp.Show();
                btnFilterStrengthDown.Show();
                lblCurrentFilterStrength.Show();
                picBxCandyGallery.Image = ApplyFilterToImage(lblCurrentMediaPath.Text);
            }
            else if (!string.IsNullOrWhiteSpace(lblCurrentMediaPath.Text))
            {
                btnFilterStrengthUp.Hide();
                btnFilterStrengthDown.Hide();
                lblCurrentFilterStrength.Hide();
                GC.Collect();
                picBxCandyGallery.ImageLocation = lblCurrentMediaPath.Text;
            }
            else
            {
                btnFilterStrengthUp.Hide();
                btnFilterStrengthDown.Hide();
                lblCurrentFilterStrength.Hide();
            }

            Cursor.Current = originalCursor;
            btnRandomize.Focus();
        }

        #region Result Filtering CheckBoxes

        // **************************************************************************************************

        private void NewestItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterByNewest.Checked)
            {
                chkFilterByUnseen.Checked = false;
                chkFilterByOldest.Checked = false;
                btnFilterByCountIncrease.Show();
                txtFilterResultsByCount.Show();
                btnFilterByCountDecrease.Show();
            }
            else
            {
                btnFilterByCountIncrease.Hide();
                txtFilterResultsByCount.Hide();
                btnFilterByCountDecrease.Hide();
            }

            btnRandomize.Focus();
        }

        private void OldestItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterByOldest.Checked)
            {
                chkFilterByUnseen.Checked = false;
                chkFilterByNewest.Checked = false;
                btnFilterByCountIncrease.Show();
                txtFilterResultsByCount.Show();
                btnFilterByCountDecrease.Show();
            }
            else
            {
                btnFilterByCountIncrease.Hide();
                txtFilterResultsByCount.Hide();
                btnFilterByCountDecrease.Hide();
            }

            btnRandomize.Focus();
        }

        private void UnseenItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterByUnseen.Checked)
            {
                chkFilterByNewest.Checked = false;
                chkFilterByOldest.Checked = false;
                txtFilterResultsByCount.Show();
            }
            else
            {
                txtFilterResultsByCount.Hide();
            }

            btnRandomize.Focus();
        }

        private void AllType_Click(object sender, EventArgs e)
        {
            UncheckResultsFilters();
            picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
            TypeMediaChangeButtonPressHelper("");
            ResetFolderTypeButtonsColor();
            btnAllType.ForeColor = Color.Black;
            btnAllType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            btnRandomize.PerformClick();
            btnRandomize.Focus();
        }


        private void OtherType_Click(object sender, EventArgs e)
        {
            UncheckResultsFilters();
            if (UserSettings.PerSessionSettings.UserHasOtherFolder)
            {
                TypeMediaChangeButtonPressHelper(OtherFolderName);
                ResetFolderTypeButtonsColor();
                btnOtherType.ForeColor = Color.Black;
                btnOtherType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
                btnRandomize.PerformClick();
            }
            else
            {
                var result = MessageBox.Show(
                    $"No '{OtherFolderName}' folder exists inside of your start folder: '{UserSettings.StartFolderPath}'" +
                    $"\n\nWould you like to create a '{OtherFolderName}' folder?",
                    $"No '{OtherFolderName}' Folder Found!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(UserSettings.StartFolderPath + OtherFolderName);
                    UserSettings.PerSessionSettings.UserHasOtherFolder = true;
                }
            }

            btnRandomize.Focus();
        }

        private void GifType_Click(object sender, EventArgs e)
        {
            UncheckResultsFilters();
            if (UserSettings.PerSessionSettings.UserHasGifsFolder)
            {
                TypeMediaChangeButtonPressHelper(GifsFolderName);
                ResetFolderTypeButtonsColor();
                btnGifType.ForeColor = Color.Black;
                btnGifType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
                btnRandomize.PerformClick();
            }
            else
            {
                var result = MessageBox.Show(
                    $"No '{GifsFolderName}' folder exists inside of your start folder: '{UserSettings.StartFolderPath}'" +
                    $"\n\nWould you like to create a '{GifsFolderName}' folder?",
                    $"No '{GifsFolderName}' Folder Found!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(UserSettings.StartFolderPath + GifsFolderName);
                    UserSettings.PerSessionSettings.UserHasGifsFolder = true;
                }
            }

            btnRandomize.Focus();
        }

        private void VideosType_Click(object sender, EventArgs e)
        {
            UncheckResultsFilters();
            if (UserSettings.PerSessionSettings.UserHasVideosFolder)
            {
                TypeMediaChangeButtonPressHelper(VideosFolderName);
                ResetFolderTypeButtonsColor();
                btnVideosType.ForeColor = Color.Black;
                btnVideosType.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
                btnRandomize.PerformClick();
            }
            else
            {
                var result = MessageBox.Show(
                    $"No '{VideosFolderName}' folder exists inside of your start folder: '{UserSettings.StartFolderPath}'" +
                    $"\n\nWould you like to create a '{VideosFolderName}' folder?",
                    $"No '{VideosFolderName}' Folder Found!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(UserSettings.StartFolderPath + VideosFolderName);
                    UserSettings.PerSessionSettings.UserHasVideosFolder = true;
                }
            }

            btnRandomize.Focus();
        }

        private void ResetFolderTypeButtonsColor()
        {
            btnAllType.ForeColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            btnAllType.BackColor = Color.Black;
            btnGifType.ForeColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            btnGifType.BackColor = Color.Black;
            btnVideosType.ForeColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            btnVideosType.BackColor = Color.Black;
            btnOtherType.ForeColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            btnOtherType.BackColor = Color.Black;
        }

        private void EnableShortcuts_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings.IncludeShortcutMediaType = chkEnableShortcutType.Checked;
            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        // **************************************************************************************************

        #endregion

        #region Randomization Handling

        // **************************************************************************************************

        // Main randomizer logic
        public void Randomize()
        {
            string item;

            if (chkFilterByNewest.Checked)
            {
                item = GetRandomFileFromListRecursive(UserSettings.PerSessionSettings.NewestMediaList);
            }
            else if (chkFilterByOldest.Checked)
            {
                item = GetRandomFileFromListRecursive(UserSettings.PerSessionSettings.OldestMediaList);
            }
            else if (chkFilterByUnseen.Checked)
            {
                var validItemList = UserSettings.UnseenItems;
                if (!string.IsNullOrEmpty(UserSettings.PerSessionSettings.CurrentWorkingDirectory))
                {
                    validItemList = validItemList.FindAll(i => i.StartsWith(UserSettings.PerSessionSettings.CurrentWorkingDirectory));
                    if (!validItemList.Any())
                    {
                        var result = MessageBox.Show(
                            @"Every item in the currently selected working directory has been seen. Do you want to reset the unseen list for all items in this foler: '" + UserSettings.PerSessionSettings.CurrentWorkingDirectory + "'",
                            @"No Unseen Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var cursor = Cursor.Current;
                            Cursor.Current = Cursors.WaitCursor;
                            GenerateUnseenItems(new DirectoryInfo(UserSettings.PerSessionSettings.CurrentWorkingDirectory));
                            validItemList = UserSettings.UnseenItems.FindAll(i => i.StartsWith(UserSettings.PerSessionSettings.CurrentWorkingDirectory));
                        }
                        else
                        {
                            chkFilterByUnseen.Checked = false;
                            var subDirectoriesOnCurrentPath = Directory.GetDirectories(UserSettings.PerSessionSettings.CurrentWorkingDirectory).ToList();
                            var filesOnCurrentPath = Directory.GetFiles(UserSettings.PerSessionSettings.CurrentWorkingDirectory).ToList();
                            validItemList = subDirectoriesOnCurrentPath.Any() ? subDirectoriesOnCurrentPath : filesOnCurrentPath;
                        }
                    }
                }
                item = GetRandomFileFromListRecursive(validItemList);
            }
            else
            {
                var subDirectoriesOnCurrentPath = Directory.GetDirectories(UserSettings.PerSessionSettings.CurrentWorkingDirectory).ToList();
                var filesOnCurrentPath = Directory.GetFiles(UserSettings.PerSessionSettings.CurrentWorkingDirectory).ToList();
                item = GetRandomFileFromListRecursive(subDirectoriesOnCurrentPath.Any() ? subDirectoriesOnCurrentPath : filesOnCurrentPath);
            }

            if (item != null)
            {
                ResetImageIntoView();
                UserSettings.PerSessionSettings.ForwardList.Clear();
                AddCurrentItemToBackList();
                lblCurrentMediaPath.Text = item;
                LoadItemIntoViewer(item);
            }

            btnRandomize.Focus();
        }

        public string GetRandomFileFromListRecursive(List<string> listOfItems)
        {
            if (!chkEnableShortcutType.Checked)
            {
                listOfItems = listOfItems.FindAll(item => CandyGalleryHelpers.IsShortcutTypeMedia(item) == false);
            }

            if (!listOfItems.Any()) return null;

            while (true)
            {
                var randomItemIndex = RandomInteger(0, listOfItems.Count);
                var winningItem = listOfItems[randomItemIndex];
                var itemAttributes = File.GetAttributes(winningItem);
                if (itemAttributes.HasFlag(FileAttributes.Directory))
                {
                    var subDirs = Directory.GetDirectories(winningItem).ToList();
                    if (subDirs.Any())
                    {
                        listOfItems = subDirs;
                        continue;
                    }

                    var subFiles = Directory.GetFiles(winningItem).ToList();
                    if (subFiles.Any())
                    {
                        listOfItems = subFiles;
                    }
                }
                else
                {
                    if (winningItem == picBxCandyGallery.ImageLocation && UserSettings.LimitCurrentMediaCount > 1)
                    {
                        winningItem = GetRandomFileFromListRecursive(listOfItems);
                    }

                    return winningItem;
                }
            }
        }

        // Returns a random number between 'min' and 'max' (not inclusive)
        public int RandomInteger(int min, int max)
        {
            var scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] fourBytes = new byte[4];
                Rand.GetBytes(fourBytes);

                scale = BitConverter.ToUInt32(fourBytes, 0);
            }

            return (int) (min + (max - min) *
                          (scale / (double) uint.MaxValue));
        }

        // **************************************************************************************************

        #endregion

        #region Helper Methods

        // **************************************************************************************************

        public void CollapseSidePanel(bool collapseSidePanel)
        {
            if (collapseSidePanel)
            {
                UserSettings.PerSessionSettings.ControlParentToRestoreViewForSidePanel =
                    tblLPRightSideControlContainer.Parent;
                tblLPRightSideControlContainer.Parent = this;
                tblLPMainForm.ColumnCount = 1;
                btnShowCollapseSideBar.Text = @"←";
                Refresh();
            }
            else
            {
                tblLPMainForm.ColumnCount = 2;
                tblLPRightSideControlContainer.Parent =
                    UserSettings.PerSessionSettings.ControlParentToRestoreViewForSidePanel;
                btnShowCollapseSideBar.Text = @"→";
                Update();
            }
        }

        public void LoadColorOntoInterface(Color newUiColor)
        {
            btnMaximize.BackColor = newUiColor;
            btnShowCollapseSideBar.ForeColor = newUiColor;
            btnAddNewFavorite.ForeColor = newUiColor;
            btnFilterByCountIncrease.ForeColor = newUiColor;
            btnFilterByCountDecrease.ForeColor = newUiColor;
            btnGoBack.BackColor = newUiColor;
            btnGoForward.BackColor = newUiColor;
            btnViewFavorites.BackColor = newUiColor;
            btnSlideSpeedDown.BackColor = newUiColor;
            btnSlideSpeedUp.BackColor = newUiColor;
            btnFilterStrengthDown.BackColor = newUiColor;
            btnFilterStrengthUp.BackColor = newUiColor;
            btnAllType.ForeColor = btnAllType.ForeColor == Color.Black ? Color.Black : newUiColor;
            btnAllType.BackColor = btnAllType.BackColor == Color.Black ? Color.Black : newUiColor;
            btnGifType.ForeColor = btnGifType.ForeColor == Color.Black ? Color.Black : newUiColor;
            btnGifType.BackColor = btnGifType.BackColor == Color.Black ? Color.Black : newUiColor;
            btnVideosType.ForeColor = btnVideosType.ForeColor == Color.Black ? Color.Black : newUiColor;
            btnVideosType.BackColor = btnVideosType.BackColor == Color.Black ? Color.Black : newUiColor;
            btnOtherType.ForeColor = btnOtherType.ForeColor == Color.Black ? Color.Black : newUiColor;
            btnOtherType.BackColor = btnOtherType.BackColor == Color.Black ? Color.Black : newUiColor;

            lblCandyTitle.ForeColor = newUiColor;
            lblCurrentMediaPath.ForeColor = newUiColor;
            lblUsername.ForeColor = newUiColor;
            lblOptionsSection.ForeColor = newUiColor;
            lblTypeSelectionSection.ForeColor = newUiColor;
            lblCurrentSlideSpeed.ForeColor = newUiColor;
            lblCurrentFilterStrength.ForeColor = newUiColor;
            btnResetPathToDefault.ForeColor = newUiColor;
            btnSetPathToFolderOfCurrentMedia.ForeColor = newUiColor;
            btnSetPathToParentOfCurrentMedia.ForeColor = newUiColor;
            btnMultiRandomizer.ForeColor = newUiColor;
            btnSettings.ForeColor = newUiColor;
            chkSlideShow.ForeColor = newUiColor;
            chkApplyImageFilter.ForeColor = newUiColor;
            chkFilterByUnseen.ForeColor = newUiColor;
            chkFilterByNewest.ForeColor = newUiColor;
            chkFilterByOldest.ForeColor = newUiColor;
            chkEnableShortcutType.ForeColor = newUiColor;

            if (UserSettings.ApplyColorToRandomizeButton)
            {
                btnRandomize.BackColor = newUiColor;
            }

            Update();
        }

        #region Current Media Handling

        // **************************************************************************************************

        public void GetNewestItems()
        {
            var newestFolders = Directory.GetDirectories(UserSettings.PerSessionSettings.CurrentWorkingDirectory)
                .Select(x => new FileInfo(Path.GetFullPath(x)))
                .OrderByDescending(x => x.LastWriteTime)
                .Take(UserSettings.LimitCurrentMediaCount)
                .ToArray();

            if (newestFolders.Any())
            {
                UserSettings.PerSessionSettings.NewestMediaList = newestFolders
                    .Select(f => f.FullName)
                    .Where(s => s != UserSettings.StartFolderPath + VideosFolderName)
                    .ToList();
            }
            else
            {
                var newestFiles = Directory.GetFiles(UserSettings.PerSessionSettings.CurrentWorkingDirectory)
                .Select(x => new FileInfo(Path.GetFullPath(x)))
                .OrderByDescending(x => x.LastWriteTime)
                .Take(UserSettings.LimitCurrentMediaCount)
                .ToArray();

                UserSettings.PerSessionSettings.NewestMediaList = newestFiles
                    .Select(f => f.FullName)
                    .ToList();
            }
        }

        public void GetOldestItems()
        {
            var oldestFolders = Directory.GetDirectories(UserSettings.PerSessionSettings.CurrentWorkingDirectory)
                .Select(x => new FileInfo(Path.GetFullPath(x)))
                .OrderBy(x => x.LastAccessTime)
                .Take(UserSettings.LimitCurrentMediaCount)
                .ToArray();

            if (oldestFolders.Any())
            {
                UserSettings.PerSessionSettings.OldestMediaList = oldestFolders
                    .Select(f => f.FullName)
                    .Where(s => s != UserSettings.StartFolderPath + VideosFolderName)
                    .ToList();
            }
            else
            {
                var oldestFiles = Directory.GetFiles(UserSettings.PerSessionSettings.CurrentWorkingDirectory)
                .Select(x => new FileInfo(Path.GetFullPath(x)))
                .OrderBy(x => x.LastAccessTime)
                .Take(UserSettings.LimitCurrentMediaCount)
                .ToArray();

                UserSettings.PerSessionSettings.OldestMediaList = oldestFiles
                    .Select(f => f.FullName)
                    .ToList();
            }
        }

        public void GenerateUnseenItems(DirectoryInfo rootDir)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = rootDir.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (Exception e)
            {
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    UserSettings.UnseenItems.Add(fi.FullName);
                }

                // Now find all the subdirectories under this directory.
                subDirs = rootDir.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    GenerateUnseenItems(dirInfo);
                }
            }
        }

        private void UncheckResultsFilters()
        {
            chkFilterByUnseen.Checked = false;
            chkFilterByNewest.Checked = false;
            chkFilterByOldest.Checked = false;
        }

        private void TypeMediaChangeButtonPressHelper(string mediaButtonTypeFolder)
        {
            AddCurrentItemToBackList();
            lblCurrentMediaPath.Text = "";
            UserSettings.PerSessionSettings.CurrentWorkingDirectory = UserSettings.StartFolderPath + mediaButtonTypeFolder;
            UserSettings.PerSessionSettings.NewestMediaList = null;
            UserSettings.PerSessionSettings.OldestMediaList = null;
        }

        public void LoadItemIntoViewer(string itemPath)
        {
            if (UserSettings.UnseenItems != null && UserSettings.UnseenItems.Count > 0)
            {
                UserSettings.UnseenItems.Remove(itemPath);
            }

            if (CandyGalleryHelpers.IsVideoTypeMedia(itemPath) || CandyGalleryHelpers.IsShortcutTypeMedia(itemPath))
            {
                var videoPlayer = new CandyVideoWindow();
                if (CandyGalleryHelpers.IsVideoTypeMedia(itemPath))
                {
                    videoPlayer.videoPlayer.URL = itemPath;
                    picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
                    videoPlayer.ShowDialog();
                }
                if (CandyGalleryHelpers.IsShortcutTypeMedia(itemPath) && UserSettings.IncludeShortcutMediaType)
                {
                    var shell = new WshShell();
                    var link = (IWshShortcut)shell.CreateShortcut(itemPath);
                    videoPlayer.videoPlayer.URL = link.TargetPath;
                    picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
                    videoPlayer.ShowDialog();
                }
            }

            else
            {
                if (UserSettings.ApplyImageFilter)
                {
                    var filteredImage = ApplyFilterToImage(itemPath);
                    picBxCandyGallery.Image = filteredImage ?? picBxCandyGallery.ErrorImage;
                }
                else
                {
                    picBxCandyGallery.ImageLocation = itemPath;
                }
            }
        }

        public void AddCurrentItemToBackList()
        {
            if (string.IsNullOrWhiteSpace(lblCurrentMediaPath.Text)) return;
            UserSettings.PerSessionSettings.BackList.Insert(0, lblCurrentMediaPath.Text);
        }

        public void LowResolutionImageRemoval()
        {
            if (chkSlideShow.Checked) return;
            var showingQualityImage = false;

            var cleanUp = MessageBox.Show(
                @"Image resolution is low. Would you like to clean out low resolution images from this folder?",
                @"Low Image Resolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var originalCursor = Cursor.Current;
            if (cleanUp == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                var deletedCount = 0;
                var deletedFiles = new List<string>();
                foreach (var file in Directory.GetFiles(
                    Path.GetDirectoryName(picBxCandyGallery.ImageLocation)
                    ?? MessageBox.Show("Oops... Something went wrong.\n\nNo files were deleted.", "Delete Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error).ToString()))
                {
                    if (!CandyGalleryHelpers.IsImageTypeMedia(file)) continue;

                    try
                    {
                        using (var image = Image.FromFile(file))
                        {
                            if (image.Height <= 425 && image.Width <= 625
                                || image.Height <= 625 && image.Width <= 425)
                            {
                                deletedFiles.Add(file);
                                deletedCount += 1;
                            }
                            else
                            {
                                if (!showingQualityImage)
                                {
                                    UserSettings.PerSessionSettings.ForwardList.Clear();
                                    lblCurrentMediaPath.Text = file;
                                    picBxCandyGallery.ImageLocation = file;
                                    showingQualityImage = true;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        deletedFiles.Add(file);
                        deletedCount += 1;
                    }
                }

                foreach (var file in deletedFiles)
                {
                    File.Delete(file);
                }

                var message = string.Join(Environment.NewLine, deletedFiles);
                Cursor.Current = originalCursor;

                MessageBox.Show($"The following files were deleted ({deletedCount}):\n\n{message}",
                    @"Clean Up Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenItemLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentMedia = lblCurrentMediaPath.Text;
            if (!string.IsNullOrWhiteSpace(currentMedia))
            {
                var index = currentMedia.LastIndexOf("\\", StringComparison.Ordinal);
                currentMedia = currentMedia.Substring(0, index);
                Process.Start("explorer.exe", currentMedia);
            }

            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        #region PictureBox Handling

        // **************************************************************************************************

        public void DisplayMediaInMainPictureBox(string newPath)
        {
            ResetImageIntoView();
            AddCurrentItemToBackList();
            lblCurrentMediaPath.Text = newPath;
            LoadItemIntoViewer(newPath);

            btnRandomize.Focus();
        }

        public void OpenVideo(string itemPath)
        {
            var videoPlayer = new CandyVideoWindow();
            lblCurrentMediaPath.Text = itemPath;
            if (CandyGalleryHelpers.IsVideoTypeMedia(itemPath))
            {
                videoPlayer.videoPlayer.URL = itemPath;
            }

            if (CandyGalleryHelpers.IsShortcutTypeMedia(itemPath))
            {
                var shell = new WshShell();
                var link = (IWshShortcut)shell.CreateShortcut(itemPath);
                videoPlayer.videoPlayer.URL = link.TargetPath;
            }

            picBxCandyGallery.Image = picBxCandyGallery.InitialImage;
            videoPlayer.ShowDialog();

            btnRandomize.Focus();
        }

        public void ResetImageIntoView()
        {
            picBxCandyGallery.BackColor = UserSettings.PerSessionSettings.BackgroundColor;
            picBxCandyGallery.Size = new Size(panelPictureBox.Width, panelPictureBox.Height);
            picBxCandyGallery.Location = new Point(0, 0);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            UserSettings.PerSessionSettings.PictureBoxMaximized = true;

            picBxCandyGallery.BackColor = Color.Black;
            picBxCandyGallery.BorderStyle = BorderStyle.None;
            tblLPFormBorder.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            UserSettings.PerSessionSettings.ControlParentToRestoreViewForMaximizedPicture =
                tblLPBottomControlStripUpper.Parent;

            tblLPBottomControlStripUpper.Parent = this;
            tblLPRightSideControlContainer.Parent = this;
            tblLPBottomControlStripLower.Parent = this;
            tblLPFormTopControls.Parent = this;

            tblLPFormBorder.RowStyles[0].Height = 0;
            tblLPMainForm.ColumnCount = 1;
            tblLPMainForm.RowCount = 1;

            WindowState = FormWindowState.Maximized;
            picBxCandyGallery.Height = Screen.PrimaryScreen.Bounds.Height;
            picBxCandyGallery.Width = Screen.PrimaryScreen.Bounds.Width;
            Cursor.Hide();
        }

        public void CloseMaxWindow()
        {
            UserSettings.PerSessionSettings.PictureBoxMaximized = false;

            picBxCandyGallery.BackColor = UserSettings.PerSessionSettings.BackgroundColor;
            picBxCandyGallery.BorderStyle = UserSettings.PerSessionSettings.DefaultBorderStyle;
            tblLPFormBorder.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tblLPFormBorder.RowStyles[0].Height = 20;
            tblLPMainForm.ColumnCount = 2;
            tblLPMainForm.RowCount = 3;

            tblLPBottomControlStripUpper.Parent =
                UserSettings.PerSessionSettings.ControlParentToRestoreViewForMaximizedPicture;
            tblLPRightSideControlContainer.Parent =
                UserSettings.PerSessionSettings.ControlParentToRestoreViewForMaximizedPicture;
            tblLPBottomControlStripLower.Parent =
                UserSettings.PerSessionSettings.ControlParentToRestoreViewForMaximizedPicture;
            tblLPFormTopControls.Parent = tblLPFormBorder;

            if (UserSettings.PerSessionSettings.GalleryMaximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

            Cursor.Show();
        }

        public void PictureBox_MouseDown(object sender, EventArgs e)
        {
            var mouse = e as MouseEventArgs;

            if (mouse != null && mouse.Button == MouseButtons.Left)
            {
                _mouseDown = mouse.Location;
            }

            else if (mouse != null && mouse.Button == MouseButtons.Right)
            {
                // Do something else if needed
            }
        }

        public void PictureBox_MouseMove(object sender, EventArgs e)
        {
            if (!(e is MouseEventArgs mouse) || mouse.Button != MouseButtons.Left) return;
            var mousePosNow = mouse.Location;

            var deltaX = mousePosNow.X - _mouseDown.X;
            var deltaY = mousePosNow.Y - _mouseDown.Y;

            var newX = picBxCandyGallery.Location.X + deltaX;
            var newY = picBxCandyGallery.Location.Y + deltaY;

            picBxCandyGallery.Location = new Point(newX, newY);
            picBxCandyGallery.Update();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            var img = picBxCandyGallery.Image;
            int newWidth = img.Width,
                newHeight = img.Height,
                newX = picBxCandyGallery.Location.X,
                newY = picBxCandyGallery.Location.Y;

            if (e.Delta > 0)
            {
                newWidth = picBxCandyGallery.Size.Width + picBxCandyGallery.Size.Width / 10;
                newHeight = picBxCandyGallery.Size.Height + picBxCandyGallery.Size.Height / 10;
                newX = picBxCandyGallery.Location.X - picBxCandyGallery.Size.Width / 10 / 2;
                newY = picBxCandyGallery.Location.Y - picBxCandyGallery.Size.Height / 10 / 2;
            }

            else if (e.Delta < 0)
            {
                newWidth = picBxCandyGallery.Size.Width - picBxCandyGallery.Size.Width / 10;
                newHeight = picBxCandyGallery.Size.Height - picBxCandyGallery.Size.Height / 10;
                newX = picBxCandyGallery.Location.X + picBxCandyGallery.Size.Width / 10 / 2;
                newY = picBxCandyGallery.Location.Y + picBxCandyGallery.Size.Height / 10 / 2;

                // Prevent image from zooming out beyond original size
                if (newWidth < panelPictureBox.Width)
                {
                    newWidth = panelPictureBox.Width;
                    newHeight = panelPictureBox.Height;
                    newX = 0;
                    newY = 0;
                }
            }

            picBxCandyGallery.Size = new Size(newWidth, newHeight);
            picBxCandyGallery.Location = new Point(newX, newY);
        }

        private void PictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //if (File.Exists(picBxCandyGallery.ImageLocation) 
            //    && (picBxCandyGallery.Image.Height <= 425 && picBxCandyGallery.Image.Width <= 625
            //     || picBxCandyGallery.Image.Height <= 625 && picBxCandyGallery.Image.Width <= 425)
            //    && CandyGalleryHelpers.IsImageTypeMedia(picBxCandyGallery.ImageLocation))
            //{
            //    LowResolutionImageRemoval();
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //}
        }

        // **************************************************************************************************

        #endregion

        #region Favorites Handling

        // **************************************************************************************************

        public void SetFavoriteAtNumber(int nonZeroIndex)
        {
            var itemLocation = lblCurrentMediaPath.Text;
            UserFavorite newFavorite;
            if (!File.Exists(itemLocation) && picBxCandyGallery.ImageLocation != null)
            {
                itemLocation = picBxCandyGallery.ImageLocation;
            }

            if (CandyGalleryHelpers.IsImageTypeMedia(itemLocation))
            {
                newFavorite = new UserFavorite
                {
                    Index = nonZeroIndex,
                    FullPath = itemLocation,
                    MediaType = MediaFilterType.Image
                };
            }
            else if (CandyGalleryHelpers.IsGifTypeMedia(itemLocation))
            {
                newFavorite = new UserFavorite
                {
                    Index = nonZeroIndex,
                    FullPath = itemLocation,
                    MediaType = MediaFilterType.Gif
                };
            }
            else
            {
                newFavorite = new UserFavorite
                {
                    Index = nonZeroIndex,
                    FullPath = itemLocation,
                    MediaType = MediaFilterType.Video
                };
            }

            if (UserSettings.UserFavorites.Count >= nonZeroIndex)
            {
                UserSettings.UserFavorites[nonZeroIndex - 1] = newFavorite;
            }
            else
            {
                newFavorite.Index = UserSettings.UserFavorites.Count + 1;
                nonZeroIndex = UserSettings.UserFavorites.Count + 1;
                UserSettings.UserFavorites.Add(newFavorite);
            }

            var itemName = new DirectoryInfo(lblCurrentMediaPath.Text).Name;
            picBxCandyGallery.BackColor = CandyInterfaceColors.GetInterfaceColorByName(UserSettings.UserInterfaceColorName);
            //MessageBox.Show($@"Created a new favorite for ""{itemName}"" as Favorite #{nonZeroIndex}!",
            //    @"Favorite Created!", MessageBoxButtons.OK);
            btnRandomize.Focus();
        }

        private void DisplayFavoriteByIndex(int favoriteIndex)
        {
            if (UserSettings.UserFavorites.Count >= favoriteIndex &&
                !string.IsNullOrWhiteSpace(UserSettings.UserFavorites[favoriteIndex - 1].FullPath))
            {
                UserSettings.PerSessionSettings.ForwardList.Clear();
                if (UserSettings.UserFavorites[favoriteIndex - 1].MediaType == MediaFilterType.Video)
                {
                    OpenVideo(UserSettings.UserFavorites[favoriteIndex - 1].FullPath);
                }
                else
                {
                    if (UserSettings.UserFavorites[favoriteIndex - 1].FullPath != lblCurrentMediaPath.Text)
                    {
                        DisplayMediaInMainPictureBox(UserSettings.UserFavorites[favoriteIndex - 1].FullPath);
                    }
                }
            }

            btnRandomize.Focus();
        }

        // **************************************************************************************************

        #endregion

        #region Image Filter Handling

        // **************************************************************************************************

        public Bitmap ApplyFilterToImage(string path)
        {
            try
            {
                var image = new Bitmap(path);
                var amount = UserSettings.ImageFilterAmount > 7 ? UserSettings.ImageFilterAmount : 7;

                switch (UserSettings.ImageFilterType)
                {
                    case ImageFilterType.Blur:
                        StackBlur.StackBlur.Process(image, amount);
                        break;
                    case ImageFilterType.Pixelate:
                        image = CandyImageFilters.Pixelate(image, amount);
                        break;
                    case ImageFilterType.Sobel:
                        image = CandyImageFilters.SobelEdgeFilter(image, amount);
                        break;
                    case ImageFilterType.Grayscale:
                        CandyImageFilters.Grayscale(image, amount);
                        break;
                    case ImageFilterType.Sepia:
                        CandyImageFilters.Sepia(image, amount);
                        break;
                    case ImageFilterType.Negative:
                        CandyImageFilters.Negative(image);
                        break;
                    case ImageFilterType.Colorize:
                        CandyImageFilters.Colorize(image, amount);
                        break;
                }

                return image;
            }
            catch
            {
                return null;
            }
        }

        // **************************************************************************************************

        #endregion

        #region Keyboard Shortcuts

        // **************************************************************************************************

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!UserSettings.PerSessionSettings.EnableHotKeys) return base.ProcessCmdKey(ref msg, keyData);
            switch (keyData)
            {
                case Keys.Escape:
                    if (UserSettings.PerSessionSettings.PictureBoxMaximized)
                    {
                        CloseMaxWindow();
                        return true;
                    }
                    if (UserSettings.PerSessionSettings.GalleryMaximized)
                    {
                        btnMaximizeGallery.PerformClick();
                        return true;
                    }
                    Close();
                    return true;
                case Keys.Left:
                case Keys.A:
                    btnGoBack.PerformClick();
                    return true;
                case Keys.Right:
                case Keys.D:
                    btnGoForward.PerformClick();
                    return true;
                case Keys.Up:
                case Keys.W:
                    btnSetPathToParentOfCurrentMedia.PerformClick();
                    return true;
                case Keys.Down:
                case Keys.S:
                    btnSetPathToFolderOfCurrentMedia.PerformClick();
                    return true;
                case Keys.Back:
                case Keys.R:
                case Keys.NumPad1:
                    btnResetPathToDefault.PerformClick();
                    return true;
                case Keys.NumPad0:
                case Keys.F:
                    if (UserSettings.PerSessionSettings.PictureBoxMaximized)
                    {
                        btnRandomize.PerformClick();
                        return true;
                    }
                    btnMaximize.PerformClick();
                    return true;
                case Keys.NumPad3:
                case Keys.V:
                    if (!UserSettings.PerSessionSettings.UserHasVideosFolder) return true;
                    btnVideosType.PerformClick();
                    btnRandomize.PerformClick();
                    return true;
                case Keys.P:
                    chkEnableShortcutType.Checked = !chkEnableShortcutType.Checked;
                    return true;
                case Keys.B:
                    chkApplyImageFilter.Checked = !chkApplyImageFilter.Checked;
                    return true;
                case Keys.H:
                    chkSlideShow.Checked = !(chkSlideShow.Checked);
                    return true;
                case Keys.Q:
                case Keys.Subtract:
                    btnSlideSpeedDown.PerformClick();
                    return true;
                case Keys.E:
                case Keys.Add:
                    btnSlideSpeedUp.PerformClick();
                    return true;
                case Keys.X:
                    chkApplyImageFilter.Checked = !(chkApplyImageFilter.Checked);
                    return true;
                case Keys.M:
                    btnViewFavorites.PerformClick();
                    return true;
                case Keys.G:
                    if (!UserSettings.PerSessionSettings.UserHasGifsFolder) return true;
                    btnGifType.PerformClick();
                    btnRandomize.PerformClick();
                    return true;
                case Keys.L:
                    chkFilterByNewest.Checked = !(chkFilterByNewest.Checked);
                    btnRandomize.PerformClick();
                    return true;
                case Keys.D1:
                    DisplayFavoriteByIndex(1);
                    return true;
                case Keys.D2:
                    DisplayFavoriteByIndex(2);
                    return true;
                case Keys.D3:
                    DisplayFavoriteByIndex(3);
                    return true;
                case Keys.D4:
                    DisplayFavoriteByIndex(4);
                    return true;
                case Keys.D5:
                    DisplayFavoriteByIndex(5);
                    return true;
                case Keys.D6:
                    DisplayFavoriteByIndex(6);
                    return true;
                case Keys.D7:
                    DisplayFavoriteByIndex(7);
                    return true;
                case Keys.D8:
                    DisplayFavoriteByIndex(8);
                    return true;
                case Keys.D9:
                    DisplayFavoriteByIndex(9);
                    return true;
                case Keys.D0:
                    DisplayFavoriteByIndex(10);
                    return true;
                case Keys.OemMinus:
                    DisplayFavoriteByIndex(11);
                    return true;
                case Keys.Oemplus:
                    DisplayFavoriteByIndex(12);
                    return true;
                case Keys.F1:
                    SetFavoriteAtNumber(1);
                    break;
                case Keys.F2:
                    SetFavoriteAtNumber(2);
                    break;
                case Keys.F3:
                    SetFavoriteAtNumber(3);
                    break;
                case Keys.F4:
                    SetFavoriteAtNumber(4);
                    break;
                case Keys.F5:
                    SetFavoriteAtNumber(5);
                    break;
                case Keys.F6:
                    SetFavoriteAtNumber(6);
                    break;
                case Keys.F7:
                    SetFavoriteAtNumber(7);
                    break;
                case Keys.F8:
                    SetFavoriteAtNumber(8);
                    break;
                case Keys.F9:
                    SetFavoriteAtNumber(9);
                    break;
                case Keys.F10:
                    SetFavoriteAtNumber(10);
                    break;
                case Keys.F11:
                    SetFavoriteAtNumber(11);
                    break;
                case Keys.F12:
                    SetFavoriteAtNumber(12);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // **************************************************************************************************

        #endregion

        #region Form Closing Handling

        // **************************************************************************************************

        private void CandyGallery_FormClosing(object sender, FormClosingEventArgs e)
        {
            var cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (UserSettings.PreserveSessionHistory)
            {
                AddCurrentItemToBackList();
                picBxCandyGallery.Image = null;
                lblCurrentMediaPath.BackColor = Color.ForestGreen;
                lblCurrentMediaPath.ForeColor = Color.MintCream;
                lblCurrentMediaPath.Text = @"S A V I N G............";
                picBxCandyGallery.Update();
                lblCurrentMediaPath.Update();
                SaveSessionHistory();
            }

            Rand.Dispose();
            SaveLoadSettingsHandler.SaveUserSettings(UserSettings);
            Cursor.Current = cursor;
            Dispose();
            Environment.Exit(0);
        }

        public void SaveSessionHistory()
        {
            if (!UserSettings.PreserveSessionHistory) return;
            UserSettings.SessionHistory = UserSettings.PerSessionSettings.BackList;
        }

        // **************************************************************************************************

        #endregion

        // **************************************************************************************************

        #endregion

        #region DEPRECATED
        // **************************************************************************************************

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (chkSlideShow.Checked)
            {
                if (chkSlideShow.Checked) continue;
                chkSlideShow.Checked = false;
                btnSlideSpeedDown.Hide();
                btnSlideSpeedUp.Hide();
                lblCurrentSlideSpeed.Hide();
                break;
            }
        }

        // **************************************************************************************************
        #endregion
    }
}
