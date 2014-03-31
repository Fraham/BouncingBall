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
        /// <param name="xPosition">The x position of the friendly. Must be within border.</param>
        /// <param name="yPosition">The y position of the friendly. Must be within border.</param>
        /// <param name="height">   The height of the friendly.</param>
        /// <param name="width">    The width of the friendly.</param>
        /// <param name="colour">   The colour of the friendly.</param>
        /// <param name="xSpeed">   The speed of the friendly in the x direction.</param>
        /// <param name="ySpeed">   The speed of the friendly in the y direction.</param>
        public Friendly(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int height, int width)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, height, width)
        { }

        /// <summary>
        /// Creating an instance of a friendly.
        /// </summary>
        public Friendly()
        { }
    }
}