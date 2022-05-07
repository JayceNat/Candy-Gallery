using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Helpers;
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
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            InitializeComponent();
            SetFormColors();
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
            Program.CandyGalleryWindow.UserSettings.PerSessionSettings.ChildWindowOpen = false;
            Dispose();
            Close();
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

        }

        #region btn Click Handlers

        private void btnEscapeKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "ESC = Close/Collapse Current Window";
        }

        private void btnF1Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F1 = Open Blast! Window (from Main Gallery)";
        }

        private void btnF2Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F2 = Open Favorites Window (from Main Gallery)";
        }

        private void btnF3Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F3 = Open Settings Window (from Main Gallery)";
        }

        private void btnF4Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F4 = Toggle Sidebar (from Main Gallery)";
        }

        private void btnF5Key_Click(object sender, EventArgs e)
        {

        }

        private void btnF6Key_Click(object sender, EventArgs e)
        {

        }

        private void btnF7Key_Click(object sender, EventArgs e)
        {

        }

        private void btnF8Key_Click(object sender, EventArgs e)
        {

        }

        private void btnF9Key_Click(object sender, EventArgs e)
        {

        }

        private void btnF10Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F10 = Minimize Window (from Main Gallery)";
        }

        private void btnF11Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F11 = Maximize Window (from Main Gallery)";
        }

        private void btnF12Key_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F12 = Fullscreen Media (from Main Gallery)";
        }

        private void btnNumberTickKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "` = Reset the randomizer path to the default (from Main Gallery)";
        }

        private void btnNumberOneKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "1 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberTwoKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "2 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberThreeKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "3 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberFourKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "4 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberFiveKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "5 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberSixKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "6 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberSevenKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "7 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberEightKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "8 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberNineKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "9 = Show Favorite by Number (from Main Gallery)";
        }

        private void btnNumberTenKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "0 = Show Favorite by Number - 10 (from Main Gallery)";
        }

        private void btnNumberElevenKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "- = Show Favorite by Number - 11 (from Main Gallery)";
        }

        private void btnNumberTwelveKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "= = Show Favorite by Number - 12 (from Main Gallery)";
        }

        private void btnBackspaceKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Backspace = Reset the randomizer path to the default (from Main Gallery)";
        }

        private void btnQKey_Click(object sender, EventArgs e)
        {

        }

        private void btnWKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "W = Set the randomizer to the parent folder of the current working directory (from Main Gallery)";
        }

        private void btnEKey_Click(object sender, EventArgs e)
        {

        }

        private void btnRKey_Click(object sender, EventArgs e)
        {

        }

        private void btnTKey_Click(object sender, EventArgs e)
        {

        }

        private void btnYKey_Click(object sender, EventArgs e)
        {

        }

        private void btnUKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "U = Toggle 'Unseen' Checkbox (from Main Gallery)";
        }

        private void btnIKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "I = Toggle 'Newest' Checkbox (from Main Gallery)";
        }

        private void btnOKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "O = Toggle 'Oldest' Checkbox (from Main Gallery)";
        }

        private void btnPKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "P = Toggle Slideshow (from Main Gallery)";
        }

        private void btnLeftSquareBracketKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "[ = Decrease Slideshow Speed (from Main Gallery)";
        }

        private void btnRightSquareBracketKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "] = Increase Slideshow Speed (from Main Gallery)";
        }

        private void btnBackSlashKey_Click(object sender, EventArgs e)
        {

        }

        private void btnAKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "A = Previous Media Item";
        }

        private void btnSKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "S = Set randomizer path to the folder of current media (from Main Gallery)";
        }

        private void btnDKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "D = Next Media Item";
        }

        private void btnFKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "F = New Favorite from Shown Media (from Main Gallery)";
        }

        private void btnGKey_Click(object sender, EventArgs e)
        {

        }

        private void btnHKey_Click(object sender, EventArgs e)
        {

        }

        private void btnJKey_Click(object sender, EventArgs e)
        {

        }

        private void btnKKey_Click(object sender, EventArgs e)
        {

        }

        private void btnLKey_Click(object sender, EventArgs e)
        {

        }

        private void btnSemiColonKey_Click(object sender, EventArgs e)
        {

        }

        private void btnQuoteKey_Click(object sender, EventArgs e)
        {

        }

        private void btnEnterKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Enter = Primary Action of Current Window";
        }

        private void btnZKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Z = Set Current Folder Path to 'All' (from Main Gallery)";
        }

        private void btnXKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "X = Set Current Folder Path to 'Other' (from Main Gallery)";
        }

        private void btnCKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "C = Set Current Folder Path to 'Gif' (from Main Gallery)";
        }

        private void btnVKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "V = Set Current Folder Path to 'Video' (from Main Gallery)";
        }

        private void btnBKey_Click(object sender, EventArgs e)
        {

        }

        private void btnNKey_Click(object sender, EventArgs e)
        {

        }

        private void btnMKey_Click(object sender, EventArgs e)
        {

        }

        private void btnCommaKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = ", = Decrease Image Filter Strength (from Main Gallery)";
        }

        private void btnPeriodKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = ". = Increase Image Filter Strength (from Main Gallery)";
        }

        private void btnForwardSlashKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "/ = Toggle Image Filter (from Main Gallery)";
        }

        private void btnSpaceKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Space = Primary Action of Current Window";
        }

        private void btnUpArrowKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Arrow Up = Set the randomizer to the parent folder of the current working directory (from Main Gallery)";
        }

        private void btnDownArrowKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Arrow Down = Set randomizer path to the folder of current media (from Main Gallery)";
        }

        private void btnLeftArrowKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Arrow Left = Previous Media Item";
        }

        private void btnRightArrowKey_Click(object sender, EventArgs e)
        {
            labelPressedKeyInfo.Text = "Arrow Right = Next Media Item";
        }

        #endregion

        #endregion

        #region Helper Methods

        private void SetFormColors()
        {
            lblCandyKeyboardShortcutTitle.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            labelPressedKeyInfo.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnSeparator.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            // Mapped Keys
            btnEscapeKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF1Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF2Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF3Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF4Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF10Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF11Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF12Key.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberTickKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberOneKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberTwoKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberThreeKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberFourKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberFiveKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberSixKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberSevenKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberEightKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberNineKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberTenKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberElevenKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNumberTwelveKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnBackspaceKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnWKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnUKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnIKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnOKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnPKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnLeftSquareBracketKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnRightSquareBracketKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnAKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnSKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnDKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnFKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnEnterKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnZKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnXKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnCKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnVKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnPeriodKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnCommaKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnForwardSlashKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnUpArrowKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnDownArrowKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnLeftArrowKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnRightArrowKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnSpaceKey.BackColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            // Unmapped Keys
            btnF5Key.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF6Key.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF7Key.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF8Key.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnF9Key.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnQKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnEKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnRKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnTKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnYKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnBackSlashKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnGKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnHKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnJKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnKKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnLKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnSemiColonKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnQuoteKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnBKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnNKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
            btnMKey.ForeColor =
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings
                    .UserInterfaceColorName);
        }

        #endregion

        #region Keyboard Shortcuts

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var matchedShortcut = Program.CandyGalleryWindow.UserSettings.KeyboardShortcuts.FirstOrDefault(x => x.Key == keyData.ToString());
            if (matchedShortcut == null) return base.ProcessCmdKey(ref msg, keyData);
            switch (matchedShortcut.Action)
            {
                case ShortcutActionType.Escape:
                    Dispose();
                    Close();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
