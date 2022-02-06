using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using CandyGallery.Helpers;
using CandyGallery.Models;
using CandyGallery.Serialization;

namespace CandyGallery.Interface
{
    public partial class CandySettingsFileViewerWindow : Form
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

        public CandySettingsFileViewerWindow()
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            InitializeComponent();

            var file =
                $"{Application.StartupPath}\\CandyGalleryUserSettings\\{Program.CandyGalleryWindow.UserSettings.UserName.ToLower()}_CandyGalleryUserSettings.xml";
            if (File.Exists(file))
            {
                var xmlDocument = new XmlDocument {PreserveWhitespace = true};
                xmlDocument.LoadXml(File.ReadAllText(file));
                var decryptedContents = SaveLoadSettingsHandler.DecryptUserSettingsDirectFromContent(xmlDocument, Program.CandyGalleryWindow.UserSettings.PerSessionSettings.LoadedSettingsFileWasEncrypted);
                richTextBox.Text = decryptedContents;
            }
            else
            {
                MessageBox.Show($"Unable to read settings file for: \n\n\"file\"",
                    @"Error Reading Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Close();
            }

            lblCandySettingsFileViewer.ForeColor = 
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName);
            btnCopySettingsText.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName);
            btnSaveSettings.BackColor = 
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName);
        }

        public void CandySettingsViewerWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitSettingsViewer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to overwrite your existing settings file?" +
                                "\n\nIf improper changes have been added, you may corrupt all settings for this user. This cannot be undone!" +
                                "\n\n*Saving will close down Candy Gallery*",
                    @"Overwrite User Settings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(richTextBox.Text);
                SaveLoadSettingsHandler.EncryptAndSaveUserSettingsDirectToFile(xmlDocument, Program.CandyGalleryWindow.UserSettings.EncryptSettingsFile);
                Close();
            }
        }

        private void CopySettingsText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.Text);
            MessageBox.Show(@"User settings contents were copied to the clipboard!",
                @"User Settings Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
    }
}
