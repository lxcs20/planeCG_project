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
    public partial class Option : Form
    {

        public static int level;
        public static string plane;
        public Option()
        {
            InitializeComponent();
        }

        private void btn_select1_Click(object sender, EventArgs e)
        {
            new Station1().Show();
            Visible = false;
        }

        private void btn_select2_Click(object sender, EventArgs e)
        {
            new Station2().Show();
            Visible = false;
        }

        private void btn_select3_Click(object sender, EventArgs e)
        {
            new Station3().Show();
            Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void btn_select1_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_select2_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_select3_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }
    }
}
