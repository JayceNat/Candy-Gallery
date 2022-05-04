using System.Windows.Forms;

namespace CandyGallery.Interface
{
    partial class CandyGalleryWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyGalleryWindow));
            this.tblLPMainForm = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPRightSideControlContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPRightSideControlContainerInnerLower = new System.Windows.Forms.TableLayoutPanel();
            this.btnOtherType = new System.Windows.Forms.Button();
            this.btnVideosType = new System.Windows.Forms.Button();
            this.btnGifType = new System.Windows.Forms.Button();
            this.btnAllType = new System.Windows.Forms.Button();
            this.lblOptionsSection = new System.Windows.Forms.Label();
            this.lblTypeSelectionSection = new System.Windows.Forms.Label();
            this.chkEnableShortcutType = new System.Windows.Forms.CheckBox();
            this.tblLPFilterByContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilterByCountIncrease = new System.Windows.Forms.Button();
            this.btnFilterByCountDecrease = new System.Windows.Forms.Button();
            this.chkFilterByUnseen = new System.Windows.Forms.CheckBox();
            this.chkFilterByOldest = new System.Windows.Forms.CheckBox();
            this.chkFilterByNewest = new System.Windows.Forms.CheckBox();
            this.txtFilterResultsByCount = new System.Windows.Forms.TextBox();
            this.tblLPApplyFilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilterStrengthDown = new System.Windows.Forms.Button();
            this.lblCurrentFilterStrength = new System.Windows.Forms.Label();
            this.btnFilterStrengthUp = new System.Windows.Forms.Button();
            this.chkApplyImageFilter = new System.Windows.Forms.CheckBox();
            this.tblLPRightSideControlContainerInnerUpper = new System.Windows.Forms.TableLayoutPanel();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMultiRandomizer = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnViewFavorites = new System.Windows.Forms.Button();
            this.chkSlideShow = new System.Windows.Forms.CheckBox();
            this.tblLPSlideShowSpeedContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnSlideSpeedDown = new System.Windows.Forms.Button();
            this.lblCurrentSlideSpeed = new System.Windows.Forms.Label();
            this.btnSlideSpeedUp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.picBxUserAvatar = new System.Windows.Forms.PictureBox();
            this.tblLPBottomControlStripLower = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetPathToFolderOfCurrentMedia = new System.Windows.Forms.Button();
            this.btnResetPathToDefault = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.btnSetPathToParentOfCurrentMedia = new System.Windows.Forms.Button();
            this.tblLPBottomControlStripUpper = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowCollapseSideBar = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.lblCurrentMediaPath = new System.Windows.Forms.Label();
            this.btnAddNewFavorite = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.picBxCandyGallery = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnExitGallery = new System.Windows.Forms.Button();
            this.btnMaximizeGallery = new System.Windows.Forms.Button();
            this.btnMinimizeGallery = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContextMenuPicturebox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenMediaLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsUserAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLPFormBorder = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandyTitle = new System.Windows.Forms.Label();
            this.imageListAvatars = new System.Windows.Forms.ImageList(this.components);
            this.tblLPMainForm.SuspendLayout();
            this.tblLPRightSideControlContainer.SuspendLayout();
            this.tblLPRightSideControlContainerInnerLower.SuspendLayout();
            this.tblLPFilterByContainer.SuspendLayout();
            this.tblLPApplyFilterContainer.SuspendLayout();
            this.tblLPRightSideControlContainerInnerUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.tblLPSlideShowSpeedContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUserAvatar)).BeginInit();
            this.tblLPBottomControlStripLower.SuspendLayout();
            this.tblLPBottomControlStripUpper.SuspendLayout();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCandyGallery)).BeginInit();
            this.toolStripContextMenuPicturebox.SuspendLayout();
            this.tblLPFormBorder.SuspendLayout();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLPMainForm
            // 
            this.tblLPMainForm.AutoScroll = true;
            this.tblLPMainForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLPMainForm.ColumnCount = 2;
            this.tblLPMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.17957F));
            this.tblLPMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.820427F));
            this.tblLPMainForm.Controls.Add(this.tblLPRightSideControlContainer, 1, 0);
            this.tblLPMainForm.Controls.Add(this.tblLPBottomControlStripLower, 0, 2);
            this.tblLPMainForm.Controls.Add(this.tblLPBottomControlStripUpper, 0, 1);
            this.tblLPMainForm.Controls.Add(this.panelPictureBox, 0, 0);
            this.tblLPMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPMainForm.Location = new System.Drawing.Point(1, 22);
            this.tblLPMainForm.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPMainForm.Name = "tblLPMainForm";
            this.tblLPMainForm.RowCount = 3;
            this.tblLPMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPMainForm.Size = new System.Drawing.Size(1282, 717);
            this.tblLPMainForm.TabIndex = 1;
            // 
            // tblLPRightSideControlContainer
            // 
            this.tblLPRightSideControlContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPRightSideControlContainer.ColumnCount = 1;
            this.tblLPRightSideControlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPRightSideControlContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPRightSideControlContainer.Controls.Add(this.tblLPRightSideControlContainerInnerLower, 0, 1);
            this.tblLPRightSideControlContainer.Controls.Add(this.tblLPRightSideControlContainerInnerUpper, 0, 0);
            this.tblLPRightSideControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPRightSideControlContainer.Location = new System.Drawing.Point(1158, 2);
            this.tblLPRightSideControlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.tblLPRightSideControlContainer.Name = "tblLPRightSideControlContainer";
            this.tblLPRightSideControlContainer.RowCount = 2;
            this.tblLPMainForm.SetRowSpan(this.tblLPRightSideControlContainer, 3);
            this.tblLPRightSideControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.70241F));
            this.tblLPRightSideControlContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.29759F));
            this.tblLPRightSideControlContainer.Size = new System.Drawing.Size(122, 713);
            this.tblLPRightSideControlContainer.TabIndex = 2;
            // 
            // tblLPRightSideControlContainerInnerLower
            // 
            this.tblLPRightSideControlContainerInnerLower.ColumnCount = 1;
            this.tblLPRightSideControlContainerInnerLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.btnOtherType, 0, 10);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.btnVideosType, 0, 9);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.btnGifType, 0, 8);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.btnAllType, 0, 7);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.lblOptionsSection, 0, 0);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.lblTypeSelectionSection, 0, 6);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.chkEnableShortcutType, 0, 11);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.tblLPFilterByContainer, 0, 2);
            this.tblLPRightSideControlContainerInnerLower.Controls.Add(this.tblLPApplyFilterContainer, 0, 1);
            this.tblLPRightSideControlContainerInnerLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPRightSideControlContainerInnerLower.Location = new System.Drawing.Point(1, 404);
            this.tblLPRightSideControlContainerInnerLower.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPRightSideControlContainerInnerLower.Name = "tblLPRightSideControlContainerInnerLower";
            this.tblLPRightSideControlContainerInnerLower.RowCount = 12;
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblLPRightSideControlContainerInnerLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPRightSideControlContainerInnerLower.Size = new System.Drawing.Size(120, 308);
            this.tblLPRightSideControlContainerInnerLower.TabIndex = 0;
            // 
            // btnOtherType
            // 
            this.btnOtherType.BackColor = System.Drawing.Color.Black;
            this.btnOtherType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOtherType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherType.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnOtherType.ForeColor = System.Drawing.Color.Brown;
            this.btnOtherType.Location = new System.Drawing.Point(2, 259);
            this.btnOtherType.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtherType.Name = "btnOtherType";
            this.btnOtherType.Size = new System.Drawing.Size(116, 24);
            this.btnOtherType.TabIndex = 20;
            this.btnOtherType.Text = "Other";
            this.toolTip.SetToolTip(this.btnOtherType, "Show \'Other\' Folder items");
            this.btnOtherType.UseVisualStyleBackColor = false;
            this.btnOtherType.Click += new System.EventHandler(this.OtherType_Click);
            // 
            // btnVideosType
            // 
            this.btnVideosType.BackColor = System.Drawing.Color.Black;
            this.btnVideosType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVideosType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideosType.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnVideosType.ForeColor = System.Drawing.Color.Brown;
            this.btnVideosType.Location = new System.Drawing.Point(2, 231);
            this.btnVideosType.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideosType.Name = "btnVideosType";
            this.btnVideosType.Size = new System.Drawing.Size(116, 24);
            this.btnVideosType.TabIndex = 19;
            this.btnVideosType.Text = "Videos";
            this.toolTip.SetToolTip(this.btnVideosType, "Show \'Videos\' Folder items");
            this.btnVideosType.UseVisualStyleBackColor = false;
            this.btnVideosType.Click += new System.EventHandler(this.VideosType_Click);
            // 
            // btnGifType
            // 
            this.btnGifType.BackColor = System.Drawing.Color.Black;
            this.btnGifType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGifType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGifType.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnGifType.ForeColor = System.Drawing.Color.Brown;
            this.btnGifType.Location = new System.Drawing.Point(2, 203);
            this.btnGifType.Margin = new System.Windows.Forms.Padding(2);
            this.btnGifType.Name = "btnGifType";
            this.btnGifType.Size = new System.Drawing.Size(116, 24);
            this.btnGifType.TabIndex = 18;
            this.btnGifType.Text = "Gifs";
            this.toolTip.SetToolTip(this.btnGifType, "Show \'Gif\' Folder items");
            this.btnGifType.UseVisualStyleBackColor = false;
            this.btnGifType.Click += new System.EventHandler(this.GifType_Click);
            // 
            // btnAllType
            // 
            this.btnAllType.BackColor = System.Drawing.Color.Brown;
            this.btnAllType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAllType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllType.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold);
            this.btnAllType.ForeColor = System.Drawing.Color.Black;
            this.btnAllType.Location = new System.Drawing.Point(2, 175);
            this.btnAllType.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllType.Name = "btnAllType";
            this.btnAllType.Size = new System.Drawing.Size(116, 24);
            this.btnAllType.TabIndex = 17;
            this.btnAllType.Text = "All";
            this.toolTip.SetToolTip(this.btnAllType, "Show All item types");
            this.btnAllType.UseVisualStyleBackColor = false;
            this.btnAllType.Click += new System.EventHandler(this.AllType_Click);
            // 
            // lblOptionsSection
            // 
            this.lblOptionsSection.AutoSize = true;
            this.lblOptionsSection.BackColor = System.Drawing.Color.Black;
            this.lblOptionsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOptionsSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionsSection.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOptionsSection.Location = new System.Drawing.Point(2, 2);
            this.lblOptionsSection.Margin = new System.Windows.Forms.Padding(2);
            this.lblOptionsSection.Name = "lblOptionsSection";
            this.lblOptionsSection.Size = new System.Drawing.Size(116, 19);
            this.lblOptionsSection.TabIndex = 3;
            this.lblOptionsSection.Text = "O P T I O N S";
            this.lblOptionsSection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTypeSelectionSection
            // 
            this.lblTypeSelectionSection.AutoSize = true;
            this.lblTypeSelectionSection.BackColor = System.Drawing.Color.Black;
            this.lblTypeSelectionSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeSelectionSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSelectionSection.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTypeSelectionSection.Location = new System.Drawing.Point(2, 152);
            this.lblTypeSelectionSection.Margin = new System.Windows.Forms.Padding(2);
            this.lblTypeSelectionSection.Name = "lblTypeSelectionSection";
            this.lblTypeSelectionSection.Size = new System.Drawing.Size(116, 19);
            this.lblTypeSelectionSection.TabIndex = 2;
            this.lblTypeSelectionSection.Text = "T Y P E";
            this.lblTypeSelectionSection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chkEnableShortcutType
            // 
            this.chkEnableShortcutType.AutoSize = true;
            this.chkEnableShortcutType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkEnableShortcutType.Checked = true;
            this.chkEnableShortcutType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableShortcutType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEnableShortcutType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnableShortcutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableShortcutType.ForeColor = System.Drawing.Color.Brown;
            this.chkEnableShortcutType.Location = new System.Drawing.Point(2, 287);
            this.chkEnableShortcutType.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnableShortcutType.Name = "chkEnableShortcutType";
            this.chkEnableShortcutType.Size = new System.Drawing.Size(116, 19);
            this.chkEnableShortcutType.TabIndex = 5;
            this.chkEnableShortcutType.Text = "Shortcuts";
            this.chkEnableShortcutType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.chkEnableShortcutType, "Show shortcut type items");
            this.chkEnableShortcutType.UseVisualStyleBackColor = false;
            this.chkEnableShortcutType.CheckedChanged += new System.EventHandler(this.EnableShortcuts_CheckedChanged);
            // 
            // tblLPFilterByContainer
            // 
            this.tblLPFilterByContainer.ColumnCount = 2;
            this.tblLPFilterByContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.84615F));
            this.tblLPFilterByContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.15385F));
            this.tblLPFilterByContainer.Controls.Add(this.btnFilterByCountIncrease, 1, 0);
            this.tblLPFilterByContainer.Controls.Add(this.btnFilterByCountDecrease, 1, 2);
            this.tblLPFilterByContainer.Controls.Add(this.chkFilterByUnseen, 0, 0);
            this.tblLPFilterByContainer.Controls.Add(this.chkFilterByOldest, 0, 2);
            this.tblLPFilterByContainer.Controls.Add(this.chkFilterByNewest, 0, 1);
            this.tblLPFilterByContainer.Controls.Add(this.txtFilterResultsByCount, 1, 1);
            this.tblLPFilterByContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPFilterByContainer.Location = new System.Drawing.Point(0, 77);
            this.tblLPFilterByContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFilterByContainer.Name = "tblLPFilterByContainer";
            this.tblLPFilterByContainer.RowCount = 3;
            this.tblLPRightSideControlContainerInnerLower.SetRowSpan(this.tblLPFilterByContainer, 2);
            this.tblLPFilterByContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPFilterByContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPFilterByContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPFilterByContainer.Size = new System.Drawing.Size(120, 68);
            this.tblLPFilterByContainer.TabIndex = 8;
            // 
            // btnFilterByCountIncrease
            // 
            this.btnFilterByCountIncrease.BackColor = System.Drawing.Color.Black;
            this.btnFilterByCountIncrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterByCountIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByCountIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByCountIncrease.ForeColor = System.Drawing.Color.Brown;
            this.btnFilterByCountIncrease.Location = new System.Drawing.Point(94, 0);
            this.btnFilterByCountIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterByCountIncrease.Name = "btnFilterByCountIncrease";
            this.btnFilterByCountIncrease.Size = new System.Drawing.Size(26, 22);
            this.btnFilterByCountIncrease.TabIndex = 21;
            this.btnFilterByCountIncrease.Text = "↑";
            this.toolTip.SetToolTip(this.btnFilterByCountIncrease, "Increase the number of files being sorted");
            this.btnFilterByCountIncrease.UseVisualStyleBackColor = false;
            this.btnFilterByCountIncrease.Visible = false;
            this.btnFilterByCountIncrease.Click += new System.EventHandler(this.FilterByCountIncrease_Click);
            // 
            // btnFilterByCountDecrease
            // 
            this.btnFilterByCountDecrease.BackColor = System.Drawing.Color.Black;
            this.btnFilterByCountDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterByCountDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByCountDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByCountDecrease.ForeColor = System.Drawing.Color.Brown;
            this.btnFilterByCountDecrease.Location = new System.Drawing.Point(94, 44);
            this.btnFilterByCountDecrease.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilterByCountDecrease.Name = "btnFilterByCountDecrease";
            this.btnFilterByCountDecrease.Size = new System.Drawing.Size(26, 24);
            this.btnFilterByCountDecrease.TabIndex = 20;
            this.btnFilterByCountDecrease.Text = "↓";
            this.toolTip.SetToolTip(this.btnFilterByCountDecrease, "Decrease the number of files being sorted");
            this.btnFilterByCountDecrease.UseVisualStyleBackColor = false;
            this.btnFilterByCountDecrease.Visible = false;
            this.btnFilterByCountDecrease.Click += new System.EventHandler(this.FilterByCountDecrease_Click);
            // 
            // chkFilterByUnseen
            // 
            this.chkFilterByUnseen.AutoSize = true;
            this.chkFilterByUnseen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkFilterByUnseen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFilterByUnseen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFilterByUnseen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterByUnseen.ForeColor = System.Drawing.Color.Brown;
            this.chkFilterByUnseen.Location = new System.Drawing.Point(2, 2);
            this.chkFilterByUnseen.Margin = new System.Windows.Forms.Padding(2);
            this.chkFilterByUnseen.Name = "chkFilterByUnseen";
            this.chkFilterByUnseen.Size = new System.Drawing.Size(90, 18);
            this.chkFilterByUnseen.TabIndex = 11;
            this.chkFilterByUnseen.Text = "Unseen";
            this.chkFilterByUnseen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.chkFilterByUnseen, "Filter media by unseen");
            this.chkFilterByUnseen.UseVisualStyleBackColor = false;
            this.chkFilterByUnseen.CheckedChanged += new System.EventHandler(this.UnseenItems_CheckedChanged);
            // 
            // chkFilterByOldest
            // 
            this.chkFilterByOldest.AutoSize = true;
            this.chkFilterByOldest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkFilterByOldest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFilterByOldest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFilterByOldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterByOldest.ForeColor = System.Drawing.Color.Brown;
            this.chkFilterByOldest.Location = new System.Drawing.Point(2, 46);
            this.chkFilterByOldest.Margin = new System.Windows.Forms.Padding(2);
            this.chkFilterByOldest.Name = "chkFilterByOldest";
            this.chkFilterByOldest.Size = new System.Drawing.Size(90, 20);
            this.chkFilterByOldest.TabIndex = 9;
            this.chkFilterByOldest.Text = "Oldest";
            this.chkFilterByOldest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.chkFilterByOldest, "Filter media by oldest");
            this.chkFilterByOldest.UseVisualStyleBackColor = false;
            this.chkFilterByOldest.CheckedChanged += new System.EventHandler(this.OldestItems_CheckedChanged);
            // 
            // chkFilterByNewest
            // 
            this.chkFilterByNewest.AutoSize = true;
            this.chkFilterByNewest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkFilterByNewest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFilterByNewest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFilterByNewest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilterByNewest.ForeColor = System.Drawing.Color.Brown;
            this.chkFilterByNewest.Location = new System.Drawing.Point(2, 24);
            this.chkFilterByNewest.Margin = new System.Windows.Forms.Padding(2);
            this.chkFilterByNewest.Name = "chkFilterByNewest";
            this.chkFilterByNewest.Size = new System.Drawing.Size(90, 18);
            this.chkFilterByNewest.TabIndex = 7;
            this.chkFilterByNewest.Text = "Newest";
            this.chkFilterByNewest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.chkFilterByNewest, "Filter media by newest");
            this.chkFilterByNewest.UseVisualStyleBackColor = false;
            this.chkFilterByNewest.CheckedChanged += new System.EventHandler(this.NewestItems_CheckedChanged);
            // 
            // txtFilterResultsByCount
            // 
            this.txtFilterResultsByCount.BackColor = System.Drawing.Color.DimGray;
            this.txtFilterResultsByCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterResultsByCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilterResultsByCount.Font = new System.Drawing.Font("Magneto", 7F, System.Drawing.FontStyle.Bold);
            this.txtFilterResultsByCount.Location = new System.Drawing.Point(94, 24);
            this.txtFilterResultsByCount.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtFilterResultsByCount.MaxLength = 2;
            this.txtFilterResultsByCount.Name = "txtFilterResultsByCount";
            this.txtFilterResultsByCount.Size = new System.Drawing.Size(26, 19);
            this.txtFilterResultsByCount.TabIndex = 8;
            this.txtFilterResultsByCount.Text = "30";
            this.txtFilterResultsByCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtFilterResultsByCount, "The number of folders to include");
            this.txtFilterResultsByCount.Visible = false;
            this.txtFilterResultsByCount.TextChanged += new System.EventHandler(this.FilterResultsByCount_TextChanged);
            // 
            // tblLPApplyFilterContainer
            // 
            this.tblLPApplyFilterContainer.ColumnCount = 3;
            this.tblLPApplyFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblLPApplyFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLPApplyFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLPApplyFilterContainer.Controls.Add(this.btnFilterStrengthDown, 0, 1);
            this.tblLPApplyFilterContainer.Controls.Add(this.lblCurrentFilterStrength, 1, 1);
            this.tblLPApplyFilterContainer.Controls.Add(this.btnFilterStrengthUp, 2, 1);
            this.tblLPApplyFilterContainer.Controls.Add(this.chkApplyImageFilter, 0, 0);
            this.tblLPApplyFilterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPApplyFilterContainer.Location = new System.Drawing.Point(0, 23);
            this.tblLPApplyFilterContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPApplyFilterContainer.Name = "tblLPApplyFilterContainer";
            this.tblLPApplyFilterContainer.RowCount = 2;
            this.tblLPApplyFilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblLPApplyFilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblLPApplyFilterContainer.Size = new System.Drawing.Size(120, 54);
            this.tblLPApplyFilterContainer.TabIndex = 10;
            // 
            // btnFilterStrengthDown
            // 
            this.btnFilterStrengthDown.BackColor = System.Drawing.Color.Brown;
            this.btnFilterStrengthDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterStrengthDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterStrengthDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterStrengthDown.Location = new System.Drawing.Point(2, 26);
            this.btnFilterStrengthDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterStrengthDown.Name = "btnFilterStrengthDown";
            this.btnFilterStrengthDown.Size = new System.Drawing.Size(35, 26);
            this.btnFilterStrengthDown.TabIndex = 18;
            this.btnFilterStrengthDown.Text = "-";
            this.toolTip.SetToolTip(this.btnFilterStrengthDown, "Decrease the filter strength");
            this.btnFilterStrengthDown.UseVisualStyleBackColor = false;
            this.btnFilterStrengthDown.Click += new System.EventHandler(this.FilterStrengthDown_Click);
            // 
            // lblCurrentFilterStrength
            // 
            this.lblCurrentFilterStrength.AutoSize = true;
            this.lblCurrentFilterStrength.BackColor = System.Drawing.Color.Black;
            this.lblCurrentFilterStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentFilterStrength.Font = new System.Drawing.Font("Magneto", 7F, System.Drawing.FontStyle.Bold);
            this.lblCurrentFilterStrength.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentFilterStrength.Location = new System.Drawing.Point(39, 24);
            this.lblCurrentFilterStrength.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentFilterStrength.Name = "lblCurrentFilterStrength";
            this.lblCurrentFilterStrength.Size = new System.Drawing.Size(40, 30);
            this.lblCurrentFilterStrength.TabIndex = 20;
            this.lblCurrentFilterStrength.Text = "20";
            this.lblCurrentFilterStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblCurrentFilterStrength, "Current filter strength");
            // 
            // btnFilterStrengthUp
            // 
            this.btnFilterStrengthUp.BackColor = System.Drawing.Color.Brown;
            this.btnFilterStrengthUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterStrengthUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterStrengthUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterStrengthUp.Location = new System.Drawing.Point(81, 26);
            this.btnFilterStrengthUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterStrengthUp.Name = "btnFilterStrengthUp";
            this.btnFilterStrengthUp.Size = new System.Drawing.Size(37, 26);
            this.btnFilterStrengthUp.TabIndex = 19;
            this.btnFilterStrengthUp.Text = "+";
            this.toolTip.SetToolTip(this.btnFilterStrengthUp, "Increase the filter strength");
            this.btnFilterStrengthUp.UseVisualStyleBackColor = false;
            this.btnFilterStrengthUp.Click += new System.EventHandler(this.FilterStrengthUp_Click);
            // 
            // chkApplyImageFilter
            // 
            this.chkApplyImageFilter.AutoSize = true;
            this.chkApplyImageFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chkApplyImageFilter.Checked = true;
            this.chkApplyImageFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tblLPApplyFilterContainer.SetColumnSpan(this.chkApplyImageFilter, 3);
            this.chkApplyImageFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkApplyImageFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkApplyImageFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyImageFilter.ForeColor = System.Drawing.Color.Brown;
            this.chkApplyImageFilter.Location = new System.Drawing.Point(2, 2);
            this.chkApplyImageFilter.Margin = new System.Windows.Forms.Padding(2);
            this.chkApplyImageFilter.Name = "chkApplyImageFilter";
            this.chkApplyImageFilter.Size = new System.Drawing.Size(116, 20);
            this.chkApplyImageFilter.TabIndex = 17;
            this.chkApplyImageFilter.Text = "Apply Filter";
            this.chkApplyImageFilter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.chkApplyImageFilter, "Applies the current filter setting to the media");
            this.chkApplyImageFilter.UseVisualStyleBackColor = false;
            this.chkApplyImageFilter.CheckedChanged += new System.EventHandler(this.ApplyImageFilter_CheckedChanged);
            // 
            // tblLPRightSideControlContainerInnerUpper
            // 
            this.tblLPRightSideControlContainerInnerUpper.ColumnCount = 3;
            this.tblLPRightSideControlContainerInnerUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6319F));
            this.tblLPRightSideControlContainerInnerUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.80368F));
            this.tblLPRightSideControlContainerInnerUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56442F));
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.videoPlayer, 1, 10);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.btnMultiRandomizer, 1, 2);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.lblUsername, 0, 0);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.btnViewFavorites, 1, 3);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.chkSlideShow, 0, 6);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.tblLPSlideShowSpeedContainer, 0, 7);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.btnSettings, 1, 4);
            this.tblLPRightSideControlContainerInnerUpper.Controls.Add(this.picBxUserAvatar, 0, 1);
            this.tblLPRightSideControlContainerInnerUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPRightSideControlContainerInnerUpper.Location = new System.Drawing.Point(1, 1);
            this.tblLPRightSideControlContainerInnerUpper.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPRightSideControlContainerInnerUpper.Name = "tblLPRightSideControlContainerInnerUpper";
            this.tblLPRightSideControlContainerInnerUpper.RowCount = 12;
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblLPRightSideControlContainerInnerUpper.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLPRightSideControlContainerInnerUpper.Size = new System.Drawing.Size(120, 402);
            this.tblLPRightSideControlContainerInnerUpper.TabIndex = 1;
            // 
            // videoPlayer
            // 
            this.videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(26, 329);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(70, 87);
            this.videoPlayer.TabIndex = 39;
            this.videoPlayer.Visible = false;
            this.videoPlayer.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.ProcessVideoPlayerCmdKey);
            // 
            // btnMultiRandomizer
            // 
            this.btnMultiRandomizer.BackColor = System.Drawing.Color.Black;
            this.btnMultiRandomizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiRandomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiRandomizer.Font = new System.Drawing.Font("Magneto", 10F, System.Drawing.FontStyle.Bold);
            this.btnMultiRandomizer.ForeColor = System.Drawing.Color.Brown;
            this.btnMultiRandomizer.Location = new System.Drawing.Point(25, 122);
            this.btnMultiRandomizer.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiRandomizer.Name = "btnMultiRandomizer";
            this.btnMultiRandomizer.Size = new System.Drawing.Size(72, 26);
            this.btnMultiRandomizer.TabIndex = 19;
            this.btnMultiRandomizer.Text = "Blast!";
            this.toolTip.SetToolTip(this.btnMultiRandomizer, "Open the Multiple-Randomizer");
            this.btnMultiRandomizer.UseVisualStyleBackColor = false;
            this.btnMultiRandomizer.Click += new System.EventHandler(this.MultiRandomizer_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Black;
            this.tblLPRightSideControlContainerInnerUpper.SetColumnSpan(this.lblUsername, 3);
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsername.Location = new System.Drawing.Point(2, 2);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 16);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "WELCOME, !";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnViewFavorites
            // 
            this.btnViewFavorites.BackColor = System.Drawing.Color.Brown;
            this.btnViewFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewFavorites.FlatAppearance.BorderSize = 0;
            this.btnViewFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFavorites.Font = new System.Drawing.Font("Magneto", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnViewFavorites.Location = new System.Drawing.Point(25, 152);
            this.btnViewFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewFavorites.Name = "btnViewFavorites";
            this.btnViewFavorites.Size = new System.Drawing.Size(72, 26);
            this.btnViewFavorites.TabIndex = 6;
            this.btnViewFavorites.Text = "Favorites";
            this.toolTip.SetToolTip(this.btnViewFavorites, "View your favorited media");
            this.btnViewFavorites.UseVisualStyleBackColor = false;
            this.btnViewFavorites.Click += new System.EventHandler(this.ViewFavorites_Click);
            // 
            // chkSlideShow
            // 
            this.chkSlideShow.AutoSize = true;
            this.chkSlideShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tblLPRightSideControlContainerInnerUpper.SetColumnSpan(this.chkSlideShow, 3);
            this.chkSlideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSlideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSlideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSlideShow.ForeColor = System.Drawing.Color.Brown;
            this.chkSlideShow.Location = new System.Drawing.Point(2, 238);
            this.chkSlideShow.Margin = new System.Windows.Forms.Padding(2);
            this.chkSlideShow.Name = "chkSlideShow";
            this.chkSlideShow.Size = new System.Drawing.Size(116, 22);
            this.chkSlideShow.TabIndex = 9;
            this.chkSlideShow.Text = "Slideshow";
            this.chkSlideShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.chkSlideShow, "Start or stop a media slideshow");
            this.chkSlideShow.UseVisualStyleBackColor = false;
            this.chkSlideShow.CheckedChanged += new System.EventHandler(this.Slideshow_CheckedChanged);
            // 
            // tblLPSlideShowSpeedContainer
            // 
            this.tblLPSlideShowSpeedContainer.ColumnCount = 3;
            this.tblLPRightSideControlContainerInnerUpper.SetColumnSpan(this.tblLPSlideShowSpeedContainer, 3);
            this.tblLPSlideShowSpeedContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPSlideShowSpeedContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPSlideShowSpeedContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLPSlideShowSpeedContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPSlideShowSpeedContainer.Controls.Add(this.btnSlideSpeedDown, 0, 0);
            this.tblLPSlideShowSpeedContainer.Controls.Add(this.lblCurrentSlideSpeed, 1, 0);
            this.tblLPSlideShowSpeedContainer.Controls.Add(this.btnSlideSpeedUp, 2, 0);
            this.tblLPSlideShowSpeedContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPSlideShowSpeedContainer.Location = new System.Drawing.Point(0, 262);
            this.tblLPSlideShowSpeedContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPSlideShowSpeedContainer.Name = "tblLPSlideShowSpeedContainer";
            this.tblLPSlideShowSpeedContainer.RowCount = 1;
            this.tblLPSlideShowSpeedContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPSlideShowSpeedContainer.Size = new System.Drawing.Size(120, 35);
            this.tblLPSlideShowSpeedContainer.TabIndex = 13;
            // 
            // btnSlideSpeedDown
            // 
            this.btnSlideSpeedDown.BackColor = System.Drawing.Color.Brown;
            this.btnSlideSpeedDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSlideSpeedDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideSpeedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlideSpeedDown.Location = new System.Drawing.Point(2, 2);
            this.btnSlideSpeedDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlideSpeedDown.Name = "btnSlideSpeedDown";
            this.btnSlideSpeedDown.Size = new System.Drawing.Size(36, 31);
            this.btnSlideSpeedDown.TabIndex = 10;
            this.btnSlideSpeedDown.Text = "-";
            this.toolTip.SetToolTip(this.btnSlideSpeedDown, "Decrease slide speed");
            this.btnSlideSpeedDown.UseVisualStyleBackColor = false;
            this.btnSlideSpeedDown.Visible = false;
            this.btnSlideSpeedDown.Click += new System.EventHandler(this.SlideSpeedDown_Click);
            // 
            // lblCurrentSlideSpeed
            // 
            this.lblCurrentSlideSpeed.AutoSize = true;
            this.lblCurrentSlideSpeed.BackColor = System.Drawing.Color.Black;
            this.lblCurrentSlideSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentSlideSpeed.Font = new System.Drawing.Font("Magneto", 7F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSlideSpeed.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentSlideSpeed.Location = new System.Drawing.Point(40, 0);
            this.lblCurrentSlideSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentSlideSpeed.Name = "lblCurrentSlideSpeed";
            this.lblCurrentSlideSpeed.Size = new System.Drawing.Size(40, 35);
            this.lblCurrentSlideSpeed.TabIndex = 12;
            this.lblCurrentSlideSpeed.Text = "6";
            this.lblCurrentSlideSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblCurrentSlideSpeed, "Current slide speed");
            this.lblCurrentSlideSpeed.Visible = false;
            // 
            // btnSlideSpeedUp
            // 
            this.btnSlideSpeedUp.BackColor = System.Drawing.Color.Brown;
            this.btnSlideSpeedUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSlideSpeedUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlideSpeedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlideSpeedUp.Location = new System.Drawing.Point(82, 2);
            this.btnSlideSpeedUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlideSpeedUp.Name = "btnSlideSpeedUp";
            this.btnSlideSpeedUp.Size = new System.Drawing.Size(36, 31);
            this.btnSlideSpeedUp.TabIndex = 11;
            this.btnSlideSpeedUp.Text = "+";
            this.toolTip.SetToolTip(this.btnSlideSpeedUp, "Increase slide speed");
            this.btnSlideSpeedUp.UseVisualStyleBackColor = false;
            this.btnSlideSpeedUp.Visible = false;
            this.btnSlideSpeedUp.Click += new System.EventHandler(this.SlideSpeedUp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Magneto", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.Brown;
            this.btnSettings.Location = new System.Drawing.Point(25, 182);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 26);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "Settings";
            this.toolTip.SetToolTip(this.btnSettings, "Open the settings window");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // picBxUserAvatar
            // 
            this.tblLPRightSideControlContainerInnerUpper.SetColumnSpan(this.picBxUserAvatar, 3);
            this.picBxUserAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxUserAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxUserAvatar.ErrorImage")));
            this.picBxUserAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxUserAvatar.InitialImage")));
            this.picBxUserAvatar.Location = new System.Drawing.Point(0, 20);
            this.picBxUserAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.picBxUserAvatar.Name = "picBxUserAvatar";
            this.picBxUserAvatar.Size = new System.Drawing.Size(120, 100);
            this.picBxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUserAvatar.TabIndex = 18;
            this.picBxUserAvatar.TabStop = false;
            this.picBxUserAvatar.Click += new System.EventHandler(this.UserAvatar_Click);
            // 
            // tblLPBottomControlStripLower
            // 
            this.tblLPBottomControlStripLower.ColumnCount = 5;
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblLPBottomControlStripLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPBottomControlStripLower.Controls.Add(this.btnSetPathToFolderOfCurrentMedia, 0, 0);
            this.tblLPBottomControlStripLower.Controls.Add(this.btnResetPathToDefault, 0, 0);
            this.tblLPBottomControlStripLower.Controls.Add(this.btnGoBack, 0, 0);
            this.tblLPBottomControlStripLower.Controls.Add(this.btnGoForward, 4, 0);
            this.tblLPBottomControlStripLower.Controls.Add(this.btnSetPathToParentOfCurrentMedia, 1, 0);
            this.tblLPBottomControlStripLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPBottomControlStripLower.Location = new System.Drawing.Point(2, 691);
            this.tblLPBottomControlStripLower.Margin = new System.Windows.Forms.Padding(2);
            this.tblLPBottomControlStripLower.Name = "tblLPBottomControlStripLower";
            this.tblLPBottomControlStripLower.RowCount = 1;
            this.tblLPBottomControlStripLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPBottomControlStripLower.Size = new System.Drawing.Size(1152, 24);
            this.tblLPBottomControlStripLower.TabIndex = 1;
            // 
            // btnSetPathToFolderOfCurrentMedia
            // 
            this.btnSetPathToFolderOfCurrentMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetPathToFolderOfCurrentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPathToFolderOfCurrentMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPathToFolderOfCurrentMedia.ForeColor = System.Drawing.Color.Brown;
            this.btnSetPathToFolderOfCurrentMedia.Location = new System.Drawing.Point(554, 2);
            this.btnSetPathToFolderOfCurrentMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetPathToFolderOfCurrentMedia.Name = "btnSetPathToFolderOfCurrentMedia";
            this.btnSetPathToFolderOfCurrentMedia.Size = new System.Drawing.Size(42, 20);
            this.btnSetPathToFolderOfCurrentMedia.TabIndex = 4;
            this.btnSetPathToFolderOfCurrentMedia.Text = "@";
            this.toolTip.SetToolTip(this.btnSetPathToFolderOfCurrentMedia, "Set randomizer path to the folder of current media");
            this.btnSetPathToFolderOfCurrentMedia.UseVisualStyleBackColor = true;
            this.btnSetPathToFolderOfCurrentMedia.Click += new System.EventHandler(this.SetPathToFolderOfCurrentMedia_Click);
            // 
            // btnResetPathToDefault
            // 
            this.btnResetPathToDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetPathToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPathToDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPathToDefault.ForeColor = System.Drawing.Color.Brown;
            this.btnResetPathToDefault.Location = new System.Drawing.Point(520, 2);
            this.btnResetPathToDefault.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPathToDefault.Name = "btnResetPathToDefault";
            this.btnResetPathToDefault.Size = new System.Drawing.Size(30, 20);
            this.btnResetPathToDefault.TabIndex = 3;
            this.btnResetPathToDefault.Text = "X";
            this.toolTip.SetToolTip(this.btnResetPathToDefault, "Reset the randomizer path to the default");
            this.btnResetPathToDefault.UseVisualStyleBackColor = true;
            this.btnResetPathToDefault.Click += new System.EventHandler(this.ResetPathToDefault_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Brown;
            this.btnGoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Magneto", 8F, System.Drawing.FontStyle.Bold);
            this.btnGoBack.Location = new System.Drawing.Point(2, 2);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(514, 20);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "< < <";
            this.toolTip.SetToolTip(this.btnGoBack, "Go back");
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnGoForward
            // 
            this.btnGoForward.BackColor = System.Drawing.Color.Brown;
            this.btnGoForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoForward.FlatAppearance.BorderSize = 0;
            this.btnGoForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoForward.Font = new System.Drawing.Font("Magneto", 8F, System.Drawing.FontStyle.Bold);
            this.btnGoForward.Location = new System.Drawing.Point(634, 2);
            this.btnGoForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(516, 20);
            this.btnGoForward.TabIndex = 1;
            this.btnGoForward.Text = "> > >";
            this.toolTip.SetToolTip(this.btnGoForward, "Go forward one item");
            this.btnGoForward.UseVisualStyleBackColor = false;
            this.btnGoForward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // btnSetPathToParentOfCurrentMedia
            // 
            this.btnSetPathToParentOfCurrentMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetPathToParentOfCurrentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPathToParentOfCurrentMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPathToParentOfCurrentMedia.ForeColor = System.Drawing.Color.Brown;
            this.btnSetPathToParentOfCurrentMedia.Location = new System.Drawing.Point(600, 2);
            this.btnSetPathToParentOfCurrentMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetPathToParentOfCurrentMedia.Name = "btnSetPathToParentOfCurrentMedia";
            this.btnSetPathToParentOfCurrentMedia.Size = new System.Drawing.Size(30, 20);
            this.btnSetPathToParentOfCurrentMedia.TabIndex = 2;
            this.btnSetPathToParentOfCurrentMedia.Text = "↑";
            this.btnSetPathToParentOfCurrentMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnSetPathToParentOfCurrentMedia, "Set the randomizer to the parent folder of the current working directory");
            this.btnSetPathToParentOfCurrentMedia.UseVisualStyleBackColor = true;
            this.btnSetPathToParentOfCurrentMedia.Click += new System.EventHandler(this.SetPathToParentFolderOfCurrentPath_Click);
            // 
            // tblLPBottomControlStripUpper
            // 
            this.tblLPBottomControlStripUpper.ColumnCount = 5;
            this.tblLPBottomControlStripUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.090044F));
            this.tblLPBottomControlStripUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.090161F));
            this.tblLPBottomControlStripUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.64043F));
            this.tblLPBottomControlStripUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.090098F));
            this.tblLPBottomControlStripUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.089263F));
            this.tblLPBottomControlStripUpper.Controls.Add(this.btnShowCollapseSideBar, 4, 0);
            this.tblLPBottomControlStripUpper.Controls.Add(this.btnMaximize, 0, 0);
            this.tblLPBottomControlStripUpper.Controls.Add(this.btnRandomize, 3, 0);
            this.tblLPBottomControlStripUpper.Controls.Add(this.lblCurrentMediaPath, 2, 0);
            this.tblLPBottomControlStripUpper.Controls.Add(this.btnAddNewFavorite, 1, 0);
            this.tblLPBottomControlStripUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPBottomControlStripUpper.Location = new System.Drawing.Point(2, 661);
            this.tblLPBottomControlStripUpper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tblLPBottomControlStripUpper.Name = "tblLPBottomControlStripUpper";
            this.tblLPBottomControlStripUpper.RowCount = 1;
            this.tblLPBottomControlStripUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPBottomControlStripUpper.Size = new System.Drawing.Size(1152, 28);
            this.tblLPBottomControlStripUpper.TabIndex = 3;
            // 
            // btnShowCollapseSideBar
            // 
            this.btnShowCollapseSideBar.BackColor = System.Drawing.Color.Black;
            this.btnShowCollapseSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowCollapseSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCollapseSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCollapseSideBar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnShowCollapseSideBar.Location = new System.Drawing.Point(1070, 2);
            this.btnShowCollapseSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCollapseSideBar.Name = "btnShowCollapseSideBar";
            this.btnShowCollapseSideBar.Size = new System.Drawing.Size(80, 24);
            this.btnShowCollapseSideBar.TabIndex = 18;
            this.btnShowCollapseSideBar.Text = "→";
            this.toolTip.SetToolTip(this.btnShowCollapseSideBar, "Hides or shows the right hand control bar");
            this.btnShowCollapseSideBar.UseVisualStyleBackColor = false;
            this.btnShowCollapseSideBar.Click += new System.EventHandler(this.ShowCollapseSideBar_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.IndianRed;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Magneto", 8F, System.Drawing.FontStyle.Bold);
            this.btnMaximize.Location = new System.Drawing.Point(2, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(77, 24);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.Text = "Maximize";
            this.toolTip.SetToolTip(this.btnMaximize, "Display the media in fullscreen; press ESC to close");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRandomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandomize.FlatAppearance.BorderSize = 0;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Font = new System.Drawing.Font("Magneto", 8F, System.Drawing.FontStyle.Bold);
            this.btnRandomize.Location = new System.Drawing.Point(988, 2);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(79, 24);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize";
            this.toolTip.SetToolTip(this.btnRandomize, "Display a new random media item");
            this.btnRandomize.UseVisualStyleBackColor = false;
            this.btnRandomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // lblCurrentMediaPath
            // 
            this.lblCurrentMediaPath.AutoSize = true;
            this.lblCurrentMediaPath.BackColor = System.Drawing.Color.Black;
            this.lblCurrentMediaPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentMediaPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentMediaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMediaPath.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentMediaPath.Location = new System.Drawing.Point(164, 2);
            this.lblCurrentMediaPath.Margin = new System.Windows.Forms.Padding(2);
            this.lblCurrentMediaPath.Name = "lblCurrentMediaPath";
            this.lblCurrentMediaPath.Size = new System.Drawing.Size(821, 24);
            this.lblCurrentMediaPath.TabIndex = 3;
            this.lblCurrentMediaPath.Text = " ";
            this.lblCurrentMediaPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblCurrentMediaPath, "Full path of the current media (click to load a specific item)\r\n");
            this.lblCurrentMediaPath.Click += new System.EventHandler(this.CurrentMediaPath_Click);
            // 
            // btnAddNewFavorite
            // 
            this.btnAddNewFavorite.BackColor = System.Drawing.Color.Black;
            this.btnAddNewFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewFavorite.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAddNewFavorite.Location = new System.Drawing.Point(83, 2);
            this.btnAddNewFavorite.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewFavorite.Name = "btnAddNewFavorite";
            this.btnAddNewFavorite.Size = new System.Drawing.Size(77, 24);
            this.btnAddNewFavorite.TabIndex = 17;
            this.btnAddNewFavorite.Text = "❤";
            this.toolTip.SetToolTip(this.btnAddNewFavorite, "Creates a new favorite of the media path being displayed");
            this.btnAddNewFavorite.UseVisualStyleBackColor = false;
            this.btnAddNewFavorite.Click += new System.EventHandler(this.AddNewFavorite_Click);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Controls.Add(this.picBxCandyGallery);
            this.panelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPictureBox.Location = new System.Drawing.Point(2, 2);
            this.panelPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(1152, 657);
            this.panelPictureBox.TabIndex = 4;
            // 
            // picBxCandyGallery
            // 
            this.picBxCandyGallery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxCandyGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.picBxCandyGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBxCandyGallery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxCandyGallery.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxCandyGallery.ErrorImage")));
            this.picBxCandyGallery.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxCandyGallery.InitialImage")));
            this.picBxCandyGallery.Location = new System.Drawing.Point(0, 0);
            this.picBxCandyGallery.Margin = new System.Windows.Forms.Padding(0);
            this.picBxCandyGallery.Name = "picBxCandyGallery";
            this.picBxCandyGallery.Size = new System.Drawing.Size(1156, 659);
            this.picBxCandyGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxCandyGallery.TabIndex = 0;
            this.picBxCandyGallery.TabStop = false;
            this.picBxCandyGallery.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBox_LoadCompleted);
            // 
            // btnExitGallery
            // 
            this.btnExitGallery.BackColor = System.Drawing.Color.Maroon;
            this.btnExitGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitGallery.FlatAppearance.BorderSize = 0;
            this.btnExitGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGallery.Location = new System.Drawing.Point(1248, 1);
            this.btnExitGallery.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitGallery.Name = "btnExitGallery";
            this.btnExitGallery.Size = new System.Drawing.Size(33, 18);
            this.btnExitGallery.TabIndex = 7;
            this.btnExitGallery.Text = "X";
            this.toolTip.SetToolTip(this.btnExitGallery, "Close Candy Gallery");
            this.btnExitGallery.UseVisualStyleBackColor = false;
            this.btnExitGallery.Click += new System.EventHandler(this.ExitGallery_Click);
            // 
            // btnMaximizeGallery
            // 
            this.btnMaximizeGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnMaximizeGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizeGallery.FlatAppearance.BorderSize = 0;
            this.btnMaximizeGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizeGallery.Location = new System.Drawing.Point(1217, 1);
            this.btnMaximizeGallery.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizeGallery.Name = "btnMaximizeGallery";
            this.btnMaximizeGallery.Size = new System.Drawing.Size(30, 18);
            this.btnMaximizeGallery.TabIndex = 8;
            this.btnMaximizeGallery.Text = "☐";
            this.toolTip.SetToolTip(this.btnMaximizeGallery, "Maximize Candy Gallery");
            this.btnMaximizeGallery.UseVisualStyleBackColor = false;
            this.btnMaximizeGallery.Click += new System.EventHandler(this.MaximizeGallery_Click);
            // 
            // btnMinimizeGallery
            // 
            this.btnMinimizeGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnMinimizeGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimizeGallery.FlatAppearance.BorderSize = 0;
            this.btnMinimizeGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeGallery.Location = new System.Drawing.Point(1186, 1);
            this.btnMinimizeGallery.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizeGallery.Name = "btnMinimizeGallery";
            this.btnMinimizeGallery.Size = new System.Drawing.Size(30, 18);
            this.btnMinimizeGallery.TabIndex = 9;
            this.btnMinimizeGallery.Text = "—";
            this.toolTip.SetToolTip(this.btnMinimizeGallery, "Minimize Candy Gallery");
            this.btnMinimizeGallery.UseVisualStyleBackColor = false;
            this.btnMinimizeGallery.Click += new System.EventHandler(this.MinimizeGallery_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // toolStripContextMenuPicturebox
            // 
            this.toolStripContextMenuPicturebox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripContextMenuPicturebox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripContextMenuPicturebox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenMediaLocation,
            this.setAsUserAvatarToolStripMenuItem});
            this.toolStripContextMenuPicturebox.Name = "contextMenuStripViewer";
            this.toolStripContextMenuPicturebox.Size = new System.Drawing.Size(186, 48);
            // 
            // toolStripMenuItemOpenMediaLocation
            // 
            this.toolStripMenuItemOpenMediaLocation.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemOpenMediaLocation.Name = "toolStripMenuItemOpenMediaLocation";
            this.toolStripMenuItemOpenMediaLocation.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemOpenMediaLocation.Text = "Open item location...";
            this.toolStripMenuItemOpenMediaLocation.Click += new System.EventHandler(this.OpenItemLocationToolStripMenuItem_Click);
            // 
            // setAsUserAvatarToolStripMenuItem
            // 
            this.setAsUserAvatarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.setAsUserAvatarToolStripMenuItem.Name = "setAsUserAvatarToolStripMenuItem";
            this.setAsUserAvatarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.setAsUserAvatarToolStripMenuItem.Text = "Set as User Avatar...";
            this.setAsUserAvatarToolStripMenuItem.Click += new System.EventHandler(this.SetAsUserAvatarToolStripMenuItem_Click);
            // 
            // tblLPFormBorder
            // 
            this.tblLPFormBorder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormBorder.ColumnCount = 1;
            this.tblLPFormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormBorder.Controls.Add(this.tblLPMainForm, 0, 1);
            this.tblLPFormBorder.Controls.Add(this.tblLPFormTopControls, 0, 0);
            this.tblLPFormBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPFormBorder.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormBorder.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormBorder.Name = "tblLPFormBorder";
            this.tblLPFormBorder.RowCount = 2;
            this.tblLPFormBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormBorder.Size = new System.Drawing.Size(1284, 740);
            this.tblLPFormBorder.TabIndex = 2;
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 4;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLPFormTopControls.Controls.Add(this.btnMinimizeGallery, 1, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnMaximizeGallery, 2, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExitGallery, 3, 0);
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPFormTopControls.Location = new System.Drawing.Point(1, 1);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(1282, 20);
            this.tblLPFormTopControls.TabIndex = 2;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyGalleryWindow_MouseDown);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandyTitle, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(1184, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyGalleryWindow_MouseDown);
            // 
            // lblCandyTitle
            // 
            this.lblCandyTitle.AutoSize = true;
            this.lblCandyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCandyTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandyTitle.Font = new System.Drawing.Font("Magneto", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCandyTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblCandyTitle.Location = new System.Drawing.Point(99, 0);
            this.lblCandyTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandyTitle.Name = "lblCandyTitle";
            this.lblCandyTitle.Size = new System.Drawing.Size(1085, 18);
            this.lblCandyTitle.TabIndex = 10;
            this.lblCandyTitle.Text = "Candy Gallery";
            this.lblCandyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandyTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyGalleryWindow_MouseDown);
            // 
            // imageListAvatars
            // 
            this.imageListAvatars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAvatars.ImageStream")));
            this.imageListAvatars.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAvatars.Images.SetKeyName(0, "Default.png");
            this.imageListAvatars.Images.SetKeyName(1, "Default2.png");
            this.imageListAvatars.Images.SetKeyName(2, "Default3.png");
            this.imageListAvatars.Images.SetKeyName(3, "Default4.png");
            this.imageListAvatars.Images.SetKeyName(4, "Default5.png");
            this.imageListAvatars.Images.SetKeyName(5, "Gummy-Bear-Blue.png");
            this.imageListAvatars.Images.SetKeyName(6, "Gummy-Bear-Green.png");
            this.imageListAvatars.Images.SetKeyName(7, "Gummy-Bear-Orange.png");
            this.imageListAvatars.Images.SetKeyName(8, "Gummy-Bear-Red.png");
            this.imageListAvatars.Images.SetKeyName(9, "Gummy-Bear-White.png");
            this.imageListAvatars.Images.SetKeyName(10, "Gummy-Bear-Yellow.png");
            this.imageListAvatars.Images.SetKeyName(11, "Gummy-Star-Blue.png");
            this.imageListAvatars.Images.SetKeyName(12, "Gummy-Star-Green.png");
            this.imageListAvatars.Images.SetKeyName(13, "Gummy-Star-Purple.png");
            this.imageListAvatars.Images.SetKeyName(14, "Gummy-Star-Red.png");
            this.imageListAvatars.Images.SetKeyName(15, "Lollipop-Blue-Plain.png");
            this.imageListAvatars.Images.SetKeyName(16, "Lollipop-Blue-YellowSpiral.png");
            this.imageListAvatars.Images.SetKeyName(17, "Lollipop-Colorful.png");
            this.imageListAvatars.Images.SetKeyName(18, "Lollipop-Curvy.png");
            this.imageListAvatars.Images.SetKeyName(19, "Lollipop-Green-Plain.png");
            this.imageListAvatars.Images.SetKeyName(20, "Lollipop-Heart-Bubbles.png");
            this.imageListAvatars.Images.SetKeyName(21, "Lollipop-Heart-Plain.png");
            this.imageListAvatars.Images.SetKeyName(22, "Lollipop-Heart-Stripes.png");
            this.imageListAvatars.Images.SetKeyName(23, "Lollipop-Peppermint-Checker.png");
            this.imageListAvatars.Images.SetKeyName(24, "Lollipop-Peppermint-Spiral.png");
            this.imageListAvatars.Images.SetKeyName(25, "Lollipop-Pink-Wrapped.png");
            this.imageListAvatars.Images.SetKeyName(26, "Lollipop-Purple-Glazed.png");
            this.imageListAvatars.Images.SetKeyName(27, "Lollipop-Red-OrangeSpiral.png");
            this.imageListAvatars.Images.SetKeyName(28, "Lollipop-Red-OrangeStripes.png");
            this.imageListAvatars.Images.SetKeyName(29, "Lollipop-Wrapped-Green-YellowStars.png");
            this.imageListAvatars.Images.SetKeyName(30, "Lollipop-Wrapped-Purple-WhiteSpiral.png");
            this.imageListAvatars.Images.SetKeyName(31, "Lollipop-Wrapped-Red-OrangeStripes.png");
            this.imageListAvatars.Images.SetKeyName(32, "Lollipop-Wrapped-Yellow-WhiteDots.png");
            this.imageListAvatars.Images.SetKeyName(33, "Lollipop-Yellow-Plain.png");
            this.imageListAvatars.Images.SetKeyName(34, "Lollipop-Yellow-Sprinkled.png");
            this.imageListAvatars.Images.SetKeyName(35, "Wrapped-Brick-Candy-Blue.png");
            this.imageListAvatars.Images.SetKeyName(36, "Wrapped-Brick-Candy-Blue-BlueStripes.png");
            this.imageListAvatars.Images.SetKeyName(37, "Wrapped-Brick-Candy-Green-YellowCircles.png");
            this.imageListAvatars.Images.SetKeyName(38, "Wrapped-Brick-Candy-Purple-PurpleStripes.png");
            this.imageListAvatars.Images.SetKeyName(39, "Wrapped-Brick-Candy-Red-WhiteDots.png");
            this.imageListAvatars.Images.SetKeyName(40, "Wrapped-Brick-Candy-Yellow-OrangeStripes.png");
            this.imageListAvatars.Images.SetKeyName(41, "Wrapped-Colorful-Candy.png");
            this.imageListAvatars.Images.SetKeyName(42, "Wrapped-Elegant-Candy-Blue.png");
            this.imageListAvatars.Images.SetKeyName(43, "Wrapped-Long-Candy-Pink-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(44, "Wrapped-Long-Candy-Purple-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(45, "Wrapped-Long-Candy-Yellow-OrangeStripes.png");
            this.imageListAvatars.Images.SetKeyName(46, "Wrapped-Oval-Candy-Black-YellowStars.png");
            this.imageListAvatars.Images.SetKeyName(47, "Wrapped-Oval-Candy-Blue-YellowDots.png");
            this.imageListAvatars.Images.SetKeyName(48, "Wrapped-Oval-Candy-Red-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(49, "Wrapped-Packet-Candy-Cream-RedSpiral.png");
            this.imageListAvatars.Images.SetKeyName(50, "Wrapped-Packet-Candy-Green-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(51, "Wrapped-Packet-Candy-Yellow.png");
            this.imageListAvatars.Images.SetKeyName(52, "Wrapped-Pouch-Candy-Brown-OrangeStripes.png");
            this.imageListAvatars.Images.SetKeyName(53, "Wrapped-Pouch-Candy-Green-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(54, "Wrapped-Sphere-Candy-Blue-YellowStars.png");
            this.imageListAvatars.Images.SetKeyName(55, "Wrapped-Sphere-Candy-Green-GreenDots.png");
            this.imageListAvatars.Images.SetKeyName(56, "Wrapped-Sphere-Candy-Green-YellowStripes.png");
            this.imageListAvatars.Images.SetKeyName(57, "Wrapped-Sphere-Candy-Pink-YellowStripes.png");
            // 
            // CandyGalleryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 740);
            this.Controls.Add(this.tblLPFormBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CandyGalleryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candy Gallery";
            this.tblLPMainForm.ResumeLayout(false);
            this.tblLPRightSideControlContainer.ResumeLayout(false);
            this.tblLPRightSideControlContainerInnerLower.ResumeLayout(false);
            this.tblLPRightSideControlContainerInnerLower.PerformLayout();
            this.tblLPFilterByContainer.ResumeLayout(false);
            this.tblLPFilterByContainer.PerformLayout();
            this.tblLPApplyFilterContainer.ResumeLayout(false);
            this.tblLPApplyFilterContainer.PerformLayout();
            this.tblLPRightSideControlContainerInnerUpper.ResumeLayout(false);
            this.tblLPRightSideControlContainerInnerUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.tblLPSlideShowSpeedContainer.ResumeLayout(false);
            this.tblLPSlideShowSpeedContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUserAvatar)).EndInit();
            this.tblLPBottomControlStripLower.ResumeLayout(false);
            this.tblLPBottomControlStripUpper.ResumeLayout(false);
            this.tblLPBottomControlStripUpper.PerformLayout();
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxCandyGallery)).EndInit();
            this.toolStripContextMenuPicturebox.ResumeLayout(false);
            this.tblLPFormBorder.ResumeLayout(false);
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblLPMainForm;
        private System.Windows.Forms.TableLayoutPanel tblLPRightSideControlContainer;
        private System.Windows.Forms.TableLayoutPanel tblLPBottomControlStripLower;
        private System.Windows.Forms.Button btnSetPathToFolderOfCurrentMedia;
        private System.Windows.Forms.Button btnResetPathToDefault;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnGoForward;
        private System.Windows.Forms.Button btnSetPathToParentOfCurrentMedia;
        private System.Windows.Forms.Label lblCurrentMediaPath;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tblLPRightSideControlContainerInnerLower;
        private System.Windows.Forms.Label lblTypeSelectionSection;
        private System.Windows.Forms.Label lblOptionsSection;
        private System.Windows.Forms.CheckBox chkEnableShortcutType;
        private System.Windows.Forms.TableLayoutPanel tblLPFilterByContainer;
        private System.Windows.Forms.CheckBox chkFilterByNewest;
        private System.Windows.Forms.TextBox txtFilterResultsByCount;
        private System.Windows.Forms.TableLayoutPanel tblLPRightSideControlContainerInnerUpper;
        private System.Windows.Forms.Button btnViewFavorites;
        private System.Windows.Forms.CheckBox chkSlideShow;
        private System.Windows.Forms.Button btnSlideSpeedDown;
        private System.Windows.Forms.Button btnSlideSpeedUp;
        private System.Windows.Forms.Label lblCurrentSlideSpeed;
        private System.Windows.Forms.TableLayoutPanel tblLPSlideShowSpeedContainer;
        private System.Windows.Forms.TableLayoutPanel tblLPBottomControlStripUpper;
        private System.Windows.Forms.ContextMenuStrip toolStripContextMenuPicturebox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenMediaLocation;
        private System.Windows.Forms.CheckBox chkApplyImageFilter;
        private System.Windows.Forms.TableLayoutPanel tblLPApplyFilterContainer;
        private System.Windows.Forms.Button btnFilterStrengthDown;
        private System.Windows.Forms.Label lblCurrentFilterStrength;
        private System.Windows.Forms.Button btnFilterStrengthUp;
        public System.Windows.Forms.PictureBox picBxCandyGallery;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.CheckBox chkFilterByOldest;
        private System.Windows.Forms.CheckBox chkFilterByUnseen;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAddNewFavorite;
        public System.Windows.Forms.PictureBox picBxUserAvatar;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.TableLayoutPanel tblLPFormBorder;
        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.Button btnMinimizeGallery;
        private System.Windows.Forms.Button btnMaximizeGallery;
        private System.Windows.Forms.Button btnExitGallery;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.Label lblCandyTitle;
        private System.Windows.Forms.Button btnShowCollapseSideBar;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private Button btnVideosType;
        private Button btnGifType;
        private Button btnAllType;
        private Button btnFilterByCountDecrease;
        private Button btnFilterByCountIncrease;
        public ImageList imageListAvatars;
        private Button btnMultiRandomizer;
        private Button btnOtherType;
        private ToolStripMenuItem setAsUserAvatarToolStripMenuItem;
        public AxWMPLib.AxWindowsMediaPlayer videoPlayer;
    }
}

