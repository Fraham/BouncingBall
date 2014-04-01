using System;

namespace BouncingBall
{
    public class Polygon : Shape
    {
        public Polygon(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int height, int width, System.Drawing.Point[] points)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, height, width)
        { }

        /// <summary>
        /// Finds the height value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The height of the polygon.</returns>
        public static float FindHeight(System.Drawing.Point[] points)
        {
            return FindMaxY(points) - FindMinY(points);
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

            if(length == 1)
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

        private static float FindMaxX(System.Drawing.Point[] points)
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

        /// <summary>
        /// Finds the width value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The width of the polygon.</returns>
        public static float FindWidth(System.Drawing.Point[] points)
        {
            return FindMaxX(points) - FindMinX(points);
        }
    }
}