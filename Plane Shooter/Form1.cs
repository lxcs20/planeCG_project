using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Plane_Shooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;

        PictureBox[] stars;
        int backgroudspeed;
        Random rnd;

        int playerSpeed;

        PictureBox[] munitions;
        int MunitionSpeed;

        PictureBox[] enemies;
        int enemiSpeed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            /*playerSpeed = 4;
            MunitionSpeed = 20;
            munitions = new PictureBox[3];
            enemiSpeed = 4;

            Image munition = Image.FromFile(@"asserts\munition.png");

            for(int i =0; i<munitions.Length;i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            //create WMP
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();

            //Load all Song
            gameMedia.URL = "song\\GameSong.mp3";
            shootgMedia.URL = "songs\\shoot.mp3";

            //Setup song settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;*/

            

            //Backgroud
            backgroudspeed = 4;
            stars = new PictureBox[10];
            rnd = new Random();
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);

            }

            //gameMedia.controls.play();
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for(int i =0;i< stars.Length/2;i++)
            {
                stars[i].Top += backgroudspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for(int i = stars.Length / 2; i< stars.Length;i++)
            {
                stars[i].Top += backgroudspeed-2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void leftMoveTime_Tick(object sender, EventArgs e)
        {
           /* if(Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }*/
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            /*if(Player.Right < 430)
            {
                Player.Left += playerSpeed;
            }*/
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
           /* if(Player.Top < 330)
            {
                Player.Top += playerSpeed;
            }*/
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            /*if(Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                leftMoveTime.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpMoveTimer.Start();
            }*/
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            /*RightMoveTimer.Stop();
            leftMoveTime.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();*/
        }

        private void MoveMunitionTimer_Tick(object sender, EventArgs e)
        {
           /* shootgMedia.controls.play();
            for(int i=0; i<munitions.Length;i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            } */
        }
    }
}
