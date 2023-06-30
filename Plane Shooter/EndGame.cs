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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            EndGame endgame = new EndGame();


            foreach(Form f in Application.OpenForms)
            {
                if (f.Name != "Home")
                    f.Hide();
            }
            home.Show();
        }

        private void btn_agian_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            play.Show();
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_agian_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }
    }
}
