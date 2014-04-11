using System;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    /// Used to model all the shapes that will be displayed.
    /// </summary>
    public class Shape
    {
        private string _fillColour;
        private float _height;
        private string _outlineColour;
        private float _width;
        private float _xPosition;
        private float _xSpeed;
        private float _yPosition;
        private float _ySpeed;

        /// <summary>
        /// Creating an instance of a shape.
        /// </summary>
        /// <param name="xPosition">    The x position of the shape. Must be within border.</param>
        /// <param name="yPosition">    The y position of the shape. Must be within border.</param>
        /// <param name="fillColour">   The fill colour of the shape.</param>
        /// <param name="xSpeed">       The speed of the shape in the x direction.</param>
        /// <param name="ySpeed">       The speed of the shape in the y direction.</param>
        /// <param name="width">        The width of the shape.</param>
        /// <param name="height">       The height of the shape.</param>
        /// <param name="outlineColour">The outline colour of the shape.</param>
        public Shape(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int width, int height, String outlineColour)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            XSpeed = xSpeed;
            YSpeed = ySpeed;
            Width = width;
            Height = height;

            _fillColour = fillColour.ToUpper();
            _outlineColour = outlineColour;
        }

        /// <summary>
        /// Creating an instance of a shape.
        /// </summary>
        public Shape()
        {
            XPosition = 10;
            YPosition = 10;
            XSpeed = 10;
            YSpeed = 10;
            Width = 10;
            Height = 10;

            _fillColour = "BLACK";
            _outlineColour = "White";
        }

        #region Getters and Setters

        /// <summary>
        /// Property for the colour of the shape. Obtains the colour of this shape. Returns a colour
        /// type instead of the text version. Sets the colour of the shape.
        /// </summary>
        public Color FillColour
        {
            get
            {
                if (_fillColour == "BLACK")
                {
                    return Color.Black;
                }
                if (_fillColour == "WHITE")
                {
                    return Color.White;
                }
                if (_fillColour == "RED")
                {
                    return Color.Red;
                }
                if (_fillColour == "GREEN")
                {
                    return Color.Green;
                }
                try
                {
                    return Color.FromName(_fillColour);
                }
                catch
                {
                    return Color.White;
                }
            }
            set
            {
                _fillColour = value.ToString();
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
                if (value < 0 || value > Game.Height)
                {
                    _height = 10;
                }
                else
                {
                    _height = value;
                }
            }
        }

        /// <summary>
        /// Property for the colour of the shape. Obtains the colour of this shape. Returns a colour
        /// type instead of the text version. Sets the colour of the shape.
        /// </summary>
        public Color OutlineColour
        {
            get
            {
                if (_outlineColour == "BLACK")
                {
                    return Color.Black;
                }
                if (_outlineColour == "WHITE")
                {
                    return Color.White;
                }
                if (_outlineColour == "RED")
                {
                    return Color.Red;
                }
                if (_outlineColour == "GREEN")
                {
                    return Color.Green;
                }
                try
                {
                    return Color.FromName(_outlineColour);
                }
                catch
                {
                    return Color.White;
                }
            }
            set
            {
                _outlineColour = value.ToString();
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
                if (value < 0 || value > Game.Width)
                {
                    _width = 10;
                }
                else
                {
                    _width = value;
                }
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
                if (value > Game.Width + Width)
                {
                    _xPosition = Game.Width - Width;
                }
                else if (value < 0)
                {
                    _xPosition = 0;
                }
                else
                {
                    _xPosition = value;
                }
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
                _xSpeed = value;
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
                if (value > Game.Height + Height)
                {
                    _yPosition = Game.Height - Height;
                }
                else if (value < 0)
                {
                    _yPosition = 0;
                }
                else
                {
                    _yPosition = value;
                }
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
                _ySpeed = value;
            }
        }

        #endregion Getters and Setters

        /// <summary>
        /// Moves the ball one unit depending on the x and y speed. Makes sure the ball does not go
        /// outside the game area.
        /// </summary>
        /// <param name="gameHeight">The height of the game.</param>
        /// <param name="gameWidth"> The width of the game.</param>
        public void Move(float gameWidth, float gameHeight)
        {
            if (XPosition + Width + XSpeed > gameWidth || XPosition + XSpeed < 0)
            {
                XSpeed = -XSpeed;
            }

            if (YPosition + Height + YSpeed > gameHeight || YPosition + YSpeed < 0)
            {
                YSpeed = -YSpeed;
            }

            XPosition += XSpeed;
            YPosition += YSpeed;
        }
    }
}