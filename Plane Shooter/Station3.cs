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
    
    public partial class Station3 : Form
    {
        Bitmap bmp;
        public Station3()
        {
            InitializeComponent();
        }

        private void ST2_plan1_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p31.png", 3);
        }

        private void ST2_plan2_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p32.png", 3);
        }

        private void ST2_plan3_Click(object sender, EventArgs e)
        {
            chooesPlane("charecter/p33.png", 3);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Play().Show();
        }

        private void btn_Ok_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        void chooesPlane(string imagePath, int lvel)
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
    }
}
