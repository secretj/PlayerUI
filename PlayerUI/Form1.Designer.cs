﻿namespace PlayerUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHelp.Location = new System.Drawing.Point(0, 793);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.button12);
            this.panelToolsSubMenu.Controls.Add(this.button13);
            this.panelToolsSubMenu.Controls.Add(this.button14);
            this.panelToolsSubMenu.Controls.Add(this.button15);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 622);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(233, 171);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(0, 120);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(233, 40);
            this.button12.TabIndex = 3;
            this.button12.Text = "button12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(0, 80);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(233, 40);
            this.button13.TabIndex = 2;
            this.button13.Text = "button13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(0, 40);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(233, 40);
            this.button14.TabIndex = 1;
            this.button14.Text = "button14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(0, 0);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(233, 40);
            this.button15.TabIndex = 0;
            this.button15.Text = "button15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTools.Location = new System.Drawing.Point(0, 577);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 532);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(233, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "Equalizer";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.UseVisualStyleBackColor = true;
            this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.button6);
            this.panelPlaylistSubMenu.Controls.Add(this.button7);
            this.panelPlaylistSubMenu.Controls.Add(this.button8);
            this.panelPlaylistSubMenu.Controls.Add(this.button9);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 361);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(233, 171);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(0, 120);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(0, 80);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(233, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(0, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(233, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(233, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 316);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(233, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist Management";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.button5);
            this.panelMediaSubMenu.Controls.Add(this.button4);
            this.panelMediaSubMenu.Controls.Add(this.button3);
            this.panelMediaSubMenu.Controls.Add(this.button2);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(233, 171);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 120);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(233, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(233, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(233, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(233, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(233, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelPlayer.Controls.Add(this.pictureBox3);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 418);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 143);
            this.panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 418);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(684, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

