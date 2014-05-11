using System.Drawing;

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
            this.profileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unwatchedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMyshows = new System.Windows.Forms.Panel();
            this.allMovies = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.noMoviesLbl = new System.Windows.Forms.Label();
            this.panelUnwatched = new System.Windows.Forms.Panel();
            this.unwatchedMovies = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panelProfileInfo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentToWatch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentUsername = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.currentDateRegistered = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.movieTmdbId = new System.Windows.Forms.TextBox();
            this.saveMovie = new System.Windows.Forms.Button();
            this.movieOverview = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movieWatched = new System.Windows.Forms.CheckBox();
            this.movieTagline = new System.Windows.Forms.TextBox();
            this.movieLength = new System.Windows.Forms.TextBox();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelMyshows.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelUnwatched.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelProfileInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 23);
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
            this.searchBar.Location = new System.Drawing.Point(106, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(231, 20);
            this.searchBar.TabIndex = 2;
            this.searchBar.TabStop = false;
            this.searchBar.Text = "Search";
            this.searchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBar_MouseClick);
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(49, 49);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 49);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileMenuItem,
            this.showsMenuItem,
            this.unwatchedMenuItem,
            this.logOutMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 49);
            this.toolStripMenuItem1.Text = "avatar";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // profileMenuItem
            // 
            this.profileMenuItem.AutoSize = false;
            this.profileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.profileMenuItem.Font = new System.Drawing.Font("pixelplay", 15F, System.Drawing.FontStyle.Bold);
            this.profileMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.profileMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.profileMenuItem.Name = "profileMenuItem";
            this.profileMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileMenuItem.Size = new System.Drawing.Size(173, 32);
            this.profileMenuItem.Text = "My profile";
            this.profileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.profileMenuItem.Click += new System.EventHandler(this.profileMenuItem_Click);
            // 
            // showsMenuItem
            //
            this.showsMenuItem.AutoSize = false;
            this.showsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.showsMenuItem.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.showsMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.showsMenuItem.Image = global::Track_My_Shows.Properties.Resources.myshowsIcon;
            this.showsMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showsMenuItem.Name = "showsMenuItem";
            this.showsMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showsMenuItem.Size = new System.Drawing.Size(173, 32);
            this.showsMenuItem.Text = "My shows";
            this.showsMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showsMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.showsMenuItem.Click += new System.EventHandler(this.showsMenuItem_Click);
            // 
            // unwatchedMenuItem
            // 
            this.unwatchedMenuItem.AutoSize = false;
            this.unwatchedMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.unwatchedMenuItem.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.unwatchedMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.unwatchedMenuItem.Image = global::Track_My_Shows.Properties.Resources.watchIcon;
            this.unwatchedMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unwatchedMenuItem.Name = "unwatchedMenuItem";
            this.unwatchedMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unwatchedMenuItem.Size = new System.Drawing.Size(173, 32);
            this.unwatchedMenuItem.Text = "Unwatched";
            this.unwatchedMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unwatchedMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.unwatchedMenuItem.Click += new System.EventHandler(this.unwatchedMenuItem_Click);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.AutoSize = false;
            this.logOutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.logOutMenuItem.Font = new System.Drawing.Font("PixelPlay", 15F, System.Drawing.FontStyle.Bold);
            this.logOutMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.logOutMenuItem.Image = global::Track_My_Shows.Properties.Resources.logoutIcon;
            this.logOutMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logOutMenuItem.Size = new System.Drawing.Size(173, 32);
            this.logOutMenuItem.Text = "Log out";
            this.logOutMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // panelMyshows
            // 
            this.panelMyshows.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelMyshows.Controls.Add(this.allMovies);
            this.panelMyshows.Controls.Add(this.label17);
            this.panelMyshows.Controls.Add(this.label16);
            this.panelMyshows.Location = new System.Drawing.Point(0, 72);
            this.panelMyshows.Name = "panelMyshows";
            this.panelMyshows.Size = new System.Drawing.Size(614, 391);
            this.panelMyshows.TabIndex = 1;
            this.panelMyshows.Visible = false;
            this.panelMyshows.VisibleChanged += new System.EventHandler(this.panelMyshows_VisibleChanged);
            // 
            // allMovies
            // 
            this.allMovies.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.allMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allMovies.FormattingEnabled = true;
            this.allMovies.ItemHeight = 20;
            this.allMovies.Location = new System.Drawing.Point(34, 51);
            this.allMovies.Name = "allMovies";
            this.allMovies.Size = new System.Drawing.Size(563, 320);
            this.allMovies.TabIndex = 0;
            this.allMovies.DoubleClick += new System.EventHandler(this.allMovies_DoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(34, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "No shows added";
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("PixelPlay", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.label16.Location = new System.Drawing.Point(13, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "My shows";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelSearch.Controls.Add(this.searchResults);
            this.panelSearch.Controls.Add(this.label15);
            this.panelSearch.Controls.Add(this.noMoviesLbl);
            this.panelSearch.Location = new System.Drawing.Point(0, 72);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(614, 391);
            this.panelSearch.TabIndex = 1;
            this.panelSearch.Visible = false;
            // 
            // searchResults
            // 
            this.searchResults.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 20;
            this.searchResults.Location = new System.Drawing.Point(34, 51);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(563, 320);
            this.searchResults.Sorted = true;
            this.searchResults.TabIndex = 2;
            this.searchResults.DoubleClick += new System.EventHandler(this.searchResults_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("PixelPlay", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.label15.Location = new System.Drawing.Point(13, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 32);
            this.label15.TabIndex = 4;
            this.label15.Text = "Search results";
            // 
            // noMoviesLbl
            // 
            this.noMoviesLbl.AutoSize = true;
            this.noMoviesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noMoviesLbl.Location = new System.Drawing.Point(34, 51);
            this.noMoviesLbl.Name = "noMoviesLbl";
            this.noMoviesLbl.Size = new System.Drawing.Size(248, 20);
            this.noMoviesLbl.TabIndex = 11;
            this.noMoviesLbl.Text = "No movies found, try different title.";
            // 
            // panelUnwatched
            // 
            this.panelUnwatched.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelUnwatched.Controls.Add(this.unwatchedMovies);
            this.panelUnwatched.Controls.Add(this.label11);
            this.panelUnwatched.Controls.Add(this.label12);
            this.panelUnwatched.Location = new System.Drawing.Point(0, 72);
            this.panelUnwatched.Name = "panelUnwatched";
            this.panelUnwatched.Size = new System.Drawing.Size(614, 391);
            this.panelUnwatched.TabIndex = 5;
            this.panelUnwatched.Visible = false;
            // 
            // unwatchedMovies
            // 
            this.unwatchedMovies.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.unwatchedMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unwatchedMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unwatchedMovies.FormattingEnabled = true;
            this.unwatchedMovies.ItemHeight = 20;
            this.unwatchedMovies.Location = new System.Drawing.Point(34, 51);
            this.unwatchedMovies.Name = "unwatchedMovies";
            this.unwatchedMovies.Size = new System.Drawing.Size(563, 320);
            this.unwatchedMovies.TabIndex = 9;
            this.unwatchedMovies.VisibleChanged += new System.EventHandler(this.unwatchedMovies_VisibleChanged);
            this.unwatchedMovies.DoubleClick += new System.EventHandler(this.unwatchedMovies_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PixelPlay", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.label11.Location = new System.Drawing.Point(13, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Unwatched movies";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(34, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "No unwatched movies";
            this.label12.Visible = false;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelProfile.Controls.Add(this.label18);
            this.panelProfile.Controls.Add(this.panelProfileInfo);
            this.panelProfile.Controls.Add(this.label1);
            this.panelProfile.Controls.Add(this.progressBar1);
            this.panelProfile.Location = new System.Drawing.Point(0, 72);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(614, 391);
            this.panelProfile.TabIndex = 1;
            this.panelProfile.Visible = false;
            this.panelProfile.VisibleChanged += new System.EventHandler(this.panelProfile_VisibleChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("PixelPlay", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.label18.Location = new System.Drawing.Point(13, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 32);
            this.label18.TabIndex = 3;
            this.label18.Text = "Profile";
            // 
            // panelProfileInfo
            // 
            this.panelProfileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.panelProfileInfo.Controls.Add(this.panel4);
            this.panelProfileInfo.Controls.Add(this.panel3);
            this.panelProfileInfo.Controls.Add(this.panel2);
            this.panelProfileInfo.Controls.Add(this.panel6);
            this.panelProfileInfo.Controls.Add(this.panel5);
            this.panelProfileInfo.Location = new System.Drawing.Point(12, 118);
            this.panelProfileInfo.Name = "panelProfileInfo";
            this.panelProfileInfo.Size = new System.Drawing.Size(590, 253);
            this.panelProfileInfo.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel4.Controls.Add(this.currentToWatch);
            this.panel4.Location = new System.Drawing.Point(17, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 41);
            this.panel4.TabIndex = 2;
            // 
            // currentToWatch
            // 
            this.currentToWatch.AutoSize = true;
            this.currentToWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentToWatch.ForeColor = System.Drawing.Color.White;
            this.currentToWatch.Location = new System.Drawing.Point(19, 12);
            this.currentToWatch.Name = "currentToWatch";
            this.currentToWatch.Size = new System.Drawing.Size(0, 17);
            this.currentToWatch.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel3.Controls.Add(this.currentTotal);
            this.panel3.Location = new System.Drawing.Point(17, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 41);
            this.panel3.TabIndex = 1;
            // 
            // currentTotal
            // 
            this.currentTotal.AutoSize = true;
            this.currentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTotal.ForeColor = System.Drawing.Color.White;
            this.currentTotal.Location = new System.Drawing.Point(19, 12);
            this.currentTotal.Name = "currentTotal";
            this.currentTotal.Size = new System.Drawing.Size(0, 17);
            this.currentTotal.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.currentUsername);
            this.panel2.Location = new System.Drawing.Point(17, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 41);
            this.panel2.TabIndex = 0;
            // 
            // currentUsername
            // 
            this.currentUsername.AutoSize = true;
            this.currentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUsername.ForeColor = System.Drawing.Color.White;
            this.currentUsername.Location = new System.Drawing.Point(19, 12);
            this.currentUsername.Name = "currentUsername";
            this.currentUsername.Size = new System.Drawing.Size(0, 17);
            this.currentUsername.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel6.Controls.Add(this.currentDateRegistered);
            this.panel6.Location = new System.Drawing.Point(17, 199);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 41);
            this.panel6.TabIndex = 4;
            // 
            // currentDateRegistered
            // 
            this.currentDateRegistered.AutoSize = true;
            this.currentDateRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDateRegistered.ForeColor = System.Drawing.Color.White;
            this.currentDateRegistered.Location = new System.Drawing.Point(19, 12);
            this.currentDateRegistered.Name = "currentDateRegistered";
            this.currentDateRegistered.Size = new System.Drawing.Size(0, 17);
            this.currentDateRegistered.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.panel5.Location = new System.Drawing.Point(17, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 41);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 51);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.closeBtn.Location = new System.Drawing.Point(592, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(22, 22);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.minimizeBtn.Location = new System.Drawing.Point(570, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(22, 22);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // panelMovie
            // 
            this.panelMovie.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMovie.Controls.Add(this.label13);
            this.panelMovie.Controls.Add(this.movieTmdbId);
            this.panelMovie.Controls.Add(this.saveMovie);
            this.panelMovie.Controls.Add(this.movieOverview);
            this.panelMovie.Controls.Add(this.label10);
            this.panelMovie.Controls.Add(this.label9);
            this.panelMovie.Controls.Add(this.label8);
            this.panelMovie.Controls.Add(this.label7);
            this.panelMovie.Controls.Add(this.movieWatched);
            this.panelMovie.Controls.Add(this.movieTagline);
            this.panelMovie.Controls.Add(this.movieLength);
            this.panelMovie.Controls.Add(this.movieTitle);
            this.panelMovie.Controls.Add(this.moviePoster);
            this.panelMovie.Location = new System.Drawing.Point(0, 72);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(614, 391);
            this.panelMovie.TabIndex = 3;
            this.panelMovie.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(469, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "min";
            // 
            // movieTmdbId
            // 
            this.movieTmdbId.Location = new System.Drawing.Point(499, 21);
            this.movieTmdbId.Name = "movieTmdbId";
            this.movieTmdbId.Size = new System.Drawing.Size(100, 20);
            this.movieTmdbId.TabIndex = 13;
            this.movieTmdbId.Visible = false;
            // 
            // saveMovie
            // 
            this.saveMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveMovie.Location = new System.Drawing.Point(236, 225);
            this.saveMovie.Name = "saveMovie";
            this.saveMovie.Size = new System.Drawing.Size(223, 23);
            this.saveMovie.TabIndex = 12;
            this.saveMovie.Tag = " ";
            this.saveMovie.Text = "Add to my shows first";
            this.saveMovie.UseVisualStyleBackColor = false;
            this.saveMovie.Click += new System.EventHandler(this.saveMovie_Click);
            // 
            // movieOverview
            // 
            this.movieOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.movieOverview.ForeColor = System.Drawing.Color.Black;
            this.movieOverview.Location = new System.Drawing.Point(369, 133);
            this.movieOverview.Multiline = true;
            this.movieOverview.Name = "movieOverview";
            this.movieOverview.ReadOnly = true;
            this.movieOverview.Size = new System.Drawing.Size(226, 204);
            this.movieOverview.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Overview:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tagline:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Duration:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Title:";
            // 
            // movieWatched
            // 
            this.movieWatched.AutoSize = true;
            this.movieWatched.Location = new System.Drawing.Point(20, 354);
            this.movieWatched.Name = "movieWatched";
            this.movieWatched.Size = new System.Drawing.Size(150, 17);
            this.movieWatched.TabIndex = 6;
            this.movieWatched.Text = "I have watched this movie";
            this.movieWatched.UseVisualStyleBackColor = true;
            this.movieWatched.Visible = false;
            this.movieWatched.Click += new System.EventHandler(this.movieWatched_Click);
            // 
            // movieTagline
            // 
            this.movieTagline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.movieTagline.ForeColor = System.Drawing.Color.Black;
            this.movieTagline.Location = new System.Drawing.Point(369, 97);
            this.movieTagline.Name = "movieTagline";
            this.movieTagline.ReadOnly = true;
            this.movieTagline.Size = new System.Drawing.Size(226, 20);
            this.movieTagline.TabIndex = 4;
            // 
            // movieLength
            // 
            this.movieLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.movieLength.ForeColor = System.Drawing.Color.Black;
            this.movieLength.Location = new System.Drawing.Point(369, 61);
            this.movieLength.Name = "movieLength";
            this.movieLength.ReadOnly = true;
            this.movieLength.Size = new System.Drawing.Size(100, 20);
            this.movieLength.TabIndex = 3;
            // 
            // movieTitle
            // 
            this.movieTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.movieTitle.ForeColor = System.Drawing.Color.Black;
            this.movieTitle.Location = new System.Drawing.Point(369, 25);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.ReadOnly = true;
            this.movieTitle.Size = new System.Drawing.Size(100, 20);
            this.movieTitle.TabIndex = 2;
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(20, 21);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(220, 316);
            this.moviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviePoster.TabIndex = 0;
            this.moviePoster.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(614, 463);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMyshows);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelUnwatched);
            this.Controls.Add(this.panelMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Track_My_Shows.Properties.Resources.icon;
            this.MaximumSize = new System.Drawing.Size(614, 463);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMyshows.ResumeLayout(false);
            this.panelMyshows.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelUnwatched.ResumeLayout(false);
            this.panelUnwatched.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelProfileInfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unwatchedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.Panel panelMyshows;
        private System.Windows.Forms.Panel panelUnwatched;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label currentDateRegistered;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label currentToWatch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label currentTotal;
        private System.Windows.Forms.Label currentUsername;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.TextBox movieOverview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox movieWatched;
        private System.Windows.Forms.TextBox movieTagline;
        private System.Windows.Forms.TextBox movieLength;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.PictureBox moviePoster;
        private System.Windows.Forms.Button saveMovie;
        private System.Windows.Forms.TextBox movieTmdbId;
        private System.Windows.Forms.ListBox allMovies;
        private System.Windows.Forms.ListBox unwatchedMovies;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label noMoviesLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}