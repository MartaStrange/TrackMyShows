using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_My_Shows
{
    public partial class Form3 : Form
    {
        private Point mouse_offset;
        public Form3()
        {
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(username, "Please enter a username you want to use.");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (password.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(password, "Please enter combination of characters you want for your password.");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (!male.Checked && !female.Checked)
            {
                errorProvider3.SetError(female, "Please select either Male or Female.");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (errorProvider1.GetError(username) == "Please enter a username you want to use."
                || errorProvider2.GetError(password) == "Please enter combination of characters you want for your password."
                || errorProvider3.GetError(female) == "Please select either Male or Female.")
            {
            
            }
            else
            {
                SQLiteConnection connection = DatabaseConnector.getConnection();

                string sql = "delete from users";
                Console.WriteLine(sql);
                //SQLiteCommand 
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                sql = "delete from movies";
                Console.WriteLine(sql);
                //SQLiteCommand 
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                string usr = username.Text;
                string pwd = password.Text;
                int gen = 2;
                if(male.Checked)
                gen = 1;
                if(female.Checked)
                gen = 0;
                string date = DateTime.Now.ToString();

                sql = String.Format("insert into users (username, password, gender, date_registered) values ('{0}', '{1}', {2}, '{3}')",
                                            usr, pwd, gen, date);

                Console.WriteLine(sql);
                //SQLiteCommand 
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

    }
}
