using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandyKeyboardShortcutWindow : Form
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

        public CandyKeyboardShortcutWindow()
        {
            InitializeComponent();

            lblCandyKeyboardShortcutTitle.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
        }

        public void CandyKeyboardShortcutWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region UI Event Handlers

        private void ExitFavorites_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Dispose();
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
