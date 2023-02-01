namespace CandyGallery.Interface
{
    partial class CandySettingsFileViewerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandySettingsFileViewerWindow));
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandySettingsFileViewer = new System.Windows.Forms.Label();
            this.btnExitSettingsViewer = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tblLPBottomControlsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopySettingsText = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.tblLPBottomControlsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 2;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExitSettingsViewer, 1, 0);
            this.tblLPFormTopControls.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(525, 20);
            this.tblLPFormTopControls.TabIndex = 35;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsViewerWindow_MouseDown);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandySettingsFileViewer, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(479, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsViewerWindow_MouseDown);
            // 
            // lblCandySettingsFileViewer
            // 
            this.lblCandySettingsFileViewer.AutoSize = true;
            this.lblCandySettingsFileViewer.BackColor = System.Drawing.Color.Transparent;
            this.lblCandySettingsFileViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandySettingsFileViewer.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandySettingsFileViewer.ForeColor = System.Drawing.Color.Brown;
            this.lblCandySettingsFileViewer.Location = new System.Drawing.Point(30, 0);
            this.lblCandySettingsFileViewer.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandySettingsFileViewer.Name = "lblCandySettingsFileViewer";
            this.lblCandySettingsFileViewer.Size = new System.Drawing.Size(449, 18);
            this.lblCandySettingsFileViewer.TabIndex = 32;
            this.lblCandySettingsFileViewer.Text = "Candy Settings Viewer";
            this.lblCandySettingsFileViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandySettingsFileViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandySettingsViewerWindow_MouseDown);
            // 
            // btnExitSettingsViewer
            // 
            this.btnExitSettingsViewer.BackColor = System.Drawing.Color.Maroon;
            this.btnExitSettingsViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitSettingsViewer.FlatAppearance.BorderSize = 0;
            this.btnExitSettingsViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSettingsViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSettingsViewer.Location = new System.Drawing.Point(481, 1);
            this.btnExitSettingsViewer.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitSettingsViewer.Name = "btnExitSettingsViewer";
            this.btnExitSettingsViewer.Size = new System.Drawing.Size(43, 18);
            this.btnExitSettingsViewer.TabIndex = 33;
            this.btnExitSettingsViewer.Text = "X";
            this.btnExitSettingsViewer.UseVisualStyleBackColor = false;
            this.btnExitSettingsViewer.Click += new System.EventHandler(this.ExitSettingsViewer_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.Color.White;
            this.richTextBox.Location = new System.Drawing.Point(0, 21);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(525, 466);
            this.richTextBox.TabIndex = 36;
            this.richTextBox.Text = "";
            // 
            // tblLPBottomControlsContainer
            // 
            this.tblLPBottomControlsContainer.BackColor = System.Drawing.Color.Black;
            this.tblLPBottomControlsContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPBottomControlsContainer.ColumnCount = 3;
            this.tblLPBottomControlsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPBottomControlsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLPBottomControlsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLPBottomControlsContainer.Controls.Add(this.btnCopySettingsText, 1, 0);
            this.tblLPBottomControlsContainer.Controls.Add(this.btnSaveSettings, 2, 0);
            this.tblLPBottomControlsContainer.Location = new System.Drawing.Point(0, 489);
            this.tblLPBottomControlsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPBottomControlsContainer.Name = "tblLPBottomControlsContainer";
            this.tblLPBottomControlsContainer.RowCount = 1;
            this.tblLPBottomControlsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPBottomControlsContainer.Size = new System.Drawing.Size(525, 26);
            this.tblLPBottomControlsContainer.TabIndex = 37;
            // 
            // btnCopySettingsText
            // 
            this.btnCopySettingsText.BackColor = System.Drawing.Color.Black;
            this.btnCopySettingsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopySettingsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopySettingsText.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopySettingsText.ForeColor = System.Drawing.Color.Brown;
            this.btnCopySettingsText.Location = new System.Drawing.Point(403, 1);
            this.btnCopySettingsText.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopySettingsText.Name = "btnCopySettingsText";
            this.btnCopySettingsText.Size = new System.Drawing.Size(60, 24);
            this.btnCopySettingsText.TabIndex = 34;
            this.btnCopySettingsText.Text = "Copy";
            this.btnCopySettingsText.UseVisualStyleBackColor = false;
            this.btnCopySettingsText.Click += new System.EventHandler(this.CopySettingsText_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Brown;
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSettings.Location = new System.Drawing.Point(464, 1);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(60, 24);
            this.btnSaveSettings.TabIndex = 33;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // CandySettingsFileViewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 515);
            this.Controls.Add(this.tblLPBottomControlsContainer);
            this.Controls.Add(this.tblLPFormTopControls);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandySettingsFileViewerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Candy Settings: File Viewer";
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.tblLPBottomControlsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.Label lblCandySettingsFileViewer;
        private System.Windows.Forms.Button btnExitSettingsViewer;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TableLayoutPanel tblLPBottomControlsContainer;
        private System.Windows.Forms.Button btnCopySettingsText;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}