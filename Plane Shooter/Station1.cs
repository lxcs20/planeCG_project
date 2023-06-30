using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Shooter
{
    public partial class Station1 : Form
    {
        public static string plane;
        public int vel;
        Bitmap bmp;

        public Station1()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ST1_plan1_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p11.png", 1);
        }

        private void ST1_plan2_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p12.png", 1);
        }

        private void ST1_plan3_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p13.png", 1);
        }

        private void btn_Ok_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        public void chooesPlane(string imagePath, int lvel)
        {
            bmp = new Bitmap(imagePath);
            if (pictureBox1.Image != null)
                pictureBox1.Image = null;
            pictureBox1.Image = bmp;
            Option.plane = imagePath;
            Option.level = lvel;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Option().Show();
        }

        private void btn_Ok_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Play().Show();
        }
    }
}
