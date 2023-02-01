using System.Windows.Forms;

namespace CandyGallery.Interface
{
    partial class LoginWindow
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
            System.Windows.Forms.Label lblLoginPrompt;
            System.Windows.Forms.Label lblUsername;
            System.Windows.Forms.Label lblPassword;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tblLPLoginBorder = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPFormTopControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLPTitleContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCandyGallery = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            lblLoginPrompt = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            this.tblLPLoginBorder.SuspendLayout();
            this.tblLPFormTopControls.SuspendLayout();
            this.tblLPTitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.AutoSize = true;
            lblLoginPrompt.ForeColor = System.Drawing.Color.IndianRed;
            lblLoginPrompt.Location = new System.Drawing.Point(131, 67);
            lblLoginPrompt.Margin = new System.Windows.Forms.Padding(0);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new System.Drawing.Size(128, 13);
            lblLoginPrompt.TabIndex = 1;
            lblLoginPrompt.Text = "Please Login to Continue:";
            lblLoginPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = System.Drawing.Color.Linen;
            lblUsername.Location = new System.Drawing.Point(100, 94);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(58, 13);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = System.Drawing.Color.Linen;
            lblPassword.Location = new System.Drawing.Point(102, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(56, 13);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Linen;
            this.txtPassword.Location = new System.Drawing.Point(164, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.PassText_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Linen;
            this.txtUsername.Location = new System.Drawing.Point(164, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Brown;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(105, 143);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 27);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // tblLPLoginBorder
            // 
            this.tblLPLoginBorder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPLoginBorder.ColumnCount = 1;
            this.tblLPLoginBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPLoginBorder.Controls.Add(this.tblLPFormTopControls, 0, 0);
            this.tblLPLoginBorder.Location = new System.Drawing.Point(0, 0);
            this.tblLPLoginBorder.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPLoginBorder.Name = "tblLPLoginBorder";
            this.tblLPLoginBorder.RowCount = 1;
            this.tblLPLoginBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLPLoginBorder.Size = new System.Drawing.Size(390, 240);
            this.tblLPLoginBorder.TabIndex = 1;
            // 
            // tblLPFormTopControls
            // 
            this.tblLPFormTopControls.BackColor = System.Drawing.Color.Black;
            this.tblLPFormTopControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLPFormTopControls.ColumnCount = 2;
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLPFormTopControls.Controls.Add(this.tblLPTitleContainer, 0, 0);
            this.tblLPFormTopControls.Controls.Add(this.btnExit, 1, 0);
            this.tblLPFormTopControls.Location = new System.Drawing.Point(1, 1);
            this.tblLPFormTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPFormTopControls.Name = "tblLPFormTopControls";
            this.tblLPFormTopControls.RowCount = 1;
            this.tblLPFormTopControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPFormTopControls.Size = new System.Drawing.Size(388, 20);
            this.tblLPFormTopControls.TabIndex = 35;
            this.tblLPFormTopControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyLoginWindow_MouseDown);
            // 
            // tblLPTitleContainer
            // 
            this.tblLPTitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tblLPTitleContainer.ColumnCount = 2;
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLPTitleContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Controls.Add(this.lblCandyGallery, 1, 0);
            this.tblLPTitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLPTitleContainer.Location = new System.Drawing.Point(1, 1);
            this.tblLPTitleContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblLPTitleContainer.Name = "tblLPTitleContainer";
            this.tblLPTitleContainer.RowCount = 1;
            this.tblLPTitleContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPTitleContainer.Size = new System.Drawing.Size(354, 18);
            this.tblLPTitleContainer.TabIndex = 10;
            this.tblLPTitleContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyLoginWindow_MouseDown);
            // 
            // lblCandyGallery
            // 
            this.lblCandyGallery.AutoSize = true;
            this.lblCandyGallery.BackColor = System.Drawing.Color.Transparent;
            this.lblCandyGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCandyGallery.Font = new System.Drawing.Font("Magneto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandyGallery.ForeColor = System.Drawing.Color.Brown;
            this.lblCandyGallery.Location = new System.Drawing.Point(30, 0);
            this.lblCandyGallery.Margin = new System.Windows.Forms.Padding(0);
            this.lblCandyGallery.Name = "lblCandyGallery";
            this.lblCandyGallery.Size = new System.Drawing.Size(324, 18);
            this.lblCandyGallery.TabIndex = 32;
            this.lblCandyGallery.Text = "Candy Gallery";
            this.lblCandyGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCandyGallery.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CandyLoginWindow_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(356, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 18);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(390, 240);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(lblPassword);
            this.Controls.Add(lblLoginPrompt);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(lblUsername);
            this.Controls.Add(this.tblLPLoginBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candy Login";
            this.tblLPLoginBorder.ResumeLayout(false);
            this.tblLPFormTopControls.ResumeLayout(false);
            this.tblLPTitleContainer.ResumeLayout(false);
            this.tblLPTitleContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tblLPLoginBorder;
        private System.Windows.Forms.TableLayoutPanel tblLPFormTopControls;
        private System.Windows.Forms.TableLayoutPanel tblLPTitleContainer;
        private System.Windows.Forms.Label lblCandyGallery;
        private System.Windows.Forms.Button btnExit;
    }
}