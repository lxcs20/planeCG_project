using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Plane_Shooter
{
    public partial class Options : Form
    {
        public static string plane;
        Bitmap bmp;
        Thread threadMovePlane;
        public Options()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnPl11_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl11.png");
            plane = "charecter/pl11.png";
        }

        private void Options_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap("charecter/pl11.png");
            //btnMain.BackgroundImage = bmp;
            btnPl11.PerformClick();
            

            pictureBox16.Location = new Point(150, 150);

            threadMovePlane = new Thread(movePic);
            threadMovePlane.Start();
        }

        private void ChooseP(string imgPath)
        {
            btnMain.BackgroundImage = null;
            bmp = new Bitmap(imgPath);
            btnMain.BackgroundImage = bmp;
        }

        private void btnPl12_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl12.png");
            plane = "charecter/pl12.png";
        }

        private void btnPl13_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl13.png");
            plane = "charecter/pl13.png";
        }

        private void btnPl21_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl21.png");
        }

        private void btnPl22_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl22.png");
        }

        private void btnPl23_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl23.png");
        }

        private void btnPl31_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl31.png");
        }

        private void btnPl32_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl32.png");
        }

        private void btnPl33_Click(object sender, EventArgs e)
        {
            ChooseP("charecter/pl33.png");
        }

        private void movePic()
        {
            int maxMove = 20;

            // Create a random number generator
            Random random = new Random();

            while (true)
            {
                // Loop through each PictureBox on the form
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
                }
                Thread.Sleep(300);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
            //MessageBox.Show(Home.plane);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
