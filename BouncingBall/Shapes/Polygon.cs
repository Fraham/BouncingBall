using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Polygon : Shape
    {
        private System.Drawing.Point[] _points;

        /// <summary>
        /// Creating an instance of a polygon.
        /// </summary>
        /// <param name="xPosition">    The x position of the polygon. Must be within border.</param>
        /// <param name="yPosition">    The y position of the polygon. Must be within border.</param>
        /// <param name="height">       The height of the polygon.</param>
        /// <param name="width">        The width of the polygon.</param>
        /// <param name="fillColour">   The fill colour of the polygon.</param>
        /// <param name="xSpeed">       The speed of the polygon in the x direction.</param>
        /// <param name="ySpeed">       The speed of the polygon in the y direction.</param>
        /// <param name="points">       The points of the polygon.</param>
        /// <param name="outlineColour">The outline colour of the polygon.</param>
        public Polygon(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int height, int width, System.Drawing.Point[] points, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, height, width, outlineColour)
        {
            Points = points;
        }

        /// <summary>
        /// The points of the polygon.
        /// </summary>
        public System.Drawing.Point[] Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        #region Width and Height Methods

        /// <summary>
        /// Finds the height value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The height of the polygon.</returns>
        public static float FindHeight(System.Drawing.Point[] points)
        {
            return FindMaxX(points) - FindMinX(points);
        }

        /// <summary>
        /// Finds the minimum x value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The minimum x value.</returns>
        public static float FindMinX(System.Drawing.Point[] points)
        {
            float min = points[0].X;
            int length = points.Length;

            if (length == 1)
            {
                return min;
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (points[i].X < min)
                    {
                        min = points[i].X;
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the minimum y value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The minimum y value.</returns>
        public static float FindMinY(System.Drawing.Point[] points)
        {
            float min = points[0].Y;
            int length = points.Length;

            if (length == 1)
            {
                return min;
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (points[i].Y < min)
                    {
                        min = points[i].Y;
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the width value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The width of the polygon.</returns>
        public static float FindWidth(System.Drawing.Point[] points)
        {
            return FindMaxY(points) - FindMinY(points);
        }

        private static float FindMaxX(System.Drawing.Point[] points)
        {
            float max = points[0].X;
            int length = points.Length;

            if (length == 1)
            {
                return max;
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (points[i].X > max)
                    {
                        max = points[i].X;
                    }
                }
            }
            return max;
        }

        private static float FindMaxY(System.Drawing.Point[] points)
        {
            float max = points[0].Y;
            int length = points.Length;

            if (length == 1)
            {
                return max;
            }
            else
            {
                for (int i = 1; i < length; i++)
                {
                    if (points[i].Y > max)
                    {
                        max = points[i].Y;
                    }
                }
            }
            return max;
        }

        #endregion Width and Height Methods

        /// <summary>
        /// Moves the polygon one unit depending on the x and y speed. Makes sure the polygon does
        /// not go outside the game area.
        /// </summary>
        /// <param name="game">The game.</param>
        public void Move(Game game)
        {
            if (XPosition + Width + XSpeed > Game.Width || XPosition + XSpeed < 0)
            {
                XSpeed = -XSpeed;
            }

            if (YPosition + Height + YSpeed > Game.Height || YPosition + YSpeed < 0)
            {
                YSpeed = -YSpeed;
            }

            XPosition += XSpeed;
            YPosition += YSpeed;

            for (int i = 0; i < _points.Length; i++)
            {
                _points[i].X += (int)XSpeed;
                _points[i].Y += (int)YSpeed;
            }
        }
    }
}