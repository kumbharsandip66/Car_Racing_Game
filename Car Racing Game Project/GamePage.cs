using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game_Project
{
    public partial class GamePage : Form
    {
        public GamePage()
        {
            InitializeComponent();
            Over.Visible = false;
            btnmain.Visible = false;
            lblyscore.Visible = false;
            pictureBox7.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Moveline(gamespeed);
            Enemy(gamespeed);
            Gameover();
            coin(gamespeed);
            coincollection();
            showspeed();
        }
        void Moveline(int speed)
        {
            if (pictureBox1.Top >= 550)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 550)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 550)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 550)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        int gamespeed = 0;

        private void GamePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left >= 18)
                    Car.Left += -10;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Car.Left <= 385)
                    Car.Left += 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 10)
                    gamespeed++;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }
        }
        Random r = new Random();
        int x, y;
        void Enemy(int speed)
        {
            if (Enemy1.Top >= 550)
            {
                x = r.Next(18, 150);
                Enemy1.Location = new Point(x, 0);
            }
            else
            {
                Enemy1.Top += speed;
            }

            if (Enemy2.Top >= 550)
            {
                x = r.Next(180, 300);
                Enemy2.Location = new Point(x, 0);
            }
            else
            {
                Enemy2.Top += speed;
            }

            if (Enemy3.Top >= 550)
            {
                x = r.Next(320, 385);
                Enemy3.Location = new Point(x, 0);
            }
            else
            {
                Enemy3.Top += speed;
            }
        }

        void Gameover()
        {
            if (Car.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                pictureBox7.Visible = true;
                btnmain.Visible = true;
                lblyscore.Visible = true;
                lblyscore.Text = "Your Score: " + collection.ToString();
            }
            if (Car.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                pictureBox7.Visible = true;
                btnmain.Visible = true;
                lblyscore.Visible = true;
                lblyscore.Text = "Your Score: " + collection.ToString();
            }
            if (Car.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                pictureBox7.Visible = true;
                btnmain.Visible = true;
                lblyscore.Visible = true;
                lblyscore.Text = "Your Score: " + collection.ToString();
            }
        }

        void coin(int speed)
        {
            if (coin1.Top >= 550)
            {
                x = r.Next(18, 150);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += gamespeed;
            }

            if (coin2.Top >= 550)
            {
                x = r.Next(150, 300);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += gamespeed;
            }

            if (coin3.Top >= 550)
            {
                x = r.Next(300, 385);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += gamespeed;
            }

            if (coin4.Top >= 550)
            {
                x = r.Next(500, 550);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += gamespeed;
            }
        }

        public int collection = 0;
        void showspeed()
        {
            lblspeed.Text = "Speed= " + (gamespeed * 10).ToString();
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            FirstPage f = new FirstPage();
            this.Hide();
            f.Show();
        }

        void coincollection()
        {
            if (Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collection++;
                label1.Text = "Score = " + collection.ToString();
                x = r.Next(0, 550);
                coin1.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collection++;
                label1.Text = "Score = " + collection.ToString();
                x = r.Next(0, 550);
                coin2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collection++;
                label1.Text = "Score = " + collection.ToString();
                x = r.Next(0, 550);
                coin3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collection++;
                label1.Text = "Score = " + collection.ToString();
                x = r.Next(0, 550);
                coin4.Location = new Point(x, 0);
            }
        }

    }
}
