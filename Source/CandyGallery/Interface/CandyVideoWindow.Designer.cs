using System;
using System.Windows.Forms;
using AxWMPLib;

namespace CandyGallery.Interface
{
    partial class CandyVideoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandyVideoWindow));
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximizeVideo = new System.Windows.Forms.Button();
            this.btnExitVideo = new System.Windows.Forms.Button();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandyVideoTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(0, 19);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(770, 495);
            this.videoPlayer.TabIndex = 38;
            this.videoPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.VideoPlayer_PlayStateChange);
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 3;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.Controls.Add(this.btnMaximizeVideo, 1, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExitVideo, 2, 0);
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Location = new System.Drawing.Point(0, 0);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(770, 20);
            this.tblLPFormTopControls.TabIndex = 39;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyVideoWindow_MouseDown);
            // 
            // btnMaximizeVideo
            // 
            this.btnMaximizeVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnMaximizeVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizeVideo.FlatAppearance.BorderSize = 0;
            this.btnMaximizeVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizeVideo.Location = new System.Drawing.Point(708, 1);
            this.btnMaximizeVideo.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizeVideo.Name = "btnMaximizeVideo";
            this.btnMaximizeVideo.Size = new System.Drawing.Size(30, 18);
            this.btnMaximizeVideo.TabIndex = 8;
            this.btnMaximizeVideo.Text = "☐";
            this.btnMaximizeVideo.UseVisualStyleBackColor = false;
            this.btnMaximizeVideo.Click += new System.EventHandler(this.MaximizeVideo_Click);
            // 
            // btnExitVideo
            // 
            this.btnExitVideo.BackColor = System.Drawing.Color.Maroon;
            this.btnExitVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitVideo.FlatAppearance.BorderSize = 0;
            this.btnExitVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitVideo.Location = new System.Drawing.Point(739, 1);
            this.btnExitVideo.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitVideo.Name = "btnExitVideo";
            this.btnExitVideo.Size = new System.Drawing.Size(30, 18);
            this.btnExitVideo.TabIndex = 7;
            this.btnExitVideo.Text = "X";
            this.btnExitVideo.UseVisualStyleBackColor = false;
            this.btnExitVideo.Click += new System.EventHandler(this.ExitVideo_Click);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandyVideoTitle, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(706, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyVideoWindow_MouseDown);
            // 
            // lblCandyVideoTitle
            // 
            this.lblCandyVideoTitle.AutoSize = true;
            this.lblCandyVideoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCandyVideoTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandyVideoTitle.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandyVideoTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblCandyVideoTitle.Location = new System.Drawing.Point(60, 0);
            this.lblCandyVideoTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandyVideoTitle.Name = "lblCandyVideoTitle";
            this.lblCandyVideoTitle.Size = new System.Drawing.Size(646, 18);
            this.lblCandyVideoTitle.TabIndex = 10;
            this.lblCandyVideoTitle.Text = "Candy Video";
            this.lblCandyVideoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandyVideoTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyVideoWindow_MouseDown);
            // 
            // CandyVideoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 515);
            this.Controls.Add(this.tblLPFormTopControls);
            this.Controls.Add(this.videoPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandyVideoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyVideoWindow";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CandyViewWindow_FormClosing);
            this.Load += new System.EventHandler(this.CandyViewWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.Button btnMaximizeVideo;
        private System.Windows.Forms.Button btnExitVideo;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.Label lblCandyVideoTitle;
    }
}