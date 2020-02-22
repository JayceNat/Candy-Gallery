using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CandyGallery.Serialization;

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
            InitializeComponent();
            txtUsername.Select();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtUsername.BackColor = Color.Linen;
                txtPassword.BackColor = Color.Linen;

                var userSettings = SaveLoadSettingsHandler.TryLoadUserSettings(txtUsername.Text, txtPassword.Text);
                if (userSettings.Pass != txtPassword.Text)
                {
                    if (MessageBox.Show($"The provided password was incorrect for user \"{txtUsername.Text}\"... \nPlease try again.", "Incorrect Credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) != DialogResult.OK)
                    {
                        Close();
                        Dispose();
                    }

                    txtUsername.BackColor = Color.Linen;
                    txtPassword.Text = "";
                    txtPassword.BackColor = Color.Red;
                }

                else
                {
                    Hide();
                    Program.CandyGalleryWindow = new CandyGalleryWindow(userSettings);
                    try
                    {
                        Program.CandyGalleryWindow.Show();
                    }
                    catch (Exception) { Close(); }
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
