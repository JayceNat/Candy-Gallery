using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Helpers;
using CandyGallery.Serialization;
using Microsoft.Win32;

namespace CandyGallery.Interface
{
    public partial class LoginWindow : Form
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

        public LoginWindow()
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor(@"F:\Candy Gallery\Source\CandyGallery\Crystal.ani");
            Cursor.Current = Cursor;
            InitializeComponent();
            txtUsername.Select();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtUsername.BackColor = Color.Linen;
                txtPassword.BackColor = Color.Linen;

                var cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                var userSettings = SaveLoadSettingsHandler.TryLoadUserSettings(txtUsername.Text, txtPassword.Text);
                Cursor.Current = cursor;

                if (userSettings != null && userSettings.Pass != txtPassword.Text)
                {
                    if (MessageBox.Show($"The provided password was incorrect for user \"{txtUsername.Text}\"... \nPlease try again.", "Incorrect Credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) != DialogResult.OK)
                    {
                        Close();
                        Dispose();
                    }

                    txtUsername.BackColor = Color.Linen;
                    txtPassword.Text = "";
                    txtPassword.BackColor = Color.Red;

                    if (userSettings.PerSessionSettings.LoadedSettingsFileWasEncrypted)
                    {
                        SaveLoadSettingsHandler.EncryptSaveFileContents(userSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                    }
                }

                else
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        if (userSettings.PerSessionSettings.StartFolderMissingOnLoad)
                        {
                            var result = MessageBox.Show(
                                        @"The Start Folder for this user could not be located... Would you like to re-specify it's location?",
                                        @"Start Folder Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                var folderInit = new FolderBrowserDialog();
                                if (folderInit.ShowDialog() == DialogResult.OK)
                                {
                                    var originalStartFolderPath = userSettings.StartFolderPath;
                                    userSettings.StartFolderPath = folderInit.SelectedPath;

                                    var result2 = MessageBox.Show(
                                        @"Start Folder updated! Would you like to update saved data based on this new location for the current user?",
                                        @"Update Saved Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (result2 == DialogResult.Yes)
                                    {
                                        userSettings.UserFavorites?.ForEach(f => f.FullPath = !File.Exists(f.FullPath) ? f.FullPath.Replace(originalStartFolderPath, userSettings.StartFolderPath) : f.FullPath);
                                        if (userSettings.PerSessionSettings?.BackList?.Count > 0)
                                        {
                                            userSettings.PerSessionSettings.BackList = userSettings.PerSessionSettings.BackList.Select(b => !File.Exists(b) ? b.Replace(originalStartFolderPath, userSettings.StartFolderPath) : b).ToList();
                                        }
                                        if (userSettings.UnseenItems?.Count > 0)
                                        {
                                            userSettings.UnseenItems = userSettings.UnseenItems.Select(b => !File.Exists(b) ? b.Replace(originalStartFolderPath, userSettings.StartFolderPath) : b).ToList();
                                        }
                                    }
                                }
                                else
                                {
                                    if (userSettings.PerSessionSettings.LoadedSettingsFileWasEncrypted)
                                    {
                                        SaveLoadSettingsHandler.EncryptSaveFileContents(userSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                                    }
                                    throw new Exception();
                                }

                                folderInit.Dispose();
                            }
                            else
                            {
                                if (userSettings.PerSessionSettings.LoadedSettingsFileWasEncrypted)
                                {
                                    SaveLoadSettingsHandler.EncryptSaveFileContents(userSettings.PerSessionSettings.FullPathToCurrentSettingsFile);
                                }
                                throw new Exception();
                            }
                        }

                        Cursor.Current = cursor;
                        Hide();
                        Program.CandyGalleryWindow = new CandyGalleryWindow(userSettings);
                        Program.CandyGalleryWindow.Show();
                    }
                    catch (Exception) { Close(); Environment.Exit(0); }
                }
            }
            else
            {
                txtUsername.BackColor = Color.Linen;
                txtPassword.BackColor = Color.Linen;
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "";
                    txtUsername.BackColor = Color.Red;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "";
                    txtPassword.BackColor = Color.Red;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.Linen;
        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.Linen;
            txtPassword.PasswordChar = '\u25CF';
        }

        public void CandyLoginWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (btnSubmit.Enabled)
                    {
                        btnSubmit.PerformClick();
                    }
                    return true;
                case Keys.Escape:
                    Dispose();
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
