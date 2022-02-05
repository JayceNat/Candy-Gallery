using System.Windows.Forms;

namespace CandyGallery.Interface
{
    partial class CandySettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandySettingsWindow));
            this.btnViewUserSettingsFile = new System.Windows.Forms.Button();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.cmbBxColorTheme = new System.Windows.Forms.ComboBox();
            this.lblColorTheme = new System.Windows.Forms.Label();
            this.btnDeleteAllFavorites = new System.Windows.Forms.Button();
            this.btnResetUserSettings = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.chkApplyColorToRandomButton = new System.Windows.Forms.CheckBox();
            this.lblImageFilterToApply = new System.Windows.Forms.Label();
            this.cmbBxImageFilterToApply = new System.Windows.Forms.ComboBox();
            this.lblCandySettings = new System.Windows.Forms.Label();
            this.btnExitSettings = new System.Windows.Forms.Button();
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPSettingsBorder = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewKeyboardShortcuts = new System.Windows.Forms.Button();
            this.chkPreserveHistory = new System.Windows.Forms.CheckBox();
            this.chkOpenVideosFullscreen = new System.Windows.Forms.CheckBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnLastAvatarImage = new System.Windows.Forms.Button();
            this.btnNextAvatarImage = new System.Windows.Forms.Button();
            this.picBxUserAvatar = new System.Windows.Forms.PictureBox();
            this.chkEncryptSettingsFile = new System.Windows.Forms.CheckBox();
            this.chkApplyFilterToSubWindows = new System.Windows.Forms.CheckBox();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.tblLPSettingsBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewUserSettingsFile
            // 
            this.btnViewUserSettingsFile.BackColor = System.Drawing.Color.Brown;
            this.btnViewUserSettingsFile.FlatAppearance.BorderSize = 0;
            this.btnViewUserSettingsFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUserSettingsFile.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewUserSettingsFile.Location = new System.Drawing.Point(11, 237);
            this.btnViewUserSettingsFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewUserSettingsFile.Name = "btnViewUserSettingsFile";
            this.btnViewUserSettingsFile.Size = new System.Drawing.Size(171, 23);
            this.btnViewUserSettingsFile.TabIndex = 21;
            this.btnViewUserSettingsFile.Text = "View Settings File";
            this.btnViewUserSettingsFile.UseVisualStyleBackColor = false;
            this.btnViewUserSettingsFile.Click += new System.EventHandler(this.ExportUserSettings_Click);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Black;
            this.lblNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNewUsername.Location = new System.Drawing.Point(192, 37);
            this.lblNewUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(83, 13);
            this.lblNewUsername.TabIndex = 18;
            this.lblNewUsername.Text = "New Username:";
            this.lblNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBxColorTheme
            // 
            this.cmbBxColorTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxColorTheme.BackColor = System.Drawing.Color.LightGray;
            this.cmbBxColorTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxColorTheme.FormattingEnabled = true;
            this.cmbBxColorTheme.Items.AddRange(new object[] {
            "Apple",
            "Blueberry",
            "Cherry",
            "Chocolate",
            "Coconut",
            "Creamsicle",
            "Grape",
            "Licorice",
            "Mango",
            "Mochi",
            "Peach",
            "Sour Blue",
            "Vanilla"});
            this.cmbBxColorTheme.Location = new System.Drawing.Point(269, 182);
            this.cmbBxColorTheme.Name = "cmbBxColorTheme";
            this.cmbBxColorTheme.Size = new System.Drawing.Size(96, 21);
            this.cmbBxColorTheme.Sorted = true;
            this.cmbBxColorTheme.TabIndex = 27;
            this.cmbBxColorTheme.SelectedIndexChanged += new System.EventHandler(this.ColorTheme_SelectedIndexChanged);
            // 
            // lblColorTheme
            // 
            this.lblColorTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorTheme.AutoSize = true;
            this.lblColorTheme.BackColor = System.Drawing.Color.Black;
            this.lblColorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorTheme.ForeColor = System.Drawing.Color.IndianRed;
            this.lblColorTheme.Location = new System.Drawing.Point(194, 185);
            this.lblColorTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorTheme.Name = "lblColorTheme";
            this.lblColorTheme.Size = new System.Drawing.Size(70, 13);
            this.lblColorTheme.TabIndex = 20;
            this.lblColorTheme.Text = "Color Theme:";
            this.lblColorTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteAllFavorites
            // 
            this.btnDeleteAllFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllFavorites.BackColor = System.Drawing.Color.Black;
            this.btnDeleteAllFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllFavorites.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllFavorites.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteAllFavorites.Location = new System.Drawing.Point(135, 307);
            this.btnDeleteAllFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteAllFavorites.Name = "btnDeleteAllFavorites";
            this.btnDeleteAllFavorites.Size = new System.Drawing.Size(87, 22);
            this.btnDeleteAllFavorites.TabIndex = 34;
            this.btnDeleteAllFavorites.Text = "Clear Favorites";
            this.btnDeleteAllFavorites.UseVisualStyleBackColor = false;
            this.btnDeleteAllFavorites.Click += new System.EventHandler(this.DeleteAllFavorites_Click);
            // 
            // btnResetUserSettings
            // 
            this.btnResetUserSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetUserSettings.BackColor = System.Drawing.Color.Black;
            this.btnResetUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetUserSettings.FlatAppearance.BorderSize = 0;
            this.btnResetUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetUserSettings.ForeColor = System.Drawing.Color.Maroon;
            this.btnResetUserSettings.Location = new System.Drawing.Point(13, 307);
            this.btnResetUserSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetUserSettings.Name = "btnResetUserSettings";
            this.btnResetUserSettings.Size = new System.Drawing.Size(48, 22);
            this.btnResetUserSettings.TabIndex = 32;
            this.btnResetUserSettings.Text = "Reset";
            this.btnResetUserSettings.UseVisualStyleBackColor = false;
            this.btnResetUserSettings.Click += new System.EventHandler(this.ResetUserSettings_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(280, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(83, 20);
            this.txtUsername.TabIndex = 23;
            this.txtUsername.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Brown;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveSettings.Location = new System.Drawing.Point(195, 85);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(168, 24);
            this.btnSaveSettings.TabIndex = 25;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(280, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(83, 20);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Black;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNewPassword.Location = new System.Drawing.Point(192, 63);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 25;
            this.lblNewPassword.Text = "New Password:";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteUser.Location = new System.Drawing.Point(61, 307);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(74, 23);
            this.btnDeleteUser.TabIndex = 33;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // chkApplyColorToRandomButton
            // 
            this.chkApplyColorToRandomButton.AutoSize = true;
            this.chkApplyColorToRandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkApplyColorToRandomButton.ForeColor = System.Drawing.Color.IndianRed;
            this.chkApplyColorToRandomButton.Location = new System.Drawing.Point(214, 205);
            this.chkApplyColorToRandomButton.Name = "chkApplyColorToRandomButton";
            this.chkApplyColorToRandomButton.Size = new System.Drawing.Size(151, 17);
            this.chkApplyColorToRandomButton.TabIndex = 28;
            this.chkApplyColorToRandomButton.Text = "Apply to Randomize Button";
            this.chkApplyColorToRandomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkApplyColorToRandomButton.UseVisualStyleBackColor = true;
            this.chkApplyColorToRandomButton.CheckedChanged += new System.EventHandler(this.ApplyColorToRandomButton_CheckedChanged);
            // 
            // lblImageFilterToApply
            // 
            this.lblImageFilterToApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageFilterToApply.AutoSize = true;
            this.lblImageFilterToApply.BackColor = System.Drawing.Color.Black;
            this.lblImageFilterToApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageFilterToApply.ForeColor = System.Drawing.Color.IndianRed;
            this.lblImageFilterToApply.Location = new System.Drawing.Point(194, 136);
            this.lblImageFilterToApply.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageFilterToApply.Name = "lblImageFilterToApply";
            this.lblImageFilterToApply.Size = new System.Drawing.Size(64, 13);
            this.lblImageFilterToApply.TabIndex = 31;
            this.lblImageFilterToApply.Text = "Image Filter:";
            this.lblImageFilterToApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBxImageFilterToApply
            // 
            this.cmbBxImageFilterToApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxImageFilterToApply.BackColor = System.Drawing.Color.LightGray;
            this.cmbBxImageFilterToApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxImageFilterToApply.FormattingEnabled = true;
            this.cmbBxImageFilterToApply.Items.AddRange(new object[] {
            "Blur",
            "Pixelate",
            "Sobel",
            "Colorize",
            "Grayscale",
            "Sepia",
            "Negative"});
            this.cmbBxImageFilterToApply.Location = new System.Drawing.Point(269, 133);
            this.cmbBxImageFilterToApply.Name = "cmbBxImageFilterToApply";
            this.cmbBxImageFilterToApply.Size = new System.Drawing.Size(96, 21);
            this.cmbBxImageFilterToApply.TabIndex = 26;
            this.cmbBxImageFilterToApply.SelectedIndexChanged += new System.EventHandler(this.ImageFilterToApply_SelectedIndexChanged);
            // 
            // lblCandySettings
            // 
            this.lblCandySettings.AutoSize = true;
            this.lblCandySettings.BackColor = System.Drawing.Color.Transparent;
            this.lblCandySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandySettings.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandySettings.ForeColor = System.Drawing.Color.Brown;
            this.lblCandySettings.Location = new System.Drawing.Point(30, 0);
            this.lblCandySettings.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandySettings.Name = "lblCandySettings";
            this.lblCandySettings.Size = new System.Drawing.Size(294, 18);
            this.lblCandySettings.TabIndex = 32;
            this.lblCandySettings.Text = "Candy Settings";
            this.lblCandySettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandySettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsWindow_MouseDown);
            // 
            // btnExitSettings
            // 
            this.btnExitSettings.BackColor = System.Drawing.Color.Maroon;
            this.btnExitSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitSettings.FlatAppearance.BorderSize = 0;
            this.btnExitSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSettings.Location = new System.Drawing.Point(326, 1);
            this.btnExitSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitSettings.Name = "btnExitSettings";
            this.btnExitSettings.Size = new System.Drawing.Size(46, 18);
            this.btnExitSettings.TabIndex = 33;
            this.btnExitSettings.Text = "X";
            this.btnExitSettings.UseVisualStyleBackColor = false;
            this.btnExitSettings.Click += new System.EventHandler(this.ExitSettings_Click);
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 2;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExitSettings, 1, 0);
            this.tblLPFormTopControls.Location = new System.Drawing.Point(1, 1);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(373, 20);
            this.tblLPFormTopControls.TabIndex = 34;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsWindow_MouseDown);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandySettings, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(324, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsWindow_MouseDown);
            // 
            // tblLPSettingsBorder
            // 
            this.tblLPSettingsBorder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPSettingsBorder.ColumnCount = 1;
            this.tblLPSettingsBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPSettingsBorder.Controls.Add(this.tblLPFormTopControls, 0, 0);
            this.tblLPSettingsBorder.Location = new System.Drawing.Point(0, 0);
            this.tblLPSettingsBorder.Name = "tblLPSettingsBorder";
            this.tblLPSettingsBorder.RowCount = 1;
            this.tblLPSettingsBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPSettingsBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tblLPSettingsBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tblLPSettingsBorder.Size = new System.Drawing.Size(375, 340);
            this.tblLPSettingsBorder.TabIndex = 35;
            // 
            // btnViewKeyboardShortcuts
            // 
            this.btnViewKeyboardShortcuts.BackColor = System.Drawing.Color.Brown;
            this.btnViewKeyboardShortcuts.FlatAppearance.BorderSize = 0;
            this.btnViewKeyboardShortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewKeyboardShortcuts.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewKeyboardShortcuts.Location = new System.Drawing.Point(11, 264);
            this.btnViewKeyboardShortcuts.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewKeyboardShortcuts.Name = "btnViewKeyboardShortcuts";
            this.btnViewKeyboardShortcuts.Size = new System.Drawing.Size(171, 23);
            this.btnViewKeyboardShortcuts.TabIndex = 22;
            this.btnViewKeyboardShortcuts.Text = "Keyboard Shortcuts";
            this.btnViewKeyboardShortcuts.UseVisualStyleBackColor = false;
            this.btnViewKeyboardShortcuts.Visible = false;
            this.btnViewKeyboardShortcuts.Click += new System.EventHandler(this.ViewKeyboardShortcuts_Click);
            // 
            // chkPreserveHistory
            // 
            this.chkPreserveHistory.AutoSize = true;
            this.chkPreserveHistory.BackColor = System.Drawing.Color.Black;
            this.chkPreserveHistory.Checked = true;
            this.chkPreserveHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreserveHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPreserveHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreserveHistory.ForeColor = System.Drawing.Color.IndianRed;
            this.chkPreserveHistory.Location = new System.Drawing.Point(214, 237);
            this.chkPreserveHistory.Margin = new System.Windows.Forms.Padding(1);
            this.chkPreserveHistory.Name = "chkPreserveHistory";
            this.chkPreserveHistory.Size = new System.Drawing.Size(83, 17);
            this.chkPreserveHistory.TabIndex = 29;
            this.chkPreserveHistory.Text = "Save History";
            this.chkPreserveHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPreserveHistory.UseVisualStyleBackColor = false;
            this.chkPreserveHistory.CheckedChanged += new System.EventHandler(this.PreserveHistory_CheckedChanged);
            // 
            // chkOpenVideosFullscreen
            // 
            this.chkOpenVideosFullscreen.AutoSize = true;
            this.chkOpenVideosFullscreen.BackColor = System.Drawing.Color.Black;
            this.chkOpenVideosFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOpenVideosFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpenVideosFullscreen.ForeColor = System.Drawing.Color.IndianRed;
            this.chkOpenVideosFullscreen.Location = new System.Drawing.Point(214, 273);
            this.chkOpenVideosFullscreen.Margin = new System.Windows.Forms.Padding(1);
            this.chkOpenVideosFullscreen.Name = "chkOpenVideosFullscreen";
            this.chkOpenVideosFullscreen.Size = new System.Drawing.Size(135, 17);
            this.chkOpenVideosFullscreen.TabIndex = 31;
            this.chkOpenVideosFullscreen.Text = "Open Videos Fullscreen";
            this.chkOpenVideosFullscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOpenVideosFullscreen.UseVisualStyleBackColor = false;
            this.chkOpenVideosFullscreen.CheckedChanged += new System.EventHandler(this.OpenVideosFullscreen_CheckedChanged);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearHistory.BackColor = System.Drawing.Color.Black;
            this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearHistory.Location = new System.Drawing.Point(222, 307);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(81, 22);
            this.btnClearHistory.TabIndex = 35;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // btnLastAvatarImage
            // 
            this.btnLastAvatarImage.BackColor = System.Drawing.Color.Black;
            this.btnLastAvatarImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastAvatarImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastAvatarImage.ForeColor = System.Drawing.Color.Brown;
            this.btnLastAvatarImage.Location = new System.Drawing.Point(11, 205);
            this.btnLastAvatarImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastAvatarImage.Name = "btnLastAvatarImage";
            this.btnLastAvatarImage.Size = new System.Drawing.Size(85, 23);
            this.btnLastAvatarImage.TabIndex = 19;
            this.btnLastAvatarImage.Text = "←";
            this.btnLastAvatarImage.UseVisualStyleBackColor = false;
            this.btnLastAvatarImage.Click += new System.EventHandler(this.LastAvatarImage_Click);
            // 
            // btnNextAvatarImage
            // 
            this.btnNextAvatarImage.BackColor = System.Drawing.Color.Black;
            this.btnNextAvatarImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAvatarImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAvatarImage.ForeColor = System.Drawing.Color.Brown;
            this.btnNextAvatarImage.Location = new System.Drawing.Point(97, 205);
            this.btnNextAvatarImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextAvatarImage.Name = "btnNextAvatarImage";
            this.btnNextAvatarImage.Size = new System.Drawing.Size(85, 23);
            this.btnNextAvatarImage.TabIndex = 20;
            this.btnNextAvatarImage.Text = "→";
            this.btnNextAvatarImage.UseVisualStyleBackColor = false;
            this.btnNextAvatarImage.Click += new System.EventHandler(this.NextAvatarImage_Click);
            // 
            // picBxUserAvatar
            // 
            this.picBxUserAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxUserAvatar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBxUserAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxUserAvatar.ErrorImage")));
            this.picBxUserAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxUserAvatar.InitialImage")));
            this.picBxUserAvatar.Location = new System.Drawing.Point(11, 34);
            this.picBxUserAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.picBxUserAvatar.Name = "picBxUserAvatar";
            this.picBxUserAvatar.Size = new System.Drawing.Size(171, 171);
            this.picBxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUserAvatar.TabIndex = 8;
            this.picBxUserAvatar.TabStop = false;
            this.picBxUserAvatar.Click += new System.EventHandler(this.UserAvatar_Click);
            // 
            // chkEncryptSettingsFile
            // 
            this.chkEncryptSettingsFile.AutoSize = true;
            this.chkEncryptSettingsFile.BackColor = System.Drawing.Color.Black;
            this.chkEncryptSettingsFile.Checked = true;
            this.chkEncryptSettingsFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptSettingsFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEncryptSettingsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEncryptSettingsFile.ForeColor = System.Drawing.Color.IndianRed;
            this.chkEncryptSettingsFile.Location = new System.Drawing.Point(214, 255);
            this.chkEncryptSettingsFile.Margin = new System.Windows.Forms.Padding(1);
            this.chkEncryptSettingsFile.Name = "chkEncryptSettingsFile";
            this.chkEncryptSettingsFile.Size = new System.Drawing.Size(119, 17);
            this.chkEncryptSettingsFile.TabIndex = 30;
            this.chkEncryptSettingsFile.Text = "Encrypt Settings File";
            this.chkEncryptSettingsFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEncryptSettingsFile.UseVisualStyleBackColor = false;
            this.chkEncryptSettingsFile.CheckedChanged += new System.EventHandler(this.EncryptSettingsFile_CheckedChanged);
            // 
            // chkApplyFilterToSubWindows
            // 
            this.chkApplyFilterToSubWindows.AutoSize = true;
            this.chkApplyFilterToSubWindows.Checked = true;
            this.chkApplyFilterToSubWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplyFilterToSubWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkApplyFilterToSubWindows.ForeColor = System.Drawing.Color.IndianRed;
            this.chkApplyFilterToSubWindows.Location = new System.Drawing.Point(214, 157);
            this.chkApplyFilterToSubWindows.Name = "chkApplyFilterToSubWindows";
            this.chkApplyFilterToSubWindows.Size = new System.Drawing.Size(130, 17);
            this.chkApplyFilterToSubWindows.TabIndex = 36;
            this.chkApplyFilterToSubWindows.Text = "Apply to Sub-Windows";
            this.chkApplyFilterToSubWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkApplyFilterToSubWindows.UseVisualStyleBackColor = true;
            this.chkApplyFilterToSubWindows.CheckedChanged += new System.EventHandler(this.ApplyFilterToSubWindows_CheckedChanged);
            // 
            // CandySettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(375, 340);
            this.Controls.Add(this.btnNextAvatarImage);
            this.Controls.Add(this.btnLastAvatarImage);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.lblImageFilterToApply);
            this.Controls.Add(this.cmbBxImageFilterToApply);
            this.Controls.Add(this.chkApplyFilterToSubWindows);
            this.Controls.Add(this.lblColorTheme);
            this.Controls.Add(this.cmbBxColorTheme);
            this.Controls.Add(this.chkApplyColorToRandomButton);
            this.Controls.Add(this.chkPreserveHistory);
            this.Controls.Add(this.chkEncryptSettingsFile);
            this.Controls.Add(this.chkOpenVideosFullscreen);
            this.Controls.Add(this.btnViewKeyboardShortcuts);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnResetUserSettings);
            this.Controls.Add(this.btnDeleteAllFavorites);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.picBxUserAvatar);
            this.Controls.Add(this.btnViewUserSettingsFile);
            this.Controls.Add(this.tblLPSettingsBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandySettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candy Settings";
            this.TopMost = true;
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.tblLPSettingsBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewUserSettingsFile;
        private System.Windows.Forms.PictureBox picBxUserAvatar;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.ComboBox cmbBxColorTheme;
        private System.Windows.Forms.Label lblColorTheme;
        private System.Windows.Forms.Button btnDeleteAllFavorites;
        private System.Windows.Forms.Button btnResetUserSettings;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.CheckBox chkApplyColorToRandomButton;
        private System.Windows.Forms.Label lblImageFilterToApply;
        private System.Windows.Forms.ComboBox cmbBxImageFilterToApply;
        private System.Windows.Forms.Label lblCandySettings;
        private System.Windows.Forms.Button btnExitSettings;
        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.TableLayoutPanel tblLPSettingsBorder;
        private System.Windows.Forms.Button btnViewKeyboardShortcuts;
        private CheckBox chkPreserveHistory;
        private CheckBox chkOpenVideosFullscreen;
        private Button btnClearHistory;
        private Button btnLastAvatarImage;
        private Button btnNextAvatarImage;
        private CheckBox chkEncryptSettingsFile;
        private CheckBox chkApplyFilterToSubWindows;
    }
}