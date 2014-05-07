namespace Track_My_Shows
{
    partial class Form2
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
            System.Windows.Forms.PictureBox pictureBox2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMyshows = new System.Windows.Forms.Panel();
            this.groupBox_all = new System.Windows.Forms.GroupBox();
            this.groupBox_lastWatched = new System.Windows.Forms.GroupBox();
            this.groupBox_lastAdded = new System.Windows.Forms.GroupBox();
            this.panelUnwatched = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMyshows.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::Track_My_Shows.Properties.Resources.TMS_first_tryoutlogologo1;
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 49);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 49);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Track_My_Shows.Properties.Resources.sbiconPURPLE;
            this.pictureBox1.Location = new System.Drawing.Point(321, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchBar
            // 
            this.searchBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchBar.Location = new System.Drawing.Point(106, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(231, 20);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(49, 49);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.BackgroundImage = global::Track_My_Shows.Properties.Resources.femaleAvatar;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.logOutToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = global::Track_My_Shows.Properties.Resources.femaleAvatar;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 49);
            this.toolStripMenuItem1.Text = "avatar";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem4.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.toolStripMenuItem4.Image = global::Track_My_Shows.Properties.Resources.profilemaleIcon;
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 32);
            this.toolStripMenuItem4.Text = "My profile";
            this.toolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.toolStripMenuItem2.Image = global::Track_My_Shows.Properties.Resources.myshowsIcon;
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 32);
            this.toolStripMenuItem2.Text = "My shows";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem3.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.toolStripMenuItem3.Image = global::Track_My_Shows.Properties.Resources.watchIcon;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 32);
            this.toolStripMenuItem3.Text = "Unwatched";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.AutoSize = false;
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.logOutToolStripMenuItem.Image = global::Track_My_Shows.Properties.Resources.logoutIcon;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // panelMyshows
            // 
            this.panelMyshows.BackColor = System.Drawing.Color.White;
            this.panelMyshows.Controls.Add(this.groupBox_all);
            this.panelMyshows.Controls.Add(this.groupBox_lastWatched);
            this.panelMyshows.Controls.Add(this.groupBox_lastAdded);
            this.panelMyshows.Location = new System.Drawing.Point(0, 49);
            this.panelMyshows.Name = "panelMyshows";
            this.panelMyshows.Size = new System.Drawing.Size(614, 391);
            this.panelMyshows.TabIndex = 1;
            // 
            // groupBox_all
            // 
            this.groupBox_all.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_all.Font = new System.Drawing.Font("PixelPlay", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(127)))), ((int)(((byte)(144)))));
            this.groupBox_all.Location = new System.Drawing.Point(3, 260);
            this.groupBox_all.Name = "groupBox_all";
            this.groupBox_all.Size = new System.Drawing.Size(608, 121);
            this.groupBox_all.TabIndex = 2;
            this.groupBox_all.TabStop = false;
            this.groupBox_all.Text = "All ";
            // 
            // groupBox_lastWatched
            // 
            this.groupBox_lastWatched.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_lastWatched.Font = new System.Drawing.Font("PixelPlay", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_lastWatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(127)))), ((int)(((byte)(144)))));
            this.groupBox_lastWatched.Location = new System.Drawing.Point(3, 133);
            this.groupBox_lastWatched.Name = "groupBox_lastWatched";
            this.groupBox_lastWatched.Size = new System.Drawing.Size(608, 121);
            this.groupBox_lastWatched.TabIndex = 1;
            this.groupBox_lastWatched.TabStop = false;
            this.groupBox_lastWatched.Text = "Last watched";
            // 
            // groupBox_lastAdded
            // 
            this.groupBox_lastAdded.BackColor = System.Drawing.Color.White;
            this.groupBox_lastAdded.Font = new System.Drawing.Font("PixelPlay", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_lastAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(127)))), ((int)(((byte)(144)))));
            this.groupBox_lastAdded.Location = new System.Drawing.Point(3, 6);
            this.groupBox_lastAdded.Name = "groupBox_lastAdded";
            this.groupBox_lastAdded.Size = new System.Drawing.Size(608, 121);
            this.groupBox_lastAdded.TabIndex = 0;
            this.groupBox_lastAdded.TabStop = false;
            this.groupBox_lastAdded.Text = "Last added";
            // 
            // panelUnwatched
            // 
            this.panelUnwatched.BackColor = System.Drawing.Color.LightGreen;
            this.panelUnwatched.Location = new System.Drawing.Point(28, 49);
            this.panelUnwatched.Name = "panelUnwatched";
            this.panelUnwatched.Size = new System.Drawing.Size(614, 391);
            this.panelUnwatched.TabIndex = 5;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelProfile.Controls.Add(this.label1);
            this.panelProfile.Controls.Add(this.progressBar1);
            this.panelProfile.Location = new System.Drawing.Point(0, 49);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(614, 391);
            this.panelProfile.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(561, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 440);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUnwatched);
            this.Controls.Add(this.panelMyshows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(614, 440);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMyshows.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMyshows;
        private System.Windows.Forms.Panel panelUnwatched;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.GroupBox groupBox_all;
        private System.Windows.Forms.GroupBox groupBox_lastWatched;
        private System.Windows.Forms.GroupBox groupBox_lastAdded;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}