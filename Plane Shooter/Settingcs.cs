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
    public partial class Settingcs : Form
    {
        public Settingcs()
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
            Home.wplayer.settings.volume = soundGame.Value;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            Home.sound.Play();
        }
    }
}
