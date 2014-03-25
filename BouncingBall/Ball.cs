using System;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    ///     An object used in
    /// </summary>
    public class Ball
    {
        private string _colour;
        private int _size;
        private int _xPosition;
        private int _xSpeed;
        private int _yPosition;
        private int _ySpeed;

        /// <summary>
        ///     Creating an instance of a ball.
        /// </summary>
        /// <param name="xPosition">The x position of the ball. Must be within border.</param>
        /// <param name="yPosition">The y position of the ball. Must be within border.</param>
        /// <param name="size">The size of the ball.</param>
        /// <param name="colour">The colour of the ball.</param>
        /// <param name="xSpeed">The speed of the ball in the x direction.</param>
        /// <param name="ySpeed">The speed of the ball in the y direction.</param>
        public Ball(int xPosition, int yPosition, int size, String colour, int xSpeed, int ySpeed)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
            _size = size;
            _colour = colour.ToUpper();
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
        }

        #region Getters and Setters

        /// <summary>
        ///     Obtains the colour of this ball.
        ///     Returns a colour type instead of the text version.
        /// </summary>
        /// <returns>The colour of this ball.</returns>
        public Color GetColour()
        {
            if (_colour == "BLACK")
            {
                return Color.Black;
            }
            if (_colour == "WHITE")
            {
                return Color.White;
            }
            if (_colour == "RED")
            {
                return Color.Red;
            }
            if (_colour == "GREEN")
            {
                return Color.Green;
            }
            try
            {
                return Color.FromName(_colour);
            }
            catch
            {
                return Color.Black;
            }
        }

        /// <summary>
        ///     Obtains the size of this ball.
        /// </summary>
        /// <returns> The diameter of this ball, in pixels.</returns>
        public int GetSize()
        {
            return _size;
        }

        /// <summary>
        ///     Obtains the current X position of this ball.
        /// </summary>
        /// <returns> The X coordinate of this Ball within the game.</returns>
        public int GetXPosition()
        {
            return _xPosition;
        }

        /// <summary>
        ///     Gets the x speed of the ball.
        /// </summary>
        /// <returns> The x speed of the ball.</returns>
        public int GetXSpeed()
        {
            return _xSpeed;
        }

        /// <summary>
        ///     Obtains the current Y position of this ball.
        /// </summary>
        /// <returns> The Y coordinate of this ball within the game.</returns>
        public int GetYPosition()
        {
            return _yPosition;
        }

        /// <summary>
        ///     Gets the x speed of the ball.
        /// </summary>
        /// <returns> The x speed of the ball.</returns>
        public int GetYSpeed()
        {
            return _ySpeed;
        }

        /// <summary>
        ///     Moves the current position of this Ball to the given X co-ordinate.
        /// </summary>
        /// <param name="x"> The new x co-ordinate of this ball.</param>
        public void SetXPosition(int x)
        {
            _xPosition = x;
        }

        /// <summary>
        ///     Changes the current speed of this Ball to the given X speed.
        /// </summary>
        /// <param name="x"> The new x speed of this ball.</param>
        public void SetXSpeed(int x)
        {
            _xSpeed = x;
        }

        /// <summary>
        ///     Moves the current position of this Ball to the given Y co-ordinate.
        /// </summary>
        /// <param name="y"> The new y co-ordinate of this ball.</param>
        public void SetYPosition(int y)
        {
            _yPosition = y;
        }

        /// <summary>
        ///     Changes the current speed of this Ball to the given y speed.
        /// </summary>
        /// <param name="y"> The new y speed of this ball.</param>
        public void SetYSpeed(int y)
        {
            _ySpeed = y;
        }

        /// <summary>
        ///     Changes the current colour of this ball to the given colour.
        /// </summary>
        /// <param name="colour">The colour being change to.</param>
        public void SetColour(String colour)
        {
            _colour = colour;
        }

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
            if (_xPosition + _size > width || _xPosition - _size < 0)
            {
                _xSpeed = -_xSpeed;
            }

            if (_yPosition + _size > height || _yPosition - _size < 0)
            {
                _ySpeed = -_ySpeed;
            }

            _xPosition += _xSpeed;
            _yPosition += _ySpeed;
        }
    }
}