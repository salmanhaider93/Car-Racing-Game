using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
            over.Visible = false;
            newgame.Visible = false;
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carspeed);
            ememy(carspeed);
            gameover();
            coins(carspeed);
            coincollection();
        }



        int collectedcoin = 0;

        Random random = new Random();
        int x, y;
        void ememy(int speed)
        {
            if(ememy1.Top >= 500)
            {
                x = random.Next(0, 180);
                ememy1.Location = new Point(x, 0);
            }
            else { ememy1.Top += speed; }

            if (ememy2.Top >= 500)
            {
                x = random.Next(0, 400);
                ememy2.Location = new Point(x, 0);
            }
            else { ememy2.Top += speed; }


            if (ememy3.Top >= 500)
            {
                x = random.Next(180, 350);
                ememy3.Location = new Point(x, 0);
            }
            else { ememy3.Top += speed; }
        }//end ememy


        void coins(int speed)
        {
            if (Coin1.Top >= 500)
            {
                x = random.Next(0, 180);
                Coin1.Location = new Point(x, 0);
            }
            else { Coin1.Top += speed; }

            if (Coin2.Top >= 500)
            {
                x = random.Next(50, 300);
                Coin2.Location = new Point(x, 0);
            }
            else { Coin2.Top += speed; }

            if (Coin3.Top >= 500)
            {
                x = random.Next(0, 400);
                Coin3.Location = new Point(x, 0);
            }
            else { Coin3.Top += speed; }


        }//end coins

        void coincollection()
        {
            if (Player.Bounds.IntersectsWith(Coin1.Bounds))
            {
                collectedcoin++;
                coins_score.Text = "Coins=" + collectedcoin.ToString();

                Coin1.Location = new Point(x, 0);
            }
            if (Player.Bounds.IntersectsWith(Coin2.Bounds))
            {
                collectedcoin++;
                coins_score.Text = "Coins=" + collectedcoin.ToString();

                Coin2.Location = new Point(x, 0);
            }
            if (Player.Bounds.IntersectsWith(Coin3.Bounds))
            {
                collectedcoin++;
                coins_score.Text = "Coins=" + collectedcoin.ToString();

                Coin3.Location = new Point(x, 0);
            }

        }//end coincollection


        void gameover()
        {
            if(Player.Bounds.IntersectsWith(ememy1.Bounds))
            {
                timer1.Enabled = false; 
                over.Visible = true;
                newgame.Visible = true;
            }
            if (Player.Bounds.IntersectsWith(ememy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                newgame.Visible = true;
            }
            if (Player.Bounds.IntersectsWith(ememy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                newgame.Visible = true;
            }
        }//end gameover


        void moveline(int speed)
        {
            if (Line1.Top >= 500)
            { Line1.Top = 0; }
            else { Line1.Top += speed; }

            if (Line2.Top >= 500)
            { Line2.Top = 0; }
            else { Line2.Top += speed; }

            if (Line3.Top >= 500)
            { Line3.Top = 0; }
            else { Line3.Top += speed; }

            if (Line4.Top >= 500)
            { Line4.Top = 0; }
            else { Line4.Top += speed; }

        }//end moveline

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }



        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Player.Left += -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                Player.Left += 1;
            }
        }//end player_keydown

        int carspeed = 0;

        private void newgame_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (Player.Left > 0)
                        Player.Left += -7;
                    break;
                case Keys.Right:
                    if (Player.Right < 380)
                        Player.Left += 7;
                    break;

                case Keys.Up: 
                    if(carspeed < 8)
                        carspeed++ ;
                    break;
                case Keys.Down:
                    if(carspeed > 0)
                        carspeed--;
                    break;


            }
        }//end mainform_keydown


    }
}
