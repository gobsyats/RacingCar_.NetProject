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
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameOver();
            moveCoins(gamespeed);
            coinCollection();
        }

        Random r = new Random();
        int x, y;
        void enemy(int speed){
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,200);
                
                enemy1.Location = new Point(x, y);
            }
            else { enemy1.Top += speed; }


            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 260);
                enemy2.Location = new Point(x, y);
            }
            else { enemy2.Top += speed; }


            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 260);
                enemy3.Location = new Point(x, y);
            }
            else { enemy3.Top += speed; }
        }

        void moveCoins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, y);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(50, 300);

                coin2.Location = new Point(x, y);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 300);

                coin3.Location = new Point(x, y);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 200);

                coin4.Location = new Point(x, y);
            }
            else { coin4.Top += speed; }



        }


        int collectedCoins = 0;
        void coinCollection()
        {
            if (pictureBox8.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins += 1;
                CoinsLabel.Text = "Coins="+collectedCoins;
                x = r.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }

            if (pictureBox8.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins += 1;
                CoinsLabel.Text = "Coins=" + collectedCoins;
                x = r.Next(0, 300);
                coin2.Location = new Point(x, 0);
            }


            if (pictureBox8.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins += 1;
                CoinsLabel.Text = "Coins=" + collectedCoins;
                x = r.Next(10, 200);
                coin3.Location = new Point(x, 0);
            }


            if (pictureBox8.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins += 1;
                CoinsLabel.Text = "Coins=" + collectedCoins;
                x = r.Next(50, 100);
                coin4.Location = new Point(x, 0);
            }


        }

        //If car hits other cars
        void gameOver()
        {
            if (pictureBox8.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (pictureBox8.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (pictureBox8.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else{
                pictureBox4.Top += speed;}

            if (pictureBox7.Top >= 500)
            { pictureBox7.Top = 0; }
            else
            {
                pictureBox7.Top += speed;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) 
            {
                if(pictureBox8.Left>10)
                    pictureBox8.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox8.Right<290)
                    pictureBox8.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }

        }
        }
    }
