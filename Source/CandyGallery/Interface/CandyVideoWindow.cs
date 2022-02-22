using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Helpers;
using CandyGallery.Models;

namespace CandyGallery.Interface
{
    public partial class CandyVideoWindow : Form, IMessageFilter
    {
        private const uint WM_KEYDOWN = 0x0100;
        ////////// Used to make form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        ////////// Used to make form draggable
        
        public CandyVideoWindow()
        {
            Cursor.Current = null;
            Cursor = CandyGalleryHelpers.LoadCustomCursor();
            InitializeComponent();
            videoPlayer.settings.autoStart = true;
            videoPlayer.settings.volume = 100;
            KeyPreview = true;
            lblCandyVideoTitle.ForeColor = 
                CandyInterfaceColors.GetInterfaceColorByName(Program.CandyGalleryWindow.UserSettings.UserInterfaceColorName);
        }

        public void CandyVideoWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Program.CandyGalleryWindow.UserSettings.FullscreenVideosOnOpen || Program.CandyGalleryWindow.UserSettings.PerSessionSettings.GalleryMaximized)
            {
                videoPlayer.fullScreen = true;
            }
        }

        private void CandyViewWindow_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);
        }

        private void CandyViewWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                var keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                if (keyCode == Keys.Escape && videoPlayer.fullScreen)
                {
                    videoPlayer.fullScreen = false;
                    return true;
                }

                if (keyCode == Keys.Escape && !videoPlayer.fullScreen)
                {
                    Dispose();
                    Close();
                    return true;
                }
            }
            return false;
        }

        private void MaximizeVideo_Click(object sender, EventArgs e)
        {
            videoPlayer.fullScreen = true;
        }

        private void ExitVideo_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
