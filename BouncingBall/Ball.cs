using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BouncingBall
{
    /// <summary>
    /// An object used in 
    /// </summary>
    public class Ball
    {
        private int xPosition;
        private int yPosition;

        private int size;

        private string colour;

        private int xSpeed;
        private int ySpeed;


        /// <summary> 
        /// Creating an instance of a ball.
        /// </summary> 
        /// <param name="_xPosition">The x position of the ball. Must be within border.</param>
        /// <param name="_yPosition">The y position of the ball. Must be within border.</param>
        /// <param name="_size">The size of the ball.</param>
        /// <param name="_colour">The colour of the ball.</param>
        /// <param name="_xSpeed">The speed of the ball in the x direction.</param>
        /// <param name="_ySpeed">The speed of the ball in the y direction.</param>
        public Ball(int _xPosition, int _yPosition, int _size, String _colour, int _xSpeed, int _ySpeed)
        {
            xPosition = _xPosition;
            yPosition = _yPosition;
            size = _size;
            colour = _colour.ToUpper();
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        #region Getters and Setters

        /// <summary> 
        /// Obtains the current X position of this ball.        
        /// </summary>
        /// <returns> The X coordinate of this Ball within the game.</returns>
        public int getXPosition()
        {
            return xPosition;
        }

        /// <summary> 
        /// Obtains the current Y position of this ball.        
        /// </summary>
        /// <returns> The Y coordinate of this ball within the game.</returns>
        public int getYPosition()
        {
            return yPosition;
        }

        /// <summary> 
        /// Obtains the size of this ball.        
        /// </summary>
        /// <returns> The diameter of this ball, in pixels.</returns>
        public int getSize()
        {
            return size;
        }

        /// <summary> 
        /// Obtains the colour of this ball.
        /// 
        /// Returns a colour type instead of the text version.
        /// </summary>
        /// <returns> The colour of this ball.</returns>
        public Color getColour()
        {
            if (colour == "BLACK")
            {
                return Color.Black;
            }
            else if (colour == "WHITE")
            {
                return Color.White;
            }
            else if (colour == "RED")
            {
                return Color.Red;
            }
            else if (colour == "GREEN")
            {
                return Color.Green;
            }
            else
            {
                try
                {
                    return Color.FromName(colour);
                }
                catch
                {
                    return Color.Black;
                }
            }
            
        }

        /// <summary> 
        /// Moves the current position of this Ball to the given X co-ordinate.
        /// </summary>
        /// <param name = "x"> The new x co-ordinate of this ball.</param>
        public void setXPosition(int x)
        {
            this.xPosition = x;
        }

        /// <summary> 
        /// Moves the current position of this Ball to the given Y co-ordinate.      
        /// </summary>
        /// <param name = "y"> The new y co-ordinate of this ball.</param>
        public void setYPosition(int y)
        {
            this.yPosition = y;
        }

        /// <summary> 
        /// Changes the current speed of this Ball to the given X speed.
        /// </summary>
        /// <param name = "x"> The new x speed of this ball.</param>
        public void setXSpeed(int x)
        {
            this.xSpeed = x;
        }

        /// <summary> 
        /// Changes the current speed of this Ball to the given y speed.
        /// </summary>
        /// <param name = "y"> The new y speed of this ball.</param>
        public void setYSpeed(int y)
        {
            this.ySpeed = y;
        }

        /// <summary>
        /// Gets the x speed of the ball.
        /// </summary>
        /// <returns> The x speed of the ball.</returns>
        public int getXSpeed()
        {
            return xSpeed;
        }

        /// <summary>
        /// Gets the x speed of the ball.
        /// </summary>
        /// <returns> The x speed of the ball.</returns>
        public int getYSpeed()
        {
            return ySpeed;
        }
        #endregion

        /// <summary> 
        /// Moves the ball one unit depending on the x and y speed.
        /// Makes sure the ball does not go outside the game area.
        /// </summary>
        /// <param name = "height"> The height of the game.</param>
        /// <param name = "width"> The width of the game.</param>
        public void move(int height, int width)
        {
            if (xPosition + size > width || xPosition - size < 0)
            {
                xSpeed = -xSpeed;
            }

            if (yPosition + size > height || yPosition - size < 0)
            {
                ySpeed = -ySpeed;
            }

            xPosition += xSpeed;
            yPosition += ySpeed;
        }
    }
}
