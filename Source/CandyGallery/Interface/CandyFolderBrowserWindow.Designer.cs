using System.Windows.Forms;

namespace CandyGallery.Interface
{
    partial class CandyFolderBrowserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyFolderBrowserWindow));
            this.panelFormBorder = new System.Windows.Forms.Panel();
            this.tblLPFormContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximizeFolderBrowser = new System.Windows.Forms.Button();
            this.btnExitFolderBrowser = new System.Windows.Forms.Button();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandyFolderBrowserTitle = new System.Windows.Forms.Label();
            this.btnSetFavorite = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.listViewFolderBrowser = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToMainViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsUserAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormBorder.SuspendLayout();
            this.tblLPFormContainer.SuspendLayout();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormBorder
            // 
            this.panelFormBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormBorder.Controls.Add(this.tblLPFormContainer);
            this.panelFormBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBorder.Location = new System.Drawing.Point(0, 0);
            this.panelFormBorder.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormBorder.Name = "panelFormBorder";
            this.panelFormBorder.Size = new System.Drawing.Size(1284, 815);
            this.panelFormBorder.TabIndex = 5;
            // 
            // tblLPFormContainer
            // 
            this.tblLPFormContainer.ColumnCount = 5;
            this.tblLPFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPFormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
            this.tblLPFormContainer.Controls.Add(this.btnReset, 0, 2);
            this.tblLPFormContainer.Controls.Add(this.tblLPFormTopControls, 0, 0);
            this.tblLPFormContainer.Controls.Add(this.btnSetFavorite, 3, 2);
            this.tblLPFormContainer.Controls.Add(this.btnOpen, 4, 2);
            this.tblLPFormContainer.Controls.Add(this.btnGoBack, 1, 2);
            this.tblLPFormContainer.Controls.Add(this.listViewFolderBrowser, 0, 1);
            this.tblLPFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPFormContainer.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormContainer.Name = "tblLPFormContainer";
            this.tblLPFormContainer.RowCount = 3;
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormContainer.Size = new System.Drawing.Size(1282, 813);
            this.tblLPFormContainer.TabIndex = 74;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.Brown;
            this.btnReset.Location = new System.Drawing.Point(2, 787);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(252, 24);
            this.btnReset.TabIndex = 75;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 3;
            this.tblLPFormContainer.SetColumnSpan(this.tblLPFormTopControls, 5);
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLPFormTopControls.Controls.Add(this.btnMaximizeFolderBrowser, 0, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExitFolderBrowser, 2, 0);
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPFormTopControls.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(1282, 20);
            this.tblLPFormTopControls.TabIndex = 3;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyMultiRandomWindow_MouseDown);
            // 
            // btnMaximizeFolderBrowser
            // 
            this.btnMaximizeFolderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnMaximizeFolderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizeFolderBrowser.FlatAppearance.BorderSize = 0;
            this.btnMaximizeFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeFolderBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizeFolderBrowser.Location = new System.Drawing.Point(1202, 1);
            this.btnMaximizeFolderBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizeFolderBrowser.Name = "btnMaximizeFolderBrowser";
            this.btnMaximizeFolderBrowser.Size = new System.Drawing.Size(33, 18);
            this.btnMaximizeFolderBrowser.TabIndex = 11;
            this.btnMaximizeFolderBrowser.Text = "☐";
            this.btnMaximizeFolderBrowser.UseVisualStyleBackColor = false;
            this.btnMaximizeFolderBrowser.Click += new System.EventHandler(this.MaximizeMultiRandom_Click);
            // 
            // btnExitFolderBrowser
            // 
            this.btnExitFolderBrowser.BackColor = System.Drawing.Color.Maroon;
            this.btnExitFolderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitFolderBrowser.FlatAppearance.BorderSize = 0;
            this.btnExitFolderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFolderBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFolderBrowser.Location = new System.Drawing.Point(1236, 1);
            this.btnExitFolderBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitFolderBrowser.Name = "btnExitFolderBrowser";
            this.btnExitFolderBrowser.Size = new System.Drawing.Size(45, 18);
            this.btnExitFolderBrowser.TabIndex = 7;
            this.btnExitFolderBrowser.Text = "X";
            this.btnExitFolderBrowser.UseVisualStyleBackColor = false;
            this.btnExitFolderBrowser.Click += new System.EventHandler(this.ExitMultiRandom_Click);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandyFolderBrowserTitle, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(1200, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyMultiRandomWindow_MouseDown);
            // 
            // lblCandyFolderBrowserTitle
            // 
            this.lblCandyFolderBrowserTitle.AutoSize = true;
            this.lblCandyFolderBrowserTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCandyFolderBrowserTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandyFolderBrowserTitle.Font = new System.Drawing.Font("Magneto", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCandyFolderBrowserTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblCandyFolderBrowserTitle.Location = new System.Drawing.Point(66, 0);
            this.lblCandyFolderBrowserTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandyFolderBrowserTitle.Name = "lblCandyFolderBrowserTitle";
            this.lblCandyFolderBrowserTitle.Size = new System.Drawing.Size(1134, 18);
            this.lblCandyFolderBrowserTitle.TabIndex = 10;
            this.lblCandyFolderBrowserTitle.Text = "Candy Folder Browser";
            this.lblCandyFolderBrowserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandyFolderBrowserTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyMultiRandomWindow_MouseDown);
            // 
            // btnSetFavorite
            // 
            this.btnSetFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnSetFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetFavorite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSetFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFavorite.Font = new System.Drawing.Font("Magneto", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSetFavorite.ForeColor = System.Drawing.Color.Brown;
            this.btnSetFavorite.Location = new System.Drawing.Point(770, 787);
            this.btnSetFavorite.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetFavorite.Name = "btnSetFavorite";
            this.btnSetFavorite.Size = new System.Drawing.Size(252, 24);
            this.btnSetFavorite.TabIndex = 73;
            this.btnSetFavorite.Text = "Favorite";
            this.btnSetFavorite.UseVisualStyleBackColor = false;
            this.btnSetFavorite.Visible = false;
            this.btnSetFavorite.Click += new System.EventHandler(this.SetFavorite_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Brown;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Magneto", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(1026, 787);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(254, 24);
            this.btnOpen.TabIndex = 53;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGoBack.ForeColor = System.Drawing.Color.Brown;
            this.btnGoBack.Location = new System.Drawing.Point(258, 787);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(252, 24);
            this.btnGoBack.TabIndex = 72;
            this.btnGoBack.Text = "↑";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // listViewFolderBrowser
            // 
            this.listViewFolderBrowser.BackColor = System.Drawing.Color.Black;
            this.tblLPFormContainer.SetColumnSpan(this.listViewFolderBrowser, 5);
            this.listViewFolderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFolderBrowser.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewFolderBrowser.HideSelection = false;
            this.listViewFolderBrowser.Location = new System.Drawing.Point(3, 23);
            this.listViewFolderBrowser.Name = "listViewFolderBrowser";
            this.listViewFolderBrowser.Size = new System.Drawing.Size(1276, 759);
            this.listViewFolderBrowser.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewFolderBrowser.TabIndex = 74;
            this.listViewFolderBrowser.UseCompatibleStateImageBehavior = false;
            this.listViewFolderBrowser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewMouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToMainViewerToolStripMenuItem,
            this.setAsUserAvatarToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStripFave";
            this.contextMenuStrip.Size = new System.Drawing.Size(188, 48);
            // 
            // addToMainViewerToolStripMenuItem
            // 
            this.addToMainViewerToolStripMenuItem.Name = "addToMainViewerToolStripMenuItem";
            this.addToMainViewerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addToMainViewerToolStripMenuItem.Text = "Add to Main Viewer...";
            this.addToMainViewerToolStripMenuItem.Click += new System.EventHandler(this.AddToMainViewerToolStripMenuItem_Click);
            // 
            // setAsUserAvatarToolStripMenuItem
            // 
            this.setAsUserAvatarToolStripMenuItem.Name = "setAsUserAvatarToolStripMenuItem";
            this.setAsUserAvatarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.setAsUserAvatarToolStripMenuItem.Text = "Set as User Avatar...";
            this.setAsUserAvatarToolStripMenuItem.Click += new System.EventHandler(this.SetAsUserAvatarToolStripMenuItem_Click);
            // 
            // CandyFolderBrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 815);
            this.Controls.Add(this.panelFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandyFolderBrowserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Candy Multi-Random";
            this.panelFormBorder.ResumeLayout(false);
            this.tblLPFormContainer.ResumeLayout(false);
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormBorder;
        private ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToMainViewerToolStripMenuItem;
        private ToolStripMenuItem setAsUserAvatarToolStripMenuItem;
        private TableLayoutPanel tblLPFormContainer;
        private TableLayoutPanel tblLPFormTopControls;
        private Button btnMaximizeFolderBrowser;
        private Button btnExitFolderBrowser;
        private TableLayoutPanel tblLPTitleContainer;
        private Label lblCandyFolderBrowserTitle;
        private Button btnSetFavorite;
        public Button btnOpen;
        private Button btnGoBack;
        private ListView listViewFolderBrowser;
        private Button btnReset;
    }
}