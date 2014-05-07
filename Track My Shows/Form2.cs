using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_My_Shows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            panelUnwatched.Visible = false;
            panelProfile.Visible = false;
        
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void avatar_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = true;
            panelUnwatched.Visible = false;
            panelProfile.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = false;
            panelUnwatched.Visible = true;
            panelProfile.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = false;
            panelUnwatched.Visible = false;
            panelProfile.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
}
