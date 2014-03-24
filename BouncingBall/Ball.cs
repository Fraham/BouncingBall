using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class Ball
    {
        private double xPosition;
        private double yPosition;

        private double size;

        private string colour;

        private double xSpeed;
        private double ySpeed;

        public Ball(double _xPosition, double _yPosition, double _size, String _colour, double _xSpeed, double _ySpeed)
        {
            xPosition = _xPosition;
            yPosition = _yPosition;
            size = _size;
            colour = _colour.ToUpper();
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        #region Getters and Setters

        /**
	    * Obtains the current X position of this Ball.
	    * @return the X coordinate of this Ball within the GameArena.
	    */
        public double getXPosition()
        {
            return xPosition;
        }

        /**
         * Obtains the current Y position of this Ball.
         * @return the Y coordinate of this Ball within the GameArena.
         */
        public double getYPosition()
        {
            return yPosition;
        }

        /**
         * Obtains the size of this Ball.
         * @return the diameter of this Ball,in pixels.
         */
        public double getSize()
        {
            return size;
        }

        /**
         * Obtains the colour of this Ball.
         * @return a textual description of the colour of this Ball.
         */
        public String getColour()
        {
            return colour;
        }

        /**
         * Moves the current position of this Ball to the given X co-ordinate
         * @param x the new x co-ordinate of this Ball
         */
        public void setXPosition(double x)
        {
            this.xPosition = x;
        }

        /**
         * Moves the current position of this Ball to the given Y co-ordinate
         * @param y the new y co-ordinate of this Ball
         */
        public void setYPosition(double y)
        {
            this.yPosition = y;
        }
        #endregion

        public void move(int height, int width)
        {
            if (xPosition + size > width || xPosition < 0)
            {
                xSpeed = -xSpeed;
            }

            if (yPosition + size > height || yPosition < 0)
            {
                ySpeed = -ySpeed;
            }

            xPosition += xSpeed;
            yPosition += ySpeed;
        }
    }
}
