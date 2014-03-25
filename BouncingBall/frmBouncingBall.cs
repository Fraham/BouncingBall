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
using System.Runtime.CompilerServices;

namespace BouncingBall
{
    /// <summary>
    ///  The game class, used to show and run the game.
    /// </summary>
    public partial class frmBouncingBalls : Form
    {
        private List<Ball> balls = new List<Ball>();

        private bool down = false;
        private bool left = false;
        private bool right = false;
        private bool up = false;
        /// <summary>
        /// Initialise a new game.
        /// </summary>
        public frmBouncingBalls()
        {
            InitializeComponent();

            //Thread run = new Thread(new ThreadStart(Game));

            backgroundWorker1.RunWorkerAsync();

            addBalls();

            //run.Start();            
        }

        /// <summary>
        /// Makes all the balls used in the game.
        /// </summary>
        public void addBalls()
        {
            balls.Add(new Ball(100, 100, 20, "RED", 20, 20));
            balls.Add(new Ball(50, 50, 20, "BLUE", 20, 20));
        }

        /// <summary>
        /// Keeps the game running.
        /// </summary>
        public void Game()
        {
            
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
            catch
            {
                MessageBox.Show("Unable to remove the ball", this.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Keeps the thread going throughout the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    foreach (Ball b in balls)
                    {
                        b.move(this.Height, this.Width);
                    }

                    drawIt();

                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Draws all the balls for each game tick.
        /// </summary>
        private void drawIt()
        {
            Bitmap buffer = new Bitmap(this.Width, this.Height);

            using (Graphics g = Graphics.FromImage(buffer))
            {
                g.Clear(Color.Black);

                foreach (Ball b in balls)
                {
                    System.Drawing.Rectangle ball = new System.Drawing.Rectangle(b.getXPosition(), b.getYPosition(), b.getSize(), b.getSize());

                    Brush brush = new SolidBrush(b.getColour());

                    g.FillEllipse(brush, ball);
                }

                g.Dispose();
            }

            picGame.Image = buffer;
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
