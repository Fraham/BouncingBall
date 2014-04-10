using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Friendly : Rectangle
    {
        /// <summary>
        /// Creating an instance of a friendly.
        /// </summary>
        /// <param name="xPosition">    The x position of the friendly. Must be within border.</param>
        /// <param name="yPosition">    The y position of the friendly. Must be within border.</param>
        /// <param name="height">       The height of the friendly.</param>
        /// <param name="width">        The width of the friendly.</param>
        /// <param name="fillColour">   The fill colour of the friendly.</param>
        /// <param name="xSpeed">       The speed of the friendly in the x direction.</param>
        /// <param name="ySpeed">       The speed of the friendly in the y direction.</param>
        /// <param name="outlineColour">The outline colour of the friendly.</param>
        public Friendly(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int height, int width, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, height, width, outlineColour)
        { }

        /// <summary>
        /// Creating an instance of a friendly.
        /// </summary>
        public Friendly()
        { }
    }
}