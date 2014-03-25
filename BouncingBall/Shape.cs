using System;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    ///     Used to model all the shapes that will be displayed.
    /// </summary>
    public class Shape
    {
        private string _colour;
        private int _xPosition;
        private int _xSpeed;
        private int _yPosition;
        private int _ySpeed;
        private int _width;
        private int _height;

        /// <summary>
        ///     Creating an instance of a shape.
        /// </summary>
        /// <param name="xPosition">The x position of the shape. Must be within border.</param>
        /// <param name="yPosition">The y position of the shape. Must be within border.</param>
        /// <param name="colour">The colour of the shape.</param>
        /// <param name="xSpeed">The speed of the shape in the x direction.</param>
        /// <param name="ySpeed">The speed of the shape in the y direction.</param>
        /// <param name="width">The width of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        public Shape(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int width, int height)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
            _colour = colour.ToUpper();
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
        }

        /// <summary>
        ///     Creating an instance of a shape.
        /// </summary>
        public Shape()
        {
            _xPosition = 0;
            _yPosition = 0;
            _colour = "WHITE";
            _xSpeed = 0;
            _ySpeed = 0;
            _width = 0;
            _height = 0;
        }

        #region Getters and Setters

        /// <summary>
        ///     Obtains the colour of this shape.
        ///     Returns a colour type instead of the text version.
        /// </summary>
        /// <returns>The colour of this shape.</returns>
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
                return Color.White;
            }
        }

        /// <summary>
        ///     Obtains the current X position of this shape.
        /// </summary>
        /// <returns> The X coordinate of this shape within the game.</returns>
        public int GetXPosition()
        {
            return _xPosition;
        }

        /// <summary>
        ///     Gets the x speed of the shape.
        /// </summary>
        /// <returns> The x speed of the shape.</returns>
        public int GetXSpeed()
        {
            return _xSpeed;
        }

        /// <summary>
        ///     Obtains the current Y position of this shape.
        /// </summary>
        /// <returns> The Y coordinate of this shape within the game.</returns>
        public int GetYPosition()
        {
            return _yPosition;
        }

        /// <summary>
        ///     Gets the x speed of the shape.
        /// </summary>
        /// <returns> The x speed of the shape.</returns>
        public int GetYSpeed()
        {
            return _ySpeed;
        }

        /// <summary>
        ///     Moves the current position of this shape to the given X co-ordinate.
        /// </summary>
        /// <param name="x"> The new x co-ordinate of this shape.</param>
        public void SetXPosition(int x)
        {
            _xPosition = x;
        }

        /// <summary>
        ///     Changes the current speed of this shape to the given X speed.
        /// </summary>
        /// <param name="x"> The new x speed of this shape.</param>
        public void SetXSpeed(int x)
        {
            _xSpeed = x;
        }

        /// <summary>
        ///     Moves the current position of this shape to the given Y co-ordinate.
        /// </summary>
        /// <param name="y"> The new y co-ordinate of this shape.</param>
        public void SetYPosition(int y)
        {
            _yPosition = y;
        }

        /// <summary>
        ///     Changes the current speed of this shape to the given y speed.
        /// </summary>
        /// <param name="y"> The new y speed of this shape.</param>
        public void SetYSpeed(int y)
        {
            _ySpeed = y;
        }

        /// <summary>
        ///     Changes the current colour of this shape to the given colour.
        /// </summary>
        /// <param name="colour">The colour being change to.</param>
        public void SetColour(String colour)
        {
            _colour = colour;
        }
        #endregion Getters and Setters

        /// <summary>
        ///     Moves the ball one unit depending on the x and y speed.
        ///     Makes sure the ball does not go outside the game area.
        /// </summary>
        /// <param name="gameHeight"> The height of the game.</param>
        /// <param name="gameWidth"> The width of the game.</param>
        public void Move(int gameHeight, int gameWidth)
        {
            if (_xPosition + _width > gameWidth || _xPosition - _width < 0)
            {
                _xSpeed = -_xSpeed;
            }

            if (_yPosition + _height > gameHeight || _yPosition - _height < 0)
            {
                _ySpeed = -_ySpeed;
            }

            _xPosition += _xSpeed;
            _yPosition += _ySpeed;
        }
    }
}
