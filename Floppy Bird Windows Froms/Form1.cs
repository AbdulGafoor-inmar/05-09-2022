using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floppy_Bird_Windows_Froms
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "score: " + score;
            if(pipeBottom.Left<-600)
            {
                pipeBottom.Left = 500;
                score++;
            }
            if(pipeTop.Left<-275)
            {
                pipeTop.Left = 500;
                score++;
            }
           /* if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
               flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if(score>5)
            {
                gravity = -8;
            }
            if(flappyBird.Top<-25)
            {
                endGame();
            }*/
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame() 
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
