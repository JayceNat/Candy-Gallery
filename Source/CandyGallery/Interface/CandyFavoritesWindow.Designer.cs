using System.Windows.Forms;

namespace CandyGallery.Interface
{
    partial class CandyFavoritesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyFavoritesWindow));
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnExitFavorites = new System.Windows.Forms.Button();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandyFavoritesTitle = new System.Windows.Forms.Label();
            this.panelFormBorder = new System.Windows.Forms.Panel();
            this.tblLPCurrentItemNameContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentMediaPath = new System.Windows.Forms.Label();
            this.btnViewFavorite = new System.Windows.Forms.Button();
            this.picBxFavoriteMain = new System.Windows.Forms.PictureBox();
            this.picBxFavoriteNext = new System.Windows.Forms.PictureBox();
            this.lblFilterFavoriteType = new System.Windows.Forms.Label();
            this.cmbBxFavoriteTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblJumpToFavorite = new System.Windows.Forms.Label();
            this.cmbBxFavoriteItemIndex = new System.Windows.Forms.ComboBox();
            this.btnDeleteFavorite = new System.Windows.Forms.Button();
            this.btnNextFavorite = new System.Windows.Forms.Button();
            this.btnLastFavorite = new System.Windows.Forms.Button();
            this.picBxFavoriteNextNext = new System.Windows.Forms.PictureBox();
            this.picBxFavoriteLast = new System.Windows.Forms.PictureBox();
            this.picBxFavoriteLastLast = new System.Windows.Forms.PictureBox();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.panelFormBorder.SuspendLayout();
            this.tblLPCurrentItemNameContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteNextNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteLastLast)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 2;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblLPFormTopControls.Controls.Add(this.btnExitFavorites, 1, 0);
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(1284, 20);
            this.tblLPFormTopControls.TabIndex = 3;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyFavoritesWindow_MouseDown);
            // 
            // btnExitFavorites
            // 
            this.btnExitFavorites.BackColor = System.Drawing.Color.Maroon;
            this.btnExitFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitFavorites.FlatAppearance.BorderSize = 0;
            this.btnExitFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFavorites.Location = new System.Drawing.Point(1237, 1);
            this.btnExitFavorites.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitFavorites.Name = "btnExitFavorites";
            this.btnExitFavorites.Size = new System.Drawing.Size(46, 18);
            this.btnExitFavorites.TabIndex = 7;
            this.btnExitFavorites.Text = "X";
            this.btnExitFavorites.UseVisualStyleBackColor = false;
            this.btnExitFavorites.Click += new System.EventHandler(this.ExitFavorites_Click);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandyFavoritesTitle, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(1235, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyFavoritesWindow_MouseDown);
            // 
            // lblCandyFavoritesTitle
            // 
            this.lblCandyFavoritesTitle.AutoSize = true;
            this.lblCandyFavoritesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCandyFavoritesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandyFavoritesTitle.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandyFavoritesTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblCandyFavoritesTitle.Location = new System.Drawing.Point(46, 0);
            this.lblCandyFavoritesTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandyFavoritesTitle.Name = "lblCandyFavoritesTitle";
            this.lblCandyFavoritesTitle.Size = new System.Drawing.Size(1189, 18);
            this.lblCandyFavoritesTitle.TabIndex = 10;
            this.lblCandyFavoritesTitle.Text = "Candy Favorites";
            this.lblCandyFavoritesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandyFavoritesTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyFavoritesWindow_MouseDown);
            // 
            // panelFormBorder
            // 
            this.panelFormBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormBorder.Controls.Add(this.tblLPCurrentItemNameContainer);
            this.panelFormBorder.Controls.Add(this.btnViewFavorite);
            this.panelFormBorder.Controls.Add(this.picBxFavoriteMain);
            this.panelFormBorder.Controls.Add(this.picBxFavoriteNext);
            this.panelFormBorder.Controls.Add(this.lblFilterFavoriteType);
            this.panelFormBorder.Controls.Add(this.cmbBxFavoriteTypeFilter);
            this.panelFormBorder.Controls.Add(this.lblJumpToFavorite);
            this.panelFormBorder.Controls.Add(this.cmbBxFavoriteItemIndex);
            this.panelFormBorder.Controls.Add(this.btnDeleteFavorite);
            this.panelFormBorder.Controls.Add(this.btnNextFavorite);
            this.panelFormBorder.Controls.Add(this.btnLastFavorite);
            this.panelFormBorder.Controls.Add(this.tblLPFormTopControls);
            this.panelFormBorder.Controls.Add(this.picBxFavoriteNextNext);
            this.panelFormBorder.Controls.Add(this.picBxFavoriteLast);
            this.panelFormBorder.Controls.Add(this.picBxFavoriteLastLast);
            this.panelFormBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBorder.Location = new System.Drawing.Point(0, 0);
            this.panelFormBorder.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormBorder.Name = "panelFormBorder";
            this.panelFormBorder.Size = new System.Drawing.Size(1284, 774);
            this.panelFormBorder.TabIndex = 4;
            // 
            // tblLPCurrentItemNameContainer
            // 
            this.tblLPCurrentItemNameContainer.BackColor = System.Drawing.Color.Transparent;
            this.tblLPCurrentItemNameContainer.ColumnCount = 1;
            this.tblLPCurrentItemNameContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPCurrentItemNameContainer.Controls.Add(this.lblCurrentMediaPath, 0, 0);
            this.tblLPCurrentItemNameContainer.Location = new System.Drawing.Point(309, 653);
            this.tblLPCurrentItemNameContainer.Margin = new System.Windows.Forms.Padding(2);
            this.tblLPCurrentItemNameContainer.Name = "tblLPCurrentItemNameContainer";
            this.tblLPCurrentItemNameContainer.RowCount = 1;
            this.tblLPCurrentItemNameContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPCurrentItemNameContainer.Size = new System.Drawing.Size(665, 28);
            this.tblLPCurrentItemNameContainer.TabIndex = 56;
            // 
            // lblCurrentMediaPath
            // 
            this.lblCurrentMediaPath.AutoSize = true;
            this.lblCurrentMediaPath.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentMediaPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentMediaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMediaPath.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCurrentMediaPath.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentMediaPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentMediaPath.Name = "lblCurrentMediaPath";
            this.lblCurrentMediaPath.Size = new System.Drawing.Size(665, 28);
            this.lblCurrentMediaPath.TabIndex = 44;
            this.lblCurrentMediaPath.Text = "C:\\";
            this.lblCurrentMediaPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewFavorite
            // 
            this.btnViewFavorite.BackColor = System.Drawing.Color.Brown;
            this.btnViewFavorite.FlatAppearance.BorderSize = 0;
            this.btnViewFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFavorite.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFavorite.ForeColor = System.Drawing.Color.Black;
            this.btnViewFavorite.Location = new System.Drawing.Point(1195, 732);
            this.btnViewFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewFavorite.Name = "btnViewFavorite";
            this.btnViewFavorite.Size = new System.Drawing.Size(79, 32);
            this.btnViewFavorite.TabIndex = 53;
            this.btnViewFavorite.Text = "Open";
            this.btnViewFavorite.UseVisualStyleBackColor = false;
            this.btnViewFavorite.Click += new System.EventHandler(this.ViewFavorite_Click);
            // 
            // picBxFavoriteMain
            // 
            this.picBxFavoriteMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.picBxFavoriteMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxFavoriteMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteMain.ErrorImage")));
            this.picBxFavoriteMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteMain.InitialImage")));
            this.picBxFavoriteMain.Location = new System.Drawing.Point(309, 46);
            this.picBxFavoriteMain.Margin = new System.Windows.Forms.Padding(2);
            this.picBxFavoriteMain.Name = "picBxFavoriteMain";
            this.picBxFavoriteMain.Size = new System.Drawing.Size(665, 582);
            this.picBxFavoriteMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxFavoriteMain.TabIndex = 4;
            this.picBxFavoriteMain.TabStop = false;
            this.picBxFavoriteMain.Click += new System.EventHandler(this.FavoriteMain_Click);
            // 
            // picBxFavoriteNext
            // 
            this.picBxFavoriteNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.picBxFavoriteNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteNext.ErrorImage")));
            this.picBxFavoriteNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteNext.InitialImage")));
            this.picBxFavoriteNext.Location = new System.Drawing.Point(848, 127);
            this.picBxFavoriteNext.Margin = new System.Windows.Forms.Padding(2);
            this.picBxFavoriteNext.Name = "picBxFavoriteNext";
            this.picBxFavoriteNext.Size = new System.Drawing.Size(375, 419);
            this.picBxFavoriteNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxFavoriteNext.TabIndex = 51;
            this.picBxFavoriteNext.TabStop = false;
            this.picBxFavoriteNext.Click += new System.EventHandler(this.FavoriteNext_Click);
            // 
            // lblFilterFavoriteType
            // 
            this.lblFilterFavoriteType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterFavoriteType.AutoSize = true;
            this.lblFilterFavoriteType.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterFavoriteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterFavoriteType.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFilterFavoriteType.Location = new System.Drawing.Point(40, 698);
            this.lblFilterFavoriteType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterFavoriteType.Name = "lblFilterFavoriteType";
            this.lblFilterFavoriteType.Size = new System.Drawing.Size(100, 13);
            this.lblFilterFavoriteType.TabIndex = 50;
            this.lblFilterFavoriteType.Text = "Filter Favorite Type:";
            this.lblFilterFavoriteType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFilterFavoriteType.Visible = false;
            // 
            // cmbBxFavoriteTypeFilter
            // 
            this.cmbBxFavoriteTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxFavoriteTypeFilter.BackColor = System.Drawing.Color.LightGray;
            this.cmbBxFavoriteTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxFavoriteTypeFilter.FormattingEnabled = true;
            this.cmbBxFavoriteTypeFilter.Items.AddRange(new object[] {
            "All"});
            this.cmbBxFavoriteTypeFilter.Location = new System.Drawing.Point(145, 696);
            this.cmbBxFavoriteTypeFilter.Name = "cmbBxFavoriteTypeFilter";
            this.cmbBxFavoriteTypeFilter.Size = new System.Drawing.Size(96, 21);
            this.cmbBxFavoriteTypeFilter.TabIndex = 49;
            this.cmbBxFavoriteTypeFilter.Visible = false;
            this.cmbBxFavoriteTypeFilter.SelectedIndexChanged += new System.EventHandler(this.FavoriteTypeFilter_SelectedIndexChanged);
            // 
            // lblJumpToFavorite
            // 
            this.lblJumpToFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJumpToFavorite.AutoSize = true;
            this.lblJumpToFavorite.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpToFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumpToFavorite.ForeColor = System.Drawing.Color.IndianRed;
            this.lblJumpToFavorite.Location = new System.Drawing.Point(52, 672);
            this.lblJumpToFavorite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumpToFavorite.Name = "lblJumpToFavorite";
            this.lblJumpToFavorite.Size = new System.Drawing.Size(88, 13);
            this.lblJumpToFavorite.TabIndex = 48;
            this.lblJumpToFavorite.Text = "Jump to Favorite:";
            this.lblJumpToFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBxFavoriteItemIndex
            // 
            this.cmbBxFavoriteItemIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxFavoriteItemIndex.BackColor = System.Drawing.Color.LightGray;
            this.cmbBxFavoriteItemIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxFavoriteItemIndex.FormattingEnabled = true;
            this.cmbBxFavoriteItemIndex.Location = new System.Drawing.Point(145, 670);
            this.cmbBxFavoriteItemIndex.Name = "cmbBxFavoriteItemIndex";
            this.cmbBxFavoriteItemIndex.Size = new System.Drawing.Size(96, 21);
            this.cmbBxFavoriteItemIndex.TabIndex = 47;
            this.cmbBxFavoriteItemIndex.SelectedIndexChanged += new System.EventHandler(this.FavoriteItemIndex_SelectedIndexChanged);
            // 
            // btnDeleteFavorite
            // 
            this.btnDeleteFavorite.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteFavorite.FlatAppearance.BorderSize = 0;
            this.btnDeleteFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFavorite.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFavorite.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteFavorite.Location = new System.Drawing.Point(1108, 732);
            this.btnDeleteFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteFavorite.Name = "btnDeleteFavorite";
            this.btnDeleteFavorite.Size = new System.Drawing.Size(79, 32);
            this.btnDeleteFavorite.TabIndex = 46;
            this.btnDeleteFavorite.Text = "Delete";
            this.btnDeleteFavorite.UseVisualStyleBackColor = false;
            this.btnDeleteFavorite.Click += new System.EventHandler(this.DeleteFavorite_Click);
            // 
            // btnNextFavorite
            // 
            this.btnNextFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnNextFavorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNextFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFavorite.ForeColor = System.Drawing.Color.Brown;
            this.btnNextFavorite.Location = new System.Drawing.Point(642, 684);
            this.btnNextFavorite.Margin = new System.Windows.Forms.Padding(1);
            this.btnNextFavorite.Name = "btnNextFavorite";
            this.btnNextFavorite.Size = new System.Drawing.Size(332, 23);
            this.btnNextFavorite.TabIndex = 43;
            this.btnNextFavorite.Text = "→";
            this.btnNextFavorite.UseVisualStyleBackColor = false;
            this.btnNextFavorite.Click += new System.EventHandler(this.NextFavorite_Click);
            // 
            // btnLastFavorite
            // 
            this.btnLastFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnLastFavorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLastFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastFavorite.ForeColor = System.Drawing.Color.Brown;
            this.btnLastFavorite.Location = new System.Drawing.Point(309, 684);
            this.btnLastFavorite.Margin = new System.Windows.Forms.Padding(1);
            this.btnLastFavorite.Name = "btnLastFavorite";
            this.btnLastFavorite.Size = new System.Drawing.Size(332, 23);
            this.btnLastFavorite.TabIndex = 42;
            this.btnLastFavorite.Text = "←";
            this.btnLastFavorite.UseVisualStyleBackColor = false;
            this.btnLastFavorite.Click += new System.EventHandler(this.LastFavorite_Click);
            // 
            // picBxFavoriteNextNext
            // 
            this.picBxFavoriteNextNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.picBxFavoriteNextNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteNextNext.ErrorImage")));
            this.picBxFavoriteNextNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteNextNext.InitialImage")));
            this.picBxFavoriteNextNext.Location = new System.Drawing.Point(1119, 208);
            this.picBxFavoriteNextNext.Margin = new System.Windows.Forms.Padding(2);
            this.picBxFavoriteNextNext.Name = "picBxFavoriteNextNext";
            this.picBxFavoriteNextNext.Size = new System.Drawing.Size(225, 257);
            this.picBxFavoriteNextNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxFavoriteNextNext.TabIndex = 52;
            this.picBxFavoriteNextNext.TabStop = false;
            this.picBxFavoriteNextNext.Click += new System.EventHandler(this.FavoriteNextNext_Click);
            // 
            // picBxFavoriteLast
            // 
            this.picBxFavoriteLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.picBxFavoriteLast.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteLast.ErrorImage")));
            this.picBxFavoriteLast.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteLast.InitialImage")));
            this.picBxFavoriteLast.Location = new System.Drawing.Point(60, 127);
            this.picBxFavoriteLast.Margin = new System.Windows.Forms.Padding(2);
            this.picBxFavoriteLast.Name = "picBxFavoriteLast";
            this.picBxFavoriteLast.Size = new System.Drawing.Size(375, 419);
            this.picBxFavoriteLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxFavoriteLast.TabIndex = 54;
            this.picBxFavoriteLast.TabStop = false;
            this.picBxFavoriteLast.Click += new System.EventHandler(this.FavoriteLast_Click);
            // 
            // picBxFavoriteLastLast
            // 
            this.picBxFavoriteLastLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.picBxFavoriteLastLast.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteLastLast.ErrorImage")));
            this.picBxFavoriteLastLast.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBxFavoriteLastLast.InitialImage")));
            this.picBxFavoriteLastLast.Location = new System.Drawing.Point(-60, 208);
            this.picBxFavoriteLastLast.Margin = new System.Windows.Forms.Padding(2);
            this.picBxFavoriteLastLast.Name = "picBxFavoriteLastLast";
            this.picBxFavoriteLastLast.Size = new System.Drawing.Size(225, 257);
            this.picBxFavoriteLastLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxFavoriteLastLast.TabIndex = 55;
            this.picBxFavoriteLastLast.TabStop = false;
            this.picBxFavoriteLastLast.Click += new System.EventHandler(this.FavoriteLastLast_Click);
            // 
            // CandyFavoritesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 774);
            this.Controls.Add(this.panelFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandyFavoritesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyFavoritesWindow";
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.panelFormBorder.ResumeLayout(false);
            this.panelFormBorder.PerformLayout();
            this.tblLPCurrentItemNameContainer.ResumeLayout(false);
            this.tblLPCurrentItemNameContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteNextNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFavoriteLastLast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.Button btnExitFavorites;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.Label lblCandyFavoritesTitle;
        private System.Windows.Forms.Panel panelFormBorder;
        private PictureBox picBxFavoriteMain;
        private Button btnNextFavorite;
        private Button btnLastFavorite;
        private Button btnDeleteFavorite;
        private Label lblCurrentMediaPath;
        private Label lblFilterFavoriteType;
        private ComboBox cmbBxFavoriteTypeFilter;
        private Label lblJumpToFavorite;
        private ComboBox cmbBxFavoriteItemIndex;
        private Button btnViewFavorite;
        private PictureBox picBxFavoriteNext;
        private PictureBox picBxFavoriteNextNext;
        private PictureBox picBxFavoriteLast;
        private PictureBox picBxFavoriteLastLast;
        private TableLayoutPanel tblLPCurrentItemNameContainer;
    }
}