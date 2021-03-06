﻿using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandySettingsWindow : Form
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

        public CandySettingsWindow()
        {
            InitializeComponent();

            picBxUserAvatar.Image = Program.CandyGalleryWindow.picBxUserAvatar.Image;
            cmbBxImageFilterToApply.Text = Program.CandyGalleryWindow.UserSettings.ImageFilterType;
            cmbBxColorTheme.Text = Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName;
            chkApplyColorToRandomButton.Checked = Program.CandyGalleryWindow.UserSettings.ApplyColorToRandomizeButton;
            chkPreserveHistory.Checked = Program.CandyGalleryWindow.UserSettings.PreserveSessionHistory;
            chkOpenVideosFullscreen.Checked = Program.CandyGalleryWindow.UserSettings.FullscreenVideosOnOpen;
        }

        #region Event Handlers

        public void CandySettingsWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageFilterToApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.CandyGalleryWindow.UserSettings.ImageFilterType = cmbBxImageFilterToApply.Text;
        }

        private void ColorTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUIColor = CandyInterfaceColors.GetInterfaceColorByName(cmbBxColorTheme.Text);

            Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName = newUIColor == CandyInterfaceColors.CandyRed && cmbBxColorTheme.Text != "Cherry" ? "Cherry" : cmbBxColorTheme.Text;
            Program.CandyGalleryWindow.LoadColorOntoInterface(newUIColor);
            LoadColorOntoSettingsPage(newUIColor);
        }

        private void ApplyColorToRandomButton_CheckedChanged(object sender, EventArgs e)
        {
            Program.CandyGalleryWindow.UserSettings.ApplyColorToRandomizeButton = chkApplyColorToRandomButton.Checked;
            if (chkApplyColorToRandomButton.Checked)
            {
                Program.CandyGalleryWindow.btnRandomize.BackColor = CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName);
            }
            else
            {
                Program.CandyGalleryWindow.btnRandomize.BackColor = Color.DarkGoldenrod;
            }
        }

        private void PreserveHistory_CheckedChanged(object sender, EventArgs e)
        {
            Program.CandyGalleryWindow.UserSettings.PreserveSessionHistory = chkPreserveHistory.Checked;
        }

        private void OpenVideosFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            Program.CandyGalleryWindow.UserSettings.FullscreenVideosOnOpen = chkPreserveHistory.Checked;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.LightGray;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightGray;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                Program.CandyGalleryWindow.UserSettings.UserName = txtUsername.Text;
                var styledUsername = "";
                foreach (var character in txtUsername.Text)
                {
                    styledUsername += character.ToString().ToUpper() + " ";
                }
                Program.CandyGalleryWindow.lblUsername.Text = styledUsername;
                txtUsername.BackColor = Color.MediumSeaGreen;
            }

            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Program.CandyGalleryWindow.UserSettings.Pass = txtPassword.Text;
                txtPassword.BackColor = Color.MediumSeaGreen;
            }
        }

        private void UserAvatar_Click(object sender, EventArgs e)
        {
            LoadNextAvatar();
        }

        private void LastAvatarImage_Click(object sender, EventArgs e)
        {
            if (Program.CandyGalleryWindow.UserSettings.UserAvatarKey > 1)
            {
                Program.CandyGalleryWindow.UserSettings.UserAvatarKey -= 1;
                picBxUserAvatar.Image = 
                    Program.CandyGalleryWindow.imageListAvatars.Images[Program.CandyGalleryWindow.UserSettings.UserAvatarKey - 1];
                Program.CandyGalleryWindow.picBxUserAvatar.Image =
                    Program.CandyGalleryWindow.imageListAvatars.Images[Program.CandyGalleryWindow.UserSettings.UserAvatarKey - 1];
            }
        }

        private void NextAvatarImage_Click(object sender, EventArgs e)
        {
            LoadNextAvatar();
        }

        private void ExportUserSettings_Click(object sender, EventArgs e)
        {
            var file =
                $"{Application.StartupPath}\\CandyGalleryUserSettings\\{Program.CandyGalleryWindow.UserSettings.UserName.ToLower()}_CandyGalleryUserSettings.xml";
            if (File.Exists(file))
            {
                if (MessageBox.Show(@"WARNING: Altering the settings file incorrectly in any way may corrupt the whole file!",
                    @"User Settings Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var settingsViewer = new CandySettingsFileViewerWindow();
                    settingsViewer.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    $@"Hmm... The settings file for {Program.CandyGalleryWindow.UserSettings.UserName.ToUpper()} was not found!",
                    @"User Settings File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewKeyboardShortcuts_Click(object sender, EventArgs e)
        {
            using (var shortcuts = new CandyKeyboardShortcutWindow())
            {
                shortcuts.ShowDialog();
            }
        }

        private void DeleteAllFavorites_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                $"Are you sure you want to delete all ({Program.CandyGalleryWindow.UserSettings.UserFavorites.Count}) of your favorites?\n\nThis cannot be undone!",
                "Confirm Delete All Favorites", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Program.CandyGalleryWindow.UserSettings.UserFavorites.Clear();
            }
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"Are you sure you want to delete all ({Program.CandyGalleryWindow.UserSettings.PerSessionSettings.BackList.Count}) items in your history?\n\nThis cannot be undone!",
                    "Confirm Delete History", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Program.CandyGalleryWindow.UserSettings.PerSessionSettings.BackList.Clear();
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"This will permanently delete the user: {Program.CandyGalleryWindow.UserSettings.UserName.ToUpper()}. \n\nThis cannot be undone, are you sure you wish to continue?",
                    $"Confirm Delete User: {Program.CandyGalleryWindow.UserSettings.UserName.ToUpper()}", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var file = $"{Application.StartupPath}\\CandyGalleryUserSettings\\{Program.CandyGalleryWindow.UserSettings.UserName.ToLower()}_CandyGalleryUserSettings.xml";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }

                Dispose();
                Environment.Exit(0);
            }
        }

        private void ResetUserSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"This will delete all settings, reset, and close the Candy Gallery for this user (Username & Password are preserved).\n\nThis cannot be undone, are you sure you want to continue?",
                    "Confirm Delete All Favorites", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var newUserSettings = new UserSettings
                {
                    UserName = Program.CandyGalleryWindow.UserSettings.UserName,
                    Pass = Program.CandyGalleryWindow.UserSettings.Pass,
                    StartFolderPath = ""
                };

                Program.CandyGalleryWindow.UserSettings = newUserSettings;
                Program.CandyGalleryWindow.UserSettings.PerSessionSettings.ResetCandyGallery = true;
                Close();
            }
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Helper Methods

        private void LoadNextAvatar()
        {
            if (Program.CandyGalleryWindow.UserSettings.UserAvatarKey
                < Program.CandyGalleryWindow.imageListAvatars.Images.Count)
            {
                Program.CandyGalleryWindow.UserSettings.UserAvatarKey += 1;
                picBxUserAvatar.Image =
                    Program.CandyGalleryWindow.imageListAvatars
                        .Images[Program.CandyGalleryWindow.UserSettings.UserAvatarKey - 1];
                Program.CandyGalleryWindow.picBxUserAvatar.Image =
                    Program.CandyGalleryWindow.imageListAvatars
                        .Images[Program.CandyGalleryWindow.UserSettings.UserAvatarKey - 1];
            }
        }

        private void LoadColorOntoSettingsPage(Color newUiColor)
        {
            btnViewKeyboardShortcuts.BackColor = newUiColor;
            btnViewUserSettingsFile.BackColor = newUiColor;
            btnSaveSettings.BackColor = newUiColor;
            btnLastAvatarImage.ForeColor = newUiColor;
            btnNextAvatarImage.ForeColor = newUiColor;
            lblCandySettings.ForeColor = newUiColor;
            lblImageFilterToApply.ForeColor = newUiColor;
            lblColorTheme.ForeColor = newUiColor;
            lblNewUsername.ForeColor = newUiColor;
            lblNewPassword.ForeColor = newUiColor;
            chkApplyColorToRandomButton.ForeColor = newUiColor;
            chkPreserveHistory.ForeColor = newUiColor;
            chkOpenVideosFullscreen.ForeColor = newUiColor;
            Update();
        }

        #endregion
    }
}
