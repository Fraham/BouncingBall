using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BouncingBall
{
    public partial class frmBouncingBalls : Form
    {
        private List<Ball> balls = new List<Ball>();

        private bool up = false;
        private bool down = false;
        private bool left = false;
        private bool right = false;

        public frmBouncingBalls()
        {
            InitializeComponent();

            Thread run = new Thread(new ThreadStart(Game));

            //run.Start();

            makingBalls();
            drawIt();
        }

        public void Game()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void makingBalls()
        {
            balls.Add(new Ball(100, 100, 20, "WHITE", 20, 20));
        }

        private void drawIt()
        {
            Console.WriteLine(balls[0].getXPosition());
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle ball = new System.Drawing.Rectangle(balls[0].getXPosition(), balls[0].getYPosition(), balls[0].getSize(), balls[0].getSize());
            graphics.DrawEllipse(System.Drawing.Pens.Black, ball);
        }
    }
}
