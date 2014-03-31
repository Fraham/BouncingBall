using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BouncingBall
{
    /// <summary>
    /// The game class, used to show and run the game.
    /// </summary>
    public partial class frmBouncingBalls : Form
    {
        /// <summary>
        /// Holds the balls in the game.
        /// </summary>
        public List<Enemy> enemies = new List<Enemy>();

        /// <summary>
        /// Holds the player information in the same.
        /// </summary>
        public Player player;

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

            backgroundWorker1.RunWorkerAsync();

            AddEnemies();

            NewPlayer();
        }

        /// <summary>
        /// Makes all the balls used in the game.
        /// </summary>
        public void AddEnemies()
        {
            var rand = new Random();

            int maxSize = 40;

            for (int i = 0; i < 20; i++)
                enemies.Add(new Enemy(rand.Next(picGame.Width - maxSize), rand.Next(picGame.Height - maxSize), "GREEN", rand.Next(20), rand.Next(20), rand.Next(maxSize)));
        }

        /// <summary>
        /// Creates a new Player.
        /// </summary>
        public void NewPlayer()
        {
            player = new Player(10, 10, "PINK", 10, 10, 20, 20);
        }

        /// <summary>
        /// Removes a ball from the game.
        /// </summary>
        /// <param name="b">The ball to be removed.</param>
        public void removingBalls(Enemy en)
        {
            try
            {
                enemies.Remove(en);
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
        /// <param name="e">     </param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    foreach (Enemy en in enemies)
                    {
                        en.Move(picGame.Height, picGame.Width);
                    }

                    player.Move(picGame.Height, picGame.Width, this);

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
            try
            {
                Bitmap buffer = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(buffer))
                {
                    g.Clear(Color.Black);

                    foreach (Enemy en in enemies)
                    {
                        System.Drawing.Rectangle enemy = new System.Drawing.Rectangle((int)en.XPosition, (int)en.YPosition, (int)en.Size, (int)en.Size);

                        Brush brush = new SolidBrush(en.Colour);

                        g.FillEllipse(brush, enemy);
                    }

                    System.Drawing.Rectangle playerRec = new System.Drawing.Rectangle((int)player.XPosition, (int)player.YPosition, (int)player.Width, (int)player.Height);

                    Brush brushrec = new SolidBrush(player.Colour);

                    g.FillRectangle(brushrec, playerRec);

                    g.Dispose();
                }

                picGame.Image = buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                Console.WriteLine(ex.ToString());
            }
        }

        #region KeyEvents

        /// <summary>
        /// Returns true or false, if the down button is pressed or not.
        /// </summary>
        /// <returns>If pressed returns true, false otherwise</returns>
        public bool DownPressed()
        {
            return down;
        }

        /// <summary>
        /// Returns true or false, if the left button is pressed or not.
        /// </summary>
        /// <returns>If pressed returns true, false otherwise</returns>
        public bool LeftPressed()
        {
            return left;
        }

        /// <summary>
        /// Returns true or false, if the right button is pressed or not.
        /// </summary>
        /// <returns>If pressed returns true, false otherwise</returns>
        public bool RightPressed()
        {
            return right;
        }

        /// <summary>
        /// Returns true or false, if the up button is pressed or not.
        /// </summary>
        /// <returns>If pressed returns true, false otherwise</returns>
        public bool UpPressed()
        {
            return up;
        }

        /// <summary>
        /// Setting the current keys that are pressed to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
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
        /// <param name="e">     </param>
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
        #endregion KeyEvents
    }
}