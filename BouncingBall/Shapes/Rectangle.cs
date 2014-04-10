using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Creating an instance of a rectangle.
        /// </summary>
        /// <param name="xPosition">    The x position of the rectangle. Must be within border.</param>
        /// <param name="yPosition">    The y position of the rectangle. Must be within border.</param>
        /// <param name="height">       The height of the rectangle.</param>
        /// <param name="width">        The width of the rectangle.</param>
        /// <param name="fillColour">   The colour fill of the rectangle.</param>
        /// <param name="xSpeed">       The speed of the rectangle in the x direction.</param>
        /// <param name="ySpeed">       The speed of the rectangle in the y direction.</param>
        /// <param name="outlineColour">The outline colour of the rectangle.</param>
        public Rectangle(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int height, int width, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, height, width, outlineColour)
        { }

        /// <summary>
        /// Creating an instance of a rectangle.
        /// </summary>
        public Rectangle()
        { }
    }
}