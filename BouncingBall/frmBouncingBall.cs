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

            addBalls();
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
        public void addBalls()
        {
            balls.Add(new Ball(100, 100, 20, "RED", 20, 20));
        }

        /// <summary>
        /// Removes a ball from the game.
        /// </summary>
        /// <param name="b">The ball to be removed.</param>
        public void removingBalls(Ball b)
        {
            try
            {
                balls.Remove(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to remove the ball", this.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Draws all the balls for each game tick.
        /// </summary>
        private void drawIt()
        {
            this.Refresh();
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

        /// <summary>
        /// Draws all the balls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBouncingBalls_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();

            Rectangle background = new Rectangle(0, 0, this.Width, this.Height);

            graphics.FillRectangle(new SolidBrush(Color.Black), background);

            foreach (Ball b in balls)
            {
                System.Drawing.Rectangle ball = new System.Drawing.Rectangle(b.getXPosition(), b.getYPosition(), b.getSize(), b.getSize());

                Brush brush = new SolidBrush(b.getColour());

                graphics.FillEllipse(brush, ball);
            }
        }
    }
}
