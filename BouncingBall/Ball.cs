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
        /// <param name="xPosition">The x position of the ball. Must be within border.</param>
        /// <param name="yPosition">The y position of the ball. Must be within border.</param>
        /// <param name="size">     The size of the ball.</param>
        /// <param name="colour">   The colour of the ball.</param>
        /// <param name="xSpeed">   The speed of the ball in the x direction.</param>
        /// <param name="ySpeed">   The speed of the ball in the y direction.</param>
        public Ball(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int size)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, size, size)
        { }

        #region Getters and Setters

        /// <summary>
        /// Obtains the size of this ball.
        /// </summary>
        /// <returns>The diameter of this ball, in pixels.</returns>
        public float GetSize()
        {
            return Height;
        }

        /// <summary>
        /// Changes the current size of this ball to a given size.
        /// </summary>
        /// <param name="size">The new size of the ball.</param>
        public void SetSize(int size)
        {
            Height = size;
        }

        #endregion Getters and Setters
    }
}