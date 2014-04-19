using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BouncingBall
{
    /// <summary>
    /// Controls the actions in the game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Holds the enemies in the game.
        /// </summary>
        public List<Enemy> enemies = new List<Enemy>();

        /// <summary>
        /// Holds the player information in the same.
        /// </summary>
        public Player player;

        /// <summary>
        /// Holds the polygons in the game.
        /// </summary>
        public List<Polygon> polygons = new List<Polygon>();

        private static float _height;
        private static float _width;
        private frmBouncingBalls _displayForm;
        private bool down = false;
        private bool left = false;
        private bool right = false;
        private bool up = false;

        /// <summary>
        /// Creates a new instance of the game class.
        /// </summary>
        /// <param name="width">  The width of the game.</param>
        /// <param name="height"> The height of the game.</param>
        /// <param name="display">The form the game is displayed on.</param>
        public Game(float width, float height, frmBouncingBalls display)
        {
            Height = height;
            Width = width;

            _displayForm = display;

            AddEnemies();

            AddPlayer();

            AddPolygons();

            Thread gameThread = new Thread(new ThreadStart(GameRunning));

            gameThread.IsBackground = true;

            gameThread.Start();
        }

        /// <summary>
        /// Gets or sets the height of the game area.
        /// </summary>
        public static float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the game area.
        /// </summary>
        public static float Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        /// <summary>
        /// Removes a enemy from the game.
        /// </summary>
        /// <param name="en">The enemy to be removed.</param>
        public void RemovingEnemy(Enemy en)
        {
            try
            {
                enemies.Remove(en);
            }
            catch
            {
                MessageBox.Show("Unable to remove the enemy", _displayForm.Text + " - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Makes all the balls used in the game.
        /// </summary>
        private void AddEnemies()
        {
            var rand = new Random();

            int maxSize = 40;

            for (int i = 0; i < 20; i++)
            {
                enemies.Add(new Enemy(rand.Next((int)Width - maxSize), rand.Next((int)Height - maxSize), "DARKRED", rand.Next(20), rand.Next(20), rand.Next(maxSize), "RED"));
            }
        }

        /// <summary>
        /// Creates a new Player.
        /// </summary>
        private void AddPlayer()
        {
            player = new Player(10, 10, "DARKGREEN", 10, 10, 20, 20, "GREEN");
        }

        /// <summary>
        /// Makes all the polygons used in the game.
        /// </summary>
        private void AddPolygons()
        {
            List<Point> points = new List<Point>();

            points.Add(new Point(1, 1));
            points.Add(new Point(1, 10));
            points.Add(new Point(20, 10));
            points.Add(new Point(25, 1));

            polygons.Add(new Polygon((int)Polygon.FindMinX(points.ToArray()), (int)Polygon.FindMinY(points.ToArray()), "LIGHTYELLOW", 10, 10, (int)Polygon.FindHeight(points.ToArray()), (int)Polygon.FindWidth(points.ToArray()), points.ToArray(), "YElLOW"));
        }

        /// <summary>
        /// Draws all the balls for each game tick.
        /// </summary>
        private void DrawIt()
        {
            try
            {
                Bitmap buffer = new Bitmap((int)Width, (int)Height);

                int outlineWidth = 2;

                using (Graphics g = Graphics.FromImage(buffer))
                {
                    g.Clear(Color.Black);

                    #region Drawing Enemy

                    foreach (Enemy en in enemies)
                    {
                        System.Drawing.Rectangle enemy = new System.Drawing.Rectangle((int)en.XPosition, (int)en.YPosition, (int)en.Size, (int)en.Size);

                        Brush brush = new SolidBrush(en.FillColour);

                        g.FillEllipse(brush, enemy);

                        Pen pen = new Pen(en.OutlineColour, outlineWidth);

                        g.DrawEllipse(pen, enemy);
                    }

                    #endregion Drawing Enemy

                    #region Drawing Player

                    System.Drawing.Rectangle playerRec = new System.Drawing.Rectangle((int)player.XPosition, (int)player.YPosition, (int)player.Width, (int)player.Height);

                    Brush brushrec = new SolidBrush(player.FillColour);

                    g.FillRectangle(brushrec, playerRec);

                    Pen penRec = new Pen(player.OutlineColour, outlineWidth);

                    g.DrawRectangle(penRec, playerRec);

                    #endregion Drawing Player

                    #region Drawing Polygon

                    foreach (Polygon poly in polygons)
                    {
                        Brush brush = new SolidBrush(poly.FillColour);

                        g.FillPolygon(brush, poly.Points);

                        Pen pen = new Pen(poly.OutlineColour, outlineWidth);

                        g.DrawPolygon(pen, poly.Points);
                    }

                    #endregion Drawing Polygon
                }

                _displayForm.picGame.Image = buffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error - why");
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Runs the game.
        /// </summary>
        private void GameRunning()
        {
            try
            {
                while (true)
                {
                    foreach (Enemy en in enemies)
                    {
                        en.Move(Width, Height, this);
                    }

                    foreach (Polygon poly in polygons)
                    {
                        poly.Move(Width, Height, this);
                    }

                    player.Move(Width, Height, this);

                    Thread drawThread = new Thread(new ThreadStart(DrawIt));

                    drawThread.IsBackground = true;

                    drawThread.Start();

                    Thread.Sleep(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error- fucking hell");
                Console.WriteLine(ex.ToString());
            }
        }

        #region KeyEvents

        /// <summary>
        /// Gets or sets if the down button is pressed.
        /// </summary>
        public bool Down
        {
            get
            {
                return down;
            }
            set
            {
                down = value;
            }
        }

        /// <summary>
        /// Gets or sets if the left button is pressed.
        /// </summary>
        public bool Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        /// <summary>
        /// Gets or sets if the right button is pressed.
        /// </summary>
        public bool Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        /// <summary>
        /// Gets or sets if the up button is pressed.
        /// </summary>
        public bool Up
        {
            get
            {
                return up;
            }
            set
            {
                up = value;
            }
        }

        #endregion KeyEvents
    }
}