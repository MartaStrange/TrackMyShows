namespace Track_My_Shows
{
    partial class Form1
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
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.LogIn_btn.FlatAppearance.BorderSize = 0;
            this.LogIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogIn_btn.Location = new System.Drawing.Point(543, 21);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(59, 23);
            this.LogIn_btn.TabIndex = 0;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = false;
            this.LogIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(37)))));
            this.SignUp_btn.FlatAppearance.BorderSize = 0;
            this.SignUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUp_btn.Location = new System.Drawing.Point(543, 54);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(59, 23);
            this.SignUp_btn.TabIndex = 1;
            this.SignUp_btn.Text = "Sign Up";
            this.SignUp_btn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(259, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(400, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::Track_My_Shows.Properties.Resources.TMS1workin_progres614x440_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(614, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SignUp_btn);
            this.Controls.Add(this.LogIn_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 440);
            this.Name = "Form1";
            this.Text = "Track My Shows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

