using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Ball : Shape
    {
        /// <summary>
        /// Creating an instance of a ball.
        /// </summary>
        /// <param name="xPosition">    The x position of the ball. Must be within border.</param>
        /// <param name="yPosition">    The y position of the ball. Must be within border.</param>
        /// <param name="size">         The size of the ball.</param>
        /// <param name="fillColour">   The fill colour of the ball.</param>
        /// <param name="xSpeed">       The speed of the ball in the x direction.</param>
        /// <param name="ySpeed">       The speed of the ball in the y direction.</param>
        /// <param name="outlineColour">The outline colour of the ball.</param>
        public Ball(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int size, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, size, size, outlineColour)
        { }

        /// <summary>
        /// Creating an instance of a ball.
        /// </summary>
        public Ball()
        {
        }

        #region Getters and Setters

        /// <summary>
        /// Property for the size of the ball.
        ///
        /// Obtains the size of this ball.
        /// Changes the current size of this ball to a given size.
        /// </summary>
        public float Size
        {
            get
            {
                return Height;
            }
            set
            {
                Height = value;
            }
        }

        #endregion Getters and Setters
    }
}