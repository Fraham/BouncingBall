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
    /// <summary>
    ///  The game class, used to show and run the game.
    /// </summary>
    public partial class frmBouncingBalls : Form
    {
        private List<Ball> balls = new List<Ball>();

        private bool up = false;
        private bool down = false;
        private bool left = false;
        private bool right = false;

        /// <summary>
        /// Instialise a new game.
        /// </summary>
        public frmBouncingBalls()
        {
            InitializeComponent();

            Thread run = new Thread(new ThreadStart(Game));

            //run.Start();

            makingBalls();
            drawIt();
        }

        /// <summary>
        /// Keeps the game running.
        /// </summary>
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

        /// <summary>
        /// Makes all the balls used in the game.
        /// </summary>
        public void makingBalls()
        {
            balls.Add(new Ball(100, 100, 20, "WHITE", 20, 20));
        }

        /// <summary>
        /// Draws all the balls for each game tick.
        /// </summary>
        private void drawIt()
        {
            Console.WriteLine(balls[0].getXPosition());
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle ball = new System.Drawing.Rectangle(balls[0].getXPosition(), balls[0].getYPosition(), balls[0].getSize(), balls[0].getSize());
            graphics.DrawEllipse(System.Drawing.Pens.Black, ball);
        }

        /// <summary>
        /// Setting the current keys that are pressed to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBouncingBalls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Down)
                down = true;
        }

        /// <summary>
        /// When the keys are not pressed anymore, set them to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBouncingBalls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Down)
                down = false;
        }
    }
}
