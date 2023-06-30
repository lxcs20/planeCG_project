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
    public partial class Play : Form
    {
        string plane;
        Graphics g;
        Bitmap bmp;
        int x, y;
        int level;

        enum Position{
            Left, Right
        }

        Position posPlane;
        public Play()
        {
            InitializeComponent();
            plane = Option.plane;
            level = Option.level;
            //MessageBox.Show(plane);
            bmp = new Bitmap(plane);
            
        }
        public static WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();

        private void Play_Load(object sender, EventArgs e)
        {
            wplayer2.URL = (@"songs\shoot.wav");
            pictureBox2.Image = bmp;
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBreakgame_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new Break().Show();
        }

        private void Play_Paint(object sender, PaintEventArgs e)
        {
        
        }
    }
}
