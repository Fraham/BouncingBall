using System;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    ///     An object used in
    /// </summary>
    public class Ball : Shape
    {
        private int _size;

        /// <summary>
        ///     Creating an instance of a ball.
        /// </summary>
        /// <param name="xPosition">The x position of the ball. Must be within border.</param>
        /// <param name="yPosition">The y position of the ball. Must be within border.</param>
        /// <param name="size">The size of the ball.</param>
        /// <param name="colour">The colour of the ball.</param>
        /// <param name="xSpeed">The speed of the ball in the x direction.</param>
        /// <param name="ySpeed">The speed of the ball in the y direction.</param>
        public Ball(int xPosition, int yPosition, int size, String colour, int xSpeed, int ySpeed) : base(xPosition, yPosition, colour, xSpeed, ySpeed)
        {
            _size = size;
        }

        #region Getters and Setters

        /// <summary>
        ///     Obtains the size of this ball.
        /// </summary>
        /// <returns> The diameter of this ball, in pixels.</returns>
        public int GetSize()
        {
            return _size;
        }

        /// <summary>
        ///     Changes the current size of this ball to a given size.
        /// </summary>
        /// <param name="size">The new size of the ball.</param>
        public void setSize(int size)
        {
            _size = size;
        }

        #endregion Getters and Setters

        /// <summary>
        ///     Moves the ball one unit depending on the x and y speed.
        ///     Makes sure the ball does not go outside the game area.
        /// </summary>
        /// <param name="height"> The height of the game.</param>
        /// <param name="width"> The width of the game.</param>
        public void Move(int height, int width)
        {
            if (base.GetXPosition() + _size > width || base.GetXPosition() - _size < 0)
            {
                base.SetXSpeed(-base.GetXSpeed());
            }

            if (base.GetYPosition() + _size > height || base.GetYPosition() - _size < 0)
            {
                base.SetYSpeed(-base.GetYSpeed());
            }

            base.SetXPosition(base.GetXPosition() + base.GetXSpeed());
            base.SetYPosition(base.GetYPosition() + base.GetYSpeed());
        }
    }
}