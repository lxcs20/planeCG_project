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
    public partial class Break : Form
    {
        public Break()
        {
            InitializeComponent();
        }

        private void soundShooting_Scroll(object sender, EventArgs e)
        {
            label1.Text = soundShooting.Value.ToString();
            Play.wplayer2.settings.volume = soundShooting.Value;
        }

        private void soundGame_Scroll(object sender, EventArgs e)
        {
            label2.Text = soundGame.Value.ToString();
            Home.wplayer.settings.volume = soundShooting.Value;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Break breaks = new Break();

            foreach (Form f in Application.OpenForms)
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

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.Close();
            new Play().Show();
        }

        private void btn_continue_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_agian_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }

        private void btn_continue_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }
    }
}
