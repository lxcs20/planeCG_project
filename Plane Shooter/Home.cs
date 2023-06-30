using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Plane_Shooter
{

    public partial class Home : Form
    {
        Graphics g;
        Bitmap bmp;
        Random rd;
        private int w, h;
        Thread thread1, threadMove, threadMove2;
        Options option;
        public static string plane;
        int maxMove = 10;

        // Create a random number generator
        Random random = new Random();
        public Home()
        {
            InitializeComponent();
            wplayer.URL = (@"\GameSong (online-audio-converter.com).wav");
            wplayer.settings.setMode("loop", true);

            w = h = 50;
            bmp = new Bitmap("pic/p2.png");
            option = new Options();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public static System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"songs\mixkit-clear-mouse-clicks-2997.wav");
        private void Home_Load(object sender, EventArgs e)
        {
           /* rd = new Random();
            thread1 = new Thread(movePicbox2);
            threadMove = new Thread(movePicbox2);
            threadMove2 = new Thread(movePicbox2);
            threadMove.Start();
            thread1.Start();
            threadMove2.Start();*/


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.Show();
            this.Hide();
            //plane = Option.plane;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBestscore_Click(object sender, EventArgs e)
        {
            new BestScore().ShowDialog();
            Visible = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new Settingcs().ShowDialog();
            Visible = true;
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.play_hover;
            sound.Play();
        }

        private void btnOption_MouseHover(object sender, EventArgs e)
        {
            btnOption.Image = Properties.Resources.menu_hover;
            sound.Play();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.exit_hover;
            sound.Play();
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.play_button3;
        }

        private void btnBestscore_MouseHover(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void btnOption_MouseLeave(object sender, EventArgs e)
        {
            btnOption.Image = Properties.Resources.menu;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = Properties.Resources.exit;
        }

        

        


        void movePicbox2()
        {
           /* while (true)
            {
                foreach (PictureBox pictureBox in Controls.OfType<PictureBox>())
                {
                    int x = pictureBox.Location.X;
                    int y = pictureBox.Location.Y;

                    int moveX = random.Next(-maxMove, maxMove + 1);
                    int moveY = random.Next(-maxMove, maxMove + 1);

                    int newX = x + moveX;
                    int newY = y + moveY;

                    pictureBox.Invoke(new MethodInvoker(delegate
                    {
                        pictureBox.Location = new Point(newX, newY);
                    }));
                    Thread.Sleep(100);
                }
            }*/
        }

    }
}
