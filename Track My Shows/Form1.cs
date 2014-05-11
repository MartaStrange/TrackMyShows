using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_My_Shows
{
    public partial class Form1 : Form
    {
        private Point mouse_offset;
        private Form3 signUpForm;
        private bool Flag;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Flag = false;

        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            string usr = username.Text;
            string pwd = password.Text;
            SQLiteConnection connection = DatabaseConnector.getConnection();

            string sql = "select * from users where username = '" + usr + "' and password = '" + pwd + "'";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Wrong username or password","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2 form2 = new Form2();
                reader.Read();

                User user = new User();
                user.gender = (int)(long)reader["gender"];
                user.dateRegistered = reader["date_registered"].ToString();
                user.username = reader["username"].ToString();

                form2.user = user;

                form2.Show();
                form2.Bounds = this.Bounds;

                this.Hide();
            }

        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = DatabaseConnector.getConnection();

            string sql = "select * from users";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (signUpForm == null || signUpForm.Visible == false)
            {
                DialogResult result = DialogResult.OK;

                if (reader.HasRows)
                {
                    result = MessageBox.Show("If you create new acount the previous will be deleted!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

                if (result == DialogResult.Cancel)
                {
                    Flag = true;
                }

                if (!Flag)
                {
                    Flag = false;
                    signUpForm = new Form3();
                    signUpForm.Show();
                }
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }      

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string usr = username.Text;
                string pwd = password.Text;
                SQLiteConnection connection = DatabaseConnector.getConnection();

                string sql = "select * from users where username = '" + usr + "' and password = '" + pwd + "'";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Wrong username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Form2 form2 = new Form2();
                    reader.Read();

                    User user = new User();
                    user.gender = (int)(long)reader["gender"];
                    user.dateRegistered = reader["date_registered"].ToString();
                    user.username = reader["username"].ToString();

                    form2.user = user;
                   
                    form2.Show();
                    form2.Bounds = this.Bounds;
                   
                    this.Hide();
                }
            }
        }   

    }
}
