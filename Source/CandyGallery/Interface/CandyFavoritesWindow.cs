using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandyFavoritesWindow : Form
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

        public int CurrentMainDisplayedFavoriteIndex = 1;

        public CandyFavoritesWindow()
        {
            InitializeComponent();
            SetFormColors();
            NullAllPictureBoxImages();

            var count = 0;
            foreach (var favorite in Program.CandyGalleryWindow.UserSettings.UserFavorites)
            {
                count += 1;
                cmbBxFavoriteItemIndex.Items.Add(count);
                PopulateFavoriteTypeFilterCombo(favorite);

                if (count == 1)
                {
                    HandleLoadingVideoFavorite(favorite, picBxFavoriteMain);
                    lblCurrentMediaPath.Text = favorite.FullPath;
                }

                if (count == 2)
                {
                    HandleLoadingVideoFavorite(favorite, picBxFavoriteNext);
                }

                if (count == 3)
                {
                    HandleLoadingVideoFavorite(favorite, picBxFavoriteNextNext);
                }
            }
            StylePictureBoxes();
        }

        public void CandyFavoritesWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region UI Event Handlers

        private void FavoriteItemIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = int.Parse(cmbBxFavoriteItemIndex.Text);
            var userFavorites = Program.CandyGalleryWindow.UserSettings.UserFavorites;
            CurrentMainDisplayedFavoriteIndex = index;
            NullAllPictureBoxImages();
            NullSidePictureBoxImageLocations();

            HandleLoadingVideoFavorite(userFavorites[index - 1], picBxFavoriteMain);
            lblCurrentMediaPath.Text = userFavorites[index - 1].FullPath;

            if (index < userFavorites.Count)
            {
                HandleLoadingVideoFavorite(userFavorites[index], picBxFavoriteNext);

                if (index + 1 < userFavorites.Count)
                {
                    HandleLoadingVideoFavorite(userFavorites[index + 1], picBxFavoriteNextNext);
                }
            }

            if (index > 1)
            {
                HandleLoadingVideoFavorite(userFavorites[index - 2], picBxFavoriteLast);

                if (index - 3 >= 0)
                {
                    HandleLoadingVideoFavorite(userFavorites[index - 3], picBxFavoriteLastLast);
                }
            }
            StylePictureBoxes();
        }

        private void FavoriteTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LastFavorite_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteLast.Image != null)
            {
                CurrentMainDisplayedFavoriteIndex -= 1;

                if (picBxFavoriteNext.Image == picBxFavoriteNext.InitialImage)
                {
                    picBxFavoriteNextNext.ImageLocation = null;
                    picBxFavoriteNextNext.Image = picBxFavoriteNextNext.InitialImage;
                }
                else
                {
                    picBxFavoriteNextNext.Image = null;
                    picBxFavoriteNextNext.ImageLocation = picBxFavoriteNext.ImageLocation;
                }

                if (picBxFavoriteMain.Image == picBxFavoriteMain.InitialImage)
                {
                    picBxFavoriteNext.ImageLocation = null;
                    picBxFavoriteNext.Image = picBxFavoriteNext.InitialImage;
                }
                else
                {
                    picBxFavoriteNext.Image = null;
                    picBxFavoriteNext.ImageLocation = picBxFavoriteMain.ImageLocation;
                }

                if (picBxFavoriteLast.Image == picBxFavoriteLast.InitialImage)
                {
                    picBxFavoriteMain.ImageLocation = null;
                    picBxFavoriteMain.Image = picBxFavoriteMain.InitialImage;
                }
                else
                {
                    picBxFavoriteMain.Image = null;
                    picBxFavoriteMain.ImageLocation = picBxFavoriteLast.ImageLocation;
                }

                if (picBxFavoriteLastLast.Image == picBxFavoriteLastLast.InitialImage)
                {
                    picBxFavoriteLast.ImageLocation = null;
                    picBxFavoriteLast.Image = picBxFavoriteLast.InitialImage;
                }
                else
                {
                    picBxFavoriteLast.Image = null;
                    picBxFavoriteLast.ImageLocation = picBxFavoriteLastLast.ImageLocation;
                }

                HandleLastLastPicBoxMediaFlow();
                lblCurrentMediaPath.Text = Program.CandyGalleryWindow.UserSettings
                    .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1].FullPath;
                StylePictureBoxes();
            }
        }

        private void NextFavorite_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteNext.Image != null)
            {
                CurrentMainDisplayedFavoriteIndex += 1;

                if (picBxFavoriteLast.Image == picBxFavoriteLast.InitialImage)
                {
                    picBxFavoriteLastLast.ImageLocation = null;
                    picBxFavoriteLastLast.Image = picBxFavoriteLastLast.InitialImage;
                }
                else
                {
                    picBxFavoriteLastLast.Image = null;
                    picBxFavoriteLastLast.ImageLocation = picBxFavoriteLast.ImageLocation;
                }

                if (picBxFavoriteMain.Image == picBxFavoriteMain.InitialImage)
                {
                    picBxFavoriteLast.ImageLocation = null;
                    picBxFavoriteLast.Image = picBxFavoriteLast.InitialImage;
                }
                else
                {
                    picBxFavoriteLast.Image = null;
                    picBxFavoriteLast.ImageLocation = picBxFavoriteMain.ImageLocation;
                }

                if (picBxFavoriteNext.Image == picBxFavoriteNext.InitialImage)
                {
                    picBxFavoriteMain.ImageLocation = null;
                    picBxFavoriteMain.Image = picBxFavoriteMain.InitialImage;
                }
                else
                {
                    picBxFavoriteMain.Image = null;
                    picBxFavoriteMain.ImageLocation = picBxFavoriteNext.ImageLocation;
                }

                if (picBxFavoriteNextNext.Image == picBxFavoriteNextNext.InitialImage)
                {
                    picBxFavoriteNext.ImageLocation = null;
                    picBxFavoriteNext.Image = picBxFavoriteNext.InitialImage;
                }
                else
                {
                    picBxFavoriteNext.Image = null;
                    picBxFavoriteNext.ImageLocation = picBxFavoriteNextNext.ImageLocation;
                }

                HandleNextNextPicBoxMediaFlow();
                lblCurrentMediaPath.Text = Program.CandyGalleryWindow.UserSettings
                    .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1].FullPath;
                StylePictureBoxes();
            }
        }

        private void DeleteFavorite_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteMain.Image == null) return;

            if (MessageBox.Show(@"Are you sure you want to delete this favorite?", @"Confirm Delete Favorite",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                Program.CandyGalleryWindow.UserSettings.UserFavorites.RemoveAt(CurrentMainDisplayedFavoriteIndex - 1);
                cmbBxFavoriteItemIndex.Items.RemoveAt(cmbBxFavoriteItemIndex.Items.Count - 1);
                cmbBxFavoriteTypeFilter.Items.Clear();
                cmbBxFavoriteTypeFilter.Items.Add(MediaFilterType.All);

                var index = 1;
                foreach (var favorite in Program.CandyGalleryWindow.UserSettings.UserFavorites)
                {
                    favorite.Index = index;
                    PopulateFavoriteTypeFilterCombo(favorite);
                    index += 1;
                }

                if (picBxFavoriteNext.Image != null)
                {
                    HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                        .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1], picBxFavoriteMain);

                    if (CurrentMainDisplayedFavoriteIndex < Program.CandyGalleryWindow.UserSettings.UserFavorites.Count)
                    {
                        HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                            .UserFavorites[CurrentMainDisplayedFavoriteIndex], picBxFavoriteNext);
                    }
                    else
                    {
                        picBxFavoriteNext.Image = null;
                        picBxFavoriteNext.ImageLocation = null;
                    }

                    HandleNextNextPicBoxMediaFlow();
                    lblCurrentMediaPath.Text = Program.CandyGalleryWindow.UserSettings
                        .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1].FullPath;
                }

                else if (picBxFavoriteLast.Image != null)
                {
                    CurrentMainDisplayedFavoriteIndex -= 1;
                    HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                        .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1], picBxFavoriteMain);

                    if (CurrentMainDisplayedFavoriteIndex > 1)
                    {
                        HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                            .UserFavorites[CurrentMainDisplayedFavoriteIndex - 2], picBxFavoriteLast);
                    }
                    else
                    {
                        picBxFavoriteLast.Image = null;
                        picBxFavoriteLast.ImageLocation = null;
                    }

                    HandleLastLastPicBoxMediaFlow();
                    lblCurrentMediaPath.Text = Program.CandyGalleryWindow.UserSettings
                        .UserFavorites[CurrentMainDisplayedFavoriteIndex - 1].FullPath;
                }

                else
                {
                    picBxFavoriteMain.Image = null;
                    picBxFavoriteMain.ImageLocation = null;
                    lblCurrentMediaPath.Text = "";
                }

                StylePictureBoxes();
                Cursor.Current = Cursors.Default;
            }
        }

        private void ViewFavorite_Click(object sender, EventArgs e)
        {
            var index = CurrentMainDisplayedFavoriteIndex - 1;
            btnExitFavorites.PerformClick();
            Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(
                Program.CandyGalleryWindow.UserSettings
                    .UserFavorites[index].FullPath);
        }

        private void FavoriteMain_Click(object sender, EventArgs e)
        {
            btnViewFavorite.PerformClick();
        }

        private void FavoriteNext_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteNext.Image != null)
            {
                btnNextFavorite.PerformClick();
            }
        }

        private void FavoriteNextNext_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteNextNext.Image != null)
            {
                cmbBxFavoriteItemIndex.SelectedIndex = CurrentMainDisplayedFavoriteIndex + 1;
            }
        }

        private void FavoriteLast_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteLast.Image != null)
            {
                btnLastFavorite.PerformClick();
            }
        }

        private void FavoriteLastLast_Click(object sender, EventArgs e)
        {
            if (picBxFavoriteLastLast.Image != null)
            {
                cmbBxFavoriteItemIndex.SelectedIndex = CurrentMainDisplayedFavoriteIndex - 3;
            }
        }

        private void ExitFavorites_Click(object sender, EventArgs e)
        {
            NullAllPictureBoxImages();
            Dispose();
            Close();
        }

        #endregion

        #region Helper Methods

        private void NullAllPictureBoxImages()
        {
            picBxFavoriteMain.Image = null;
            picBxFavoriteNext.Image = null;
            picBxFavoriteNextNext.Image = null;
            picBxFavoriteLast.Image = null;
            picBxFavoriteLastLast.Image = null;
        }

        private void NullSidePictureBoxImageLocations()
        {
            picBxFavoriteNext.ImageLocation = null;
            picBxFavoriteNextNext.ImageLocation = null;
            picBxFavoriteLast.ImageLocation = null;
            picBxFavoriteLastLast.ImageLocation = null;
        }

        private void SetFormColors()
        {
            lblCandyFavoritesTitle.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            lblCurrentMediaPath.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            lblJumpToFavorite.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            lblFilterFavoriteType.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnLastFavorite.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNextFavorite.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnDeleteFavorite.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnViewFavorite.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
        }

        private void StylePictureBoxes()
        {
            picBxFavoriteLastLast.BackColor =
                picBxFavoriteLastLast.Image == null && string.IsNullOrWhiteSpace(picBxFavoriteLastLast.ImageLocation)
                    ? Color.Transparent
                    : Color.FromArgb(15, 15, 15);
            picBxFavoriteLast.BackColor =
                picBxFavoriteLast.Image == null && string.IsNullOrWhiteSpace(picBxFavoriteLast.ImageLocation)
                    ? Color.Transparent
                    : Color.FromArgb(20, 20, 20);
            picBxFavoriteNext.BackColor =
                picBxFavoriteNext.Image == null && string.IsNullOrWhiteSpace(picBxFavoriteNext.ImageLocation)
                    ? Color.Transparent
                    : Color.FromArgb(20, 20, 20);
            picBxFavoriteNextNext.BackColor =
                picBxFavoriteNextNext.Image == null && string.IsNullOrWhiteSpace(picBxFavoriteNextNext.ImageLocation)
                    ? Color.Transparent
                    : Color.FromArgb(15, 15, 15);
        }

        private void HandleLastLastPicBoxMediaFlow()
        {
            if (CurrentMainDisplayedFavoriteIndex > 2)
            {
                HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                    .UserFavorites[CurrentMainDisplayedFavoriteIndex - 3], picBxFavoriteLastLast);
            }
            else
            {
                picBxFavoriteLastLast.Image = null;
                picBxFavoriteLastLast.ImageLocation = null;
            }
        }

        private void HandleNextNextPicBoxMediaFlow()
        {
            if (Program.CandyGalleryWindow.UserSettings
                    .UserFavorites.Count >= CurrentMainDisplayedFavoriteIndex + 2)
            {
                HandleLoadingVideoFavorite(Program.CandyGalleryWindow.UserSettings
                    .UserFavorites[CurrentMainDisplayedFavoriteIndex + 1], picBxFavoriteNextNext);
            }
            else
            {
                picBxFavoriteNextNext.Image = null;
                picBxFavoriteNextNext.ImageLocation = null;
            }
        }
        private static void HandleLoadingVideoFavorite(UserFavorite favorite, PictureBox pictureBox)
        {
            if (favorite.MediaType == MediaFilterType.Video)
            {
                pictureBox.ImageLocation = null;
                pictureBox.Image = pictureBox.InitialImage;
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.ImageLocation = favorite.FullPath;
            }
        }


        private void PopulateFavoriteTypeFilterCombo(UserFavorite favorite)
        {
            if (!cmbBxFavoriteTypeFilter.Items.Contains(favorite.MediaType))
            {
                cmbBxFavoriteTypeFilter.Items.Add(favorite.MediaType);
            }
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.D:
                    btnNextFavorite.PerformClick();
                    return true;
                case Keys.Left:
                case Keys.A:
                    btnLastFavorite.PerformClick();
                    return true;
                case Keys.Escape:
                    btnExitFavorites.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
