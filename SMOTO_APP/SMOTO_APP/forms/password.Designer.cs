﻿namespace SMOTO_APP.forms
{
    partial class password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.name_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.submit_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(130, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(176, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Change Password";
            // 
            // signup_panel
            // 
            this.signup_panel.Controls.Add(this.submit_btn);
            this.signup_panel.Controls.Add(this.bunifuCustomLabel4);
            this.signup_panel.Controls.Add(this.bunifuCustomLabel2);
            this.signup_panel.Controls.Add(this.email_txt);
            this.signup_panel.Controls.Add(this.name_txt);
            this.signup_panel.Controls.Add(this.bunifuCustomLabel1);
            this.signup_panel.Location = new System.Drawing.Point(29, 18);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(402, 301);
            this.signup_panel.TabIndex = 14;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(33, 129);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(44, 17);
            this.bunifuCustomLabel4.TabIndex = 55;
            this.bunifuCustomLabel4.Text = "EMAIL";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 45);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "NAME";
            // 
            // email_txt
            // 
            this.email_txt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.email_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.email_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.email_txt.BorderThickness = 3;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.email_txt.isPassword = false;
            this.email_txt.Location = new System.Drawing.Point(36, 159);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(339, 44);
            this.email_txt.TabIndex = 52;
            this.email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name_txt
            // 
            this.name_txt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.name_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.name_txt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.name_txt.BorderThickness = 3;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.name_txt.isPassword = false;
            this.name_txt.Location = new System.Drawing.Point(36, 66);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(339, 44);
            this.name_txt.TabIndex = 51;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // submit_btn
            // 
            this.submit_btn.ActiveBorderThickness = 1;
            this.submit_btn.ActiveCornerRadius = 1;
            this.submit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(42)))));
            this.submit_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.submit_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(42)))));
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.submit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit_btn.BackgroundImage")));
            this.submit_btn.ButtonText = "SEND";
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.submit_btn.IdleBorderThickness = 1;
            this.submit_btn.IdleCornerRadius = 1;
            this.submit_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.submit_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.submit_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(8)))), ((int)(((byte)(121)))));
            this.submit_btn.Location = new System.Drawing.Point(89, 233);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(232, 49);
            this.submit_btn.TabIndex = 57;
            this.submit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(474, 339);
            this.Controls.Add(this.signup_panel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "password";
            this.Load += new System.EventHandler(this.password_Load);
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel signup_panel;
        private Bunifu.Framework.UI.BunifuThinButton2 submit_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox email_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox name_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}