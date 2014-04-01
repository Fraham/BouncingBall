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
            return 0;
        }

        /// <summary>
        /// Finds the minimum x value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The minimum x value.</returns>
        public static float FindMinX(System.Drawing.Point[] points)
        {
            return 0;
        }

        /// <summary>
        /// Finds the minimum y value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The minimum y value.</returns>
        public static float FindMinY(System.Drawing.Point[] points)
        {
            return 0;
        }

        /// <summary>
        /// Finds the width value to be needed in creating a polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <returns>The width of the polygon.</returns>
        public static float FindWidth(System.Drawing.Point[] points)
        {
            return 0;
        }
    }
}