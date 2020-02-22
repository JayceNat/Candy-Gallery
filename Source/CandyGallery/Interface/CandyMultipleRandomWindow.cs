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

        public CandyMultipleRandomWindow()
        {
            InitializeComponent();
            SetFormColors();
            SetPictureBoxContextStrips();
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
            NullAllPictureBoxes();
            DeselectMediaSelection();
            Cursor.Current = Cursors.WaitCursor;
            var startFolder = Program.CandyGalleryWindow.UserSettings.StartFolderPath;
            picBx1.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx2.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx3.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx4.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx5.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx6.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx7.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx8.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx9.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx10.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx11.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx12.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx13.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx14.ImageLocation = WaitForRandom(Randomize(startFolder));
            picBx15.ImageLocation = WaitForRandom(Randomize(startFolder));
            Cursor.Current = Cursors.Default;
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
                MessageBox.Show($@"Created a new favorite for ""{itemName}"" as Favorite #{nonZeroIndex}!",
                    @"Favorite Created!", MessageBoxButtons.OK);
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
            if (contextMenu.SourceControl is PictureBox pictureBox
                && !string.IsNullOrEmpty(pictureBox.ImageLocation))
            {
                Program.CandyGalleryWindow.DisplayMediaInMainPictureBox(pictureBox.ImageLocation);
                pictureBox.ImageLocation = null;
                pictureBox.Image = pictureBox.InitialImage;
                DeselectMediaSelection();
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
            if (!string.IsNullOrWhiteSpace(pictureBox.ImageLocation))
            {
                DeselectMediaSelection();
                CurrentMediaSelection = pictureBox.ImageLocation;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictureBox.BackColor =
                    CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                        .UserInterfaceColorName);
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
