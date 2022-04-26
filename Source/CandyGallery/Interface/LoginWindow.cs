using System;
using System.Collections.Generic;
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
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
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

                        userSettings = SetKeyboardShortcuts(userSettings);
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

        public Models.UserSettings SetKeyboardShortcuts(Models.UserSettings userSettings)
        {
            if (userSettings?.KeyboardShortcuts != null && userSettings.KeyboardShortcuts.Any())
            {
                return userSettings;
            }

            // Setting as Default since no defined Shortcuts
            userSettings.KeyboardShortcuts = new List<Models.KeyboardShortcut>
            {
                new Models.KeyboardShortcut
                {
                    Key = Keys.Escape.ToString(),
                    Action = Models.ShortcutActionType.Escape
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Enter.ToString(),
                    Action = Models.ShortcutActionType.Enter
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Space.ToString(),
                    Action = Models.ShortcutActionType.Randomize
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.A.ToString(),
                    Action = Models.ShortcutActionType.PreviousImage
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Left.ToString(),
                    Action = Models.ShortcutActionType.PreviousImage
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D.ToString(),
                    Action = Models.ShortcutActionType.NextImage
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Right.ToString(),
                    Action = Models.ShortcutActionType.NextImage
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.W.ToString(),
                    Action = Models.ShortcutActionType.SetPathToParentOfCurrentMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Up.ToString(),
                    Action = Models.ShortcutActionType.SetPathToParentOfCurrentMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.S.ToString(),
                    Action = Models.ShortcutActionType.SetPathToFolderOfCurrentMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Down.ToString(),
                    Action = Models.ShortcutActionType.SetPathToFolderOfCurrentMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Oem3.ToString(),
                    Action = Models.ShortcutActionType.ResetPathToDefault
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Back.ToString(),
                    Action = Models.ShortcutActionType.ResetPathToDefault
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F12.ToString(),
                    Action = Models.ShortcutActionType.FullscreenMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F11.ToString(),
                    Action = Models.ShortcutActionType.MaximizeWindow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F10.ToString(),
                    Action = Models.ShortcutActionType.MinimizeWindow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Z.ToString(),
                    Action = Models.ShortcutActionType.CandyAllMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.V.ToString(),
                    Action = Models.ShortcutActionType.CandyVideoFolder
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.C.ToString(),
                    Action = Models.ShortcutActionType.CandyGifFolder
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.X.ToString(),
                    Action = Models.ShortcutActionType.CandyOtherFolder
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F.ToString(),
                    Action = Models.ShortcutActionType.NewFavoriteFromMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.OemQuestion.ToString(),
                    Action = Models.ShortcutActionType.ApplyFilter
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.OemPeriod.ToString(),
                    Action = Models.ShortcutActionType.IncreaseFilterStrength
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Oemcomma.ToString(),
                    Action = Models.ShortcutActionType.DecreaseFilterStrength
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.U.ToString(),
                    Action = Models.ShortcutActionType.ViewUnseenMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.I.ToString(),
                    Action = Models.ShortcutActionType.ViewNewestMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.O.ToString(),
                    Action = Models.ShortcutActionType.ViewOldestMedia
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.P.ToString(),
                    Action = Models.ShortcutActionType.Slideshow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.OemCloseBrackets.ToString(),
                    Action = Models.ShortcutActionType.IncreaseSlideshowSpeed
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.OemOpenBrackets.ToString(),
                    Action = Models.ShortcutActionType.DecreaseSlideshowSpeed
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F1.ToString(),
                    Action = Models.ShortcutActionType.OpenBlastWindow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F2.ToString(),
                    Action = Models.ShortcutActionType.OpenFavoritesWindow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F3.ToString(),
                    Action = Models.ShortcutActionType.OpenSettingsWindow
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.F4.ToString(),
                    Action = Models.ShortcutActionType.ToggleSidebar
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D1.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite1
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D2.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite2
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D3.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite3
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D4.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite4
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D5.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite5
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D6.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite6
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D7.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite7
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D8.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite8
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D9.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite9
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.D0.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite10
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.OemMinus.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite11
                },
                new Models.KeyboardShortcut
                {
                    Key = Keys.Oemplus.ToString(),
                    Action = Models.ShortcutActionType.LoadFavorite12
                },
            };

            return userSettings;
        }
    }
}
