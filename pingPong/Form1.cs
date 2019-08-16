using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingPong
{

    public partial class Form1 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public int health = 1;


        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            
            racket.Top = playground.Bottom - (playground.Bottom / 10);

            int hp_width = new Random().Next(0, playground.Width);
            int hp_height = new Random().Next(50, playground.Height);
            hp.Location = new Point(hp_width, hp_height);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top+= speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
            }
            if (ball.Bottom >= hp.Top && ball.Bottom <= hp.Bottom && ball.Left >= hp.Left && ball.Right <= hp.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                menu.Visible = true;
            }

            scorepoints.Text = point.ToString();
            level.Text = (point / 5 + 1).ToString();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (menu.Visible)
            {
                if (e.KeyCode == Keys.Escape) { this.Close(); }
                if (e.KeyCode == Keys.F1) {
                    racket.Width = 150;
                    ball.Top = 16;
                    ball.Left = 16;
                    speed_left = 4;
                    speed_top = 4;
                    point = 0;
                    scorepoints.Text = "0";
                    timer1.Enabled = true;
                    menu.Visible = false;
                    int hp_width = new Random().Next(0, playground.Width);
                    int hp_height = new Random().Next(50, playground.Height);
                    hp.Location = new Point(hp_width, hp_height);
                }   
                if (e.KeyCode == Keys.F2) {
                    racket.Width = 600;
                    ball.Top = 16;
                    ball.Left = 16;
                    speed_left = 4;
                    speed_top = 4;
                    point = 0;
                    scorepoints.Text = "0";
                    timer1.Enabled = true;
                    menu.Visible = false;
                    int hp_width = new Random().Next(0, playground.Width);
                    int hp_height = new Random().Next(50, playground.Height);
                    hp.Location = new Point(hp_width, hp_height);
                }
                if (e.KeyCode == Keys.F3)
                {
                    racket.Width = 80;
                    ball.Top = 13;
                    ball.Left = 13;
                    speed_left = 8;
                    speed_top = 8;
                    point = 0;
                    scorepoints.Text = "0";
                    timer1.Enabled = true;
                    menu.Visible = false;
                    int hp_width = new Random().Next(0, playground.Width);
                    int hp_height = new Random().Next(50, playground.Height);
                    hp.Location = new Point(hp_width, hp_height);

                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    menu.Visible = true;
                }
                else if (!timer1.Enabled)
                {
                    timer1.Start();
                    menu.Visible = false;
                }
            }
        }
    }
}
