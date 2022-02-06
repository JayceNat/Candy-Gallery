using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using CandyGallery.Helpers;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandyMultipleRandomWindow : Form
    {
        ////////// Used to make form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        ////////// Used to make form draggable

        public string CurrentMediaSelection = "";
        public bool FormMaximized = false;
        public int nameLength = "picBx".Length;
        public Image errorImg = Program.CandyGalleryWindow.picBxCandyGallery.ErrorImage;

        public string itemFullPath1 { get; set; }
        public string itemFullPath2 { get; set; }
        public string itemFullPath3 { get; set; }
        public string itemFullPath4 { get; set; }
        public string itemFullPath5 { get; set; }
        public string itemFullPath6 { get; set; }
        public string itemFullPath7 { get; set; }
        public string itemFullPath8 { get; set; }
        public string itemFullPath9 { get; set; }
        public string itemFullPath10 { get; set; }
        public string itemFullPath11 { get; set; }
        public string itemFullPath12 { get; set; }
        public string itemFullPath13 { get; set; }
        public string itemFullPath14 { get; set; }
        public string itemFullPath15 { get; set; }

        public CandyMultipleRandomWindow()
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            InitializeComponent();
            SetFormColors();
            SetPictureBoxContextStrips();
            Shown += CandyMultiRandomWindow_Shown;
        }

        private void CandyMultiRandomWindow_Shown(object sender, EventArgs e)
        {
            btnRandomBlast.PerformClick();
        }

        public void CandyMultiRandomWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RandomBlast_Click(object sender, EventArgs e)
        {
            var cursor = Cursors.Default;
            Cursor.Current = Cursors.WaitCursor;
            NullAllPictureBoxes();
            DeselectMediaSelection();
            var startFolder = Program.CandyGalleryWindow.UserSettings.StartFolderPath;

            itemFullPath1 = WaitForRandom(Randomize(startFolder));
            itemFullPath2 = WaitForRandom(Randomize(startFolder));
            itemFullPath3 = WaitForRandom(Randomize(startFolder));
            itemFullPath4 = WaitForRandom(Randomize(startFolder));
            itemFullPath5 = WaitForRandom(Randomize(startFolder));
            itemFullPath6 = WaitForRandom(Randomize(startFolder));
            itemFullPath7 = WaitForRandom(Randomize(startFolder));
            itemFullPath8 = WaitForRandom(Randomize(startFolder));
            itemFullPath9 = WaitForRandom(Randomize(startFolder));
            itemFullPath10 = WaitForRandom(Randomize(startFolder));
            itemFullPath11 = WaitForRandom(Randomize(startFolder));
            itemFullPath12 = WaitForRandom(Randomize(startFolder));
            itemFullPath13 = WaitForRandom(Randomize(startFolder));
            itemFullPath14 = WaitForRandom(Randomize(startFolder));
            itemFullPath15 = WaitForRandom(Randomize(startFolder));

            if (Program.CandyGalleryWindow.UserSettings.ApplyFilterToSubWindows && Program.CandyGalleryWindow.UserSettings.ApplyImageFilter)
            {
                picBx1.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath1) ?? errorImg;
                picBx2.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath2) ?? errorImg;
                picBx3.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath3) ?? errorImg;
                picBx4.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath4) ?? errorImg;
                picBx5.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath5) ?? errorImg;
                picBx6.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath6) ?? errorImg;
                picBx7.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath7) ?? errorImg;
                picBx8.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath8) ?? errorImg;
                picBx9.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath9) ?? errorImg;
                picBx10.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath10) ?? errorImg;
                picBx11.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath11) ?? errorImg;
                picBx12.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath12) ?? errorImg;
                picBx13.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath13) ?? errorImg;
                picBx14.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath14) ?? errorImg;
                picBx15.Image = Program.CandyGalleryWindow.ApplyFilterToImage(itemFullPath15) ?? errorImg;
            }
            else
            {
                picBx1.ImageLocation = itemFullPath1;
                picBx2.ImageLocation = itemFullPath2;
                picBx3.ImageLocation = itemFullPath3;
                picBx4.ImageLocation = itemFullPath4;
                picBx5.ImageLocation = itemFullPath5;
                picBx6.ImageLocation = itemFullPath6;
                picBx7.ImageLocation = itemFullPath7;
                picBx8.ImageLocation = itemFullPath8;
                picBx9.ImageLocation = itemFullPath9;
                picBx10.ImageLocation = itemFullPath10;
                picBx11.ImageLocation = itemFullPath11;
                picBx12.ImageLocation = itemFullPath12;
                picBx13.ImageLocation = itemFullPath13;
                picBx14.ImageLocation = itemFullPath14;
                picBx15.ImageLocation = itemFullPath15;
            }
            
            Cursor.Current = cursor;
        }

        private void FavoriteSelection_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CurrentMediaSelection))
            {
                var itemName = new DirectoryInfo(CurrentMediaSelection).Name;
                var nonZeroIndex = Program.CandyGalleryWindow.UserSettings.UserFavorites.Count + 1;
                var newFavorite = new UserFavorite
                {
                    Index = nonZeroIndex,
                    FullPath = CurrentMediaSelection,
                    MediaType = CandyGalleryHelpers.IsImageTypeMedia(CurrentMediaSelection) ? MediaFilterType.Image : MediaFilterType.Gif
                };
                Program.CandyGalleryWindow.UserSettings.UserFavorites.Add(newFavorite);
                DeselectMediaSelection();
                //MessageBox.Show($@"Created a new favorite for ""{itemName}"" as Favorite #{nonZeroIndex}!",
                //    @"Favorite Created!", MessageBoxButtons.OK);
            }
        }

        private void OpenSelection_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CurrentMediaSelection))
            {
                var item = CurrentMediaSelection;
                btnExitMultiRandom.PerformClick();
                Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(item);
            }
        }

        private void ExitMultiRandom_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void MaximizeMultiRandom_Click(object sender, EventArgs e)
        {
            if (FormMaximized)
            {
                MinimizeForm();
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormMaximized = true;
            }
        }

        private void AddToMainViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem menuItem)) return;
            if (!(menuItem.GetCurrentParent() is ContextMenuStrip contextMenu)) return;
            if (contextMenu.SourceControl is PictureBox pictureBox)
            {
                var id = pictureBox.Name.Remove(0, nameLength);
                var matchingLocation = GetMatchingImgLocation(id);
                if (!string.IsNullOrEmpty(matchingLocation))
                {
                    Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(matchingLocation);
                    RemoveImgLocation(id);
                    pictureBox.ImageLocation = null;
                    pictureBox.Image = pictureBox.InitialImage;
                    DeselectMediaSelection();
                }
            }
        }

        #region PictureBox Click Handling

        private void PicBx1_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx1);
        }

        private void PicBx2_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx2);
        }

        private void PicBx3_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx3);
        }

        private void PicBx4_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx4);
        }

        private void PicBx5_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx5);
        }

        private void PicBx6_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx6);
        }

        private void PicBx7_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx7);
        }

        private void PicBx8_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx8);
        }

        private void PicBx9_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx9);
        }

        private void PicBx10_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx10);
        }

        private void PicBx11_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx11);
        }

        private void PicBx12_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx12);
        }

        private void PicBx13_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx13);
        }

        private void PicBx14_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx14);
        }

        private void PicBx15_Click(object sender, EventArgs e)
        {
            SelectPictureBox(picBx15);
        }

        #endregion

        #region Helper Methods

        private void MinimizeForm()
        {
            WindowState = FormWindowState.Normal;
            FormMaximized = false;
        }

        private void SelectPictureBox(PictureBox pictureBox)
        {
            var matchingLocation = GetMatchingImgLocation(pictureBox.Name.Remove(0, nameLength));
            if (!string.IsNullOrWhiteSpace(matchingLocation))
            {
                if (matchingLocation == CurrentMediaSelection
                    && pictureBox.BorderStyle == BorderStyle.Fixed3D)
                {
                    btnOpenSelection.PerformClick();
                    return;
                }
                DeselectMediaSelection();
                CurrentMediaSelection = matchingLocation;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictureBox.BackColor =
                    CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                        .UserInterfaceColorName);
            }
        }

        private string GetMatchingImgLocation(string id)
        {
            switch (id)
            {
                case "1": return itemFullPath1;
                case "2": return itemFullPath2;
                case "3": return itemFullPath3;
                case "4": return itemFullPath4;
                case "5": return itemFullPath5;
                case "6": return itemFullPath6;
                case "7": return itemFullPath7;
                case "8": return itemFullPath8;
                case "9": return itemFullPath9;
                case "10": return itemFullPath10;
                case "11": return itemFullPath11;
                case "12": return itemFullPath12;
                case "13": return itemFullPath13;
                case "14": return itemFullPath14;
                case "15": return itemFullPath15;
                default: return "";
            }                    
        }

        public void RemoveImgLocation(string id)
        {
            switch (id)
            {
                case "1": itemFullPath1 = ""; break;
                case "2": itemFullPath2 = ""; break;
                case "3": itemFullPath3 = ""; break;
                case "4": itemFullPath4 = ""; break;
                case "5": itemFullPath5 = ""; break;
                case "6": itemFullPath6 = ""; break;
                case "7": itemFullPath7 = ""; break;
                case "8": itemFullPath8 = ""; break;
                case "9": itemFullPath9 = ""; break;
                case "10": itemFullPath10 = ""; break;
                case "11": itemFullPath11 = ""; break;
                case "12": itemFullPath12 = ""; break;
                case "13": itemFullPath13 = ""; break;
                case "14": itemFullPath14 = ""; break;
                case "15": itemFullPath15 = ""; break;
                default: break;
            }
        }

        private void DeselectMediaSelection()
        {
            CurrentMediaSelection = "";
            ResetPictureBoxStyle(picBx1);
            ResetPictureBoxStyle(picBx2);
            ResetPictureBoxStyle(picBx3);
            ResetPictureBoxStyle(picBx4);
            ResetPictureBoxStyle(picBx5);
            ResetPictureBoxStyle(picBx6);
            ResetPictureBoxStyle(picBx7);
            ResetPictureBoxStyle(picBx8);
            ResetPictureBoxStyle(picBx9);
            ResetPictureBoxStyle(picBx10);
            ResetPictureBoxStyle(picBx11);
            ResetPictureBoxStyle(picBx12);
            ResetPictureBoxStyle(picBx13);
            ResetPictureBoxStyle(picBx14);
            ResetPictureBoxStyle(picBx15);
        }

        private void NullAllPictureBoxes()
        {
            picBx1.Image = null;
            picBx2.Image = null;
            picBx3.Image = null;
            picBx4.Image = null;
            picBx5.Image = null;
            picBx6.Image = null;
            picBx7.Image = null;
            picBx8.Image = null;
            picBx9.Image = null;
            picBx10.Image = null;
            picBx11.Image = null;
            picBx12.Image = null;
            picBx13.Image = null;
            picBx14.Image = null;
            picBx15.Image = null;

            picBx1.ImageLocation = null;
            picBx2.ImageLocation = null;
            picBx3.ImageLocation = null;
            picBx4.ImageLocation = null;
            picBx5.ImageLocation = null;
            picBx6.ImageLocation = null;
            picBx7.ImageLocation = null;
            picBx8.ImageLocation = null;
            picBx9.ImageLocation = null;
            picBx10.ImageLocation = null;
            picBx11.ImageLocation = null;
            picBx12.ImageLocation = null;
            picBx13.ImageLocation = null;
            picBx14.ImageLocation = null;
            picBx15.ImageLocation = null;
        }

        private static void ResetPictureBoxStyle(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.FromArgb(32, 32, 32);
            pictureBox.BorderStyle = BorderStyle.None;
        }

        private void SetFormColors()
        {
            lblCandyMultiRandomTitle.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnFavoriteSelection.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnOpenSelection.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnRandomBlast.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
        }

        private void SetPictureBoxContextStrips()
        {
            picBx1.ContextMenuStrip = contextMenuStrip;
            picBx2.ContextMenuStrip = contextMenuStrip;
            picBx3.ContextMenuStrip = contextMenuStrip;
            picBx4.ContextMenuStrip = contextMenuStrip;
            picBx5.ContextMenuStrip = contextMenuStrip;
            picBx6.ContextMenuStrip = contextMenuStrip;
            picBx7.ContextMenuStrip = contextMenuStrip;
            picBx8.ContextMenuStrip = contextMenuStrip;
            picBx9.ContextMenuStrip = contextMenuStrip;
            picBx10.ContextMenuStrip = contextMenuStrip;
            picBx11.ContextMenuStrip = contextMenuStrip;
            picBx12.ContextMenuStrip = contextMenuStrip;
            picBx13.ContextMenuStrip = contextMenuStrip;
            picBx14.ContextMenuStrip = contextMenuStrip;
            picBx15.ContextMenuStrip = contextMenuStrip;
        }

        private string WaitForRandom(string path)
        {
            Thread.Sleep(15);
            if (Program.CandyGalleryWindow.UserSettings.UnseenItems != null
                && Program.CandyGalleryWindow.UserSettings.UnseenItems.Count > 0
                && !Program.CandyGalleryWindow.UserSettings.ApplyImageFilter)
            {
                Program.CandyGalleryWindow.UserSettings.UnseenItems.Remove(path);
            }
            return path;
        }

        public string Randomize(string path)
        {
            try
            {
                int randomItem;
                string winningItem;

                var items = Directory.GetDirectories(path);

                if (items.Length >= 1)
                {
                    randomItem = Program.CandyGalleryWindow.RandomInteger(0, items.Length);
                    winningItem = items[randomItem];
                    path = Randomize(winningItem);
                    return path;
                }

                items = Directory.GetFiles(path);
                randomItem = Program.CandyGalleryWindow.RandomInteger(0, items.Length);
                winningItem = items[randomItem];

                if (CandyGalleryHelpers.IsVideoTypeMedia(winningItem) || CandyGalleryHelpers.IsShortcutTypeMedia(winningItem))
                {
                    winningItem = Randomize(Program.CandyGalleryWindow.UserSettings.StartFolderPath);
                }

                return winningItem;
            }
            catch (Exception)
            {
                return "";
            }
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                case Keys.Space:
                    btnRandomBlast.PerformClick();
                    return true;
                case Keys.Escape:
                    if (!string.IsNullOrWhiteSpace(CurrentMediaSelection))
                    {
                        DeselectMediaSelection();
                        return true;
                    }
                    if (FormMaximized)
                    {
                        MinimizeForm();
                        return true;
                    }
                    btnExitMultiRandom.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
