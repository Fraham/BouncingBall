﻿using System;
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

        private frmBouncingBalls _displayForm;
        private float _height;
        private float _width;
        private bool down = false;
        private bool left = false;
        private bool right = false;
        private bool up = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="display"></param>
        public Game(float width, float height, frmBouncingBalls display)
        {
            Height = height;
            Width = width;

            _displayForm = display;

            AddEnemies();

            NewPlayer();

            Thread gameThread = new Thread(new ThreadStart(GameRunning));

            gameThread.IsBackground = true;

            gameThread.Start();
        }

        /// <summary>
        /// Gets or sets the height of the game area.
        /// </summary>
        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                this._height = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the game area.
        /// </summary>
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                this._width = value;
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
                enemies.Add(new Enemy(rand.Next((int)Width - maxSize), rand.Next((int)Height - maxSize), "GREEN", rand.Next(20), rand.Next(20), rand.Next(maxSize)));
            }
        }

        /// <summary>
        /// Draws all the balls for each game tick.
        /// </summary>
        private void DrawIt()
        {
            try
            {
                Bitmap buffer = new Bitmap((int)Width, (int)Height);

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
                        en.Move(Height, Width);
                    }

                    player.Move(Height, Width, this);

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

        /// <summary>
        /// Creates a new Player.
        /// </summary>
        private void NewPlayer()
        {
            player = new Player(10, 10, "PINK", 10, 10, 20, 20);
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