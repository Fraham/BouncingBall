using System;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    /// Used to model all the shapes that will be displayed.
    /// </summary>
    public class Shape
    {
        private string _colour;
        private float _height;
        private float _width;
        private float _xPosition;
        private float _xSpeed;
        private float _yPosition;
        private float _ySpeed;

        /// <summary>
        /// Creating an instance of a shape.
        /// </summary>
        /// <param name="xPosition">The x position of the shape. Must be within border.</param>
        /// <param name="yPosition">The y position of the shape. Must be within border.</param>
        /// <param name="colour">   The colour of the shape.</param>
        /// <param name="xSpeed">   The speed of the shape in the x direction.</param>
        /// <param name="ySpeed">   The speed of the shape in the y direction.</param>
        /// <param name="width">    The width of the shape.</param>
        /// <param name="height">   The height of the shape.</param>
        public Shape(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int width, int height)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
            _colour = colour.ToUpper();
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Creating an instance of a shape.
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
        /// Property for the colour of the shape.
        ///
        /// Obtains the colour of this shape. Returns a colour type instead of the text version.
        /// Sets the colour
        /// </summary>
        public Color Colour
        {
            get
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
            set
            {
                _colour = value.ToString();
            }
        }

        /// <summary>
        /// Property for the height of the shape.
        ///
        /// Obtains the current height of this shape.
        /// Changes the current height of this shape to the given height.
        /// </summary>
        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                this._height = value;
            }
        }

        /// <summary>
        /// Property for the width of the shape.
        ///
        /// Obtains the current width of this shape.
        /// Changes the current width of this shape to the given width.
        /// </summary>
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                this._width = value;
            }
        }

        /// <summary>
        /// Property for the X position of the shape.
        ///
        /// Obtains the current X position of this shape.
        /// Changes the current X position of this shape to the given position.
        /// </summary>
        public float XPosition
        {
            get
            {
                return _xPosition;
            }
            set
            {
                this._xPosition = value;
            }
        }

        /// <summary>
        /// Property for the X speed of the shape.
        ///
        /// Obtains the current X speed of this shape.
        /// Changes the current X speed of this shape to the given speed.
        /// </summary>
        public float XSpeed
        {
            get
            {
                return _xSpeed;
            }
            set
            {
                this._xSpeed = value;
            }
        }

        /// <summary>
        /// Property for the Y position of the shape.
        ///
        /// Obtains the current Y position of this shape.
        /// Changes the current Y position of this shape to the given position.
        /// </summary>
        public float YPosition
        {
            get
            {
                return _yPosition;
            }
            set
            {
                this._yPosition = value;
            }
        }

        /// <summary>
        /// Property for the Y speed of the shape.
        ///
        /// Obtains the current Y speed of this shape.
        /// Changes the current Y speed of this shape to the given speed.
        /// </summary>
        public float YSpeed
        {
            get
            {
                return _ySpeed;
            }
            set
            {
                this._ySpeed = value;
            }
        }

        #endregion Getters and Setters

        /// <summary>
        /// Moves the ball one unit depending on the x and y speed. Makes sure the ball does not go
        /// outside the game area.
        /// </summary>
        /// <param name="gameHeight">The height of the game.</param>
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