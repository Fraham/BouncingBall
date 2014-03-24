using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class Ball
    {
        private int xPosition;
        private int yPosition;

        private int size;

        private string colour;

        private int xSpeed;
        private int ySpeed;

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

        /**
	    * Obtains the current X position of this Ball.
	    * @return the X coordinate of this Ball within the GameArena.
	    */
        public int getXPosition()
        {
            return xPosition;
        }

        /**
         * Obtains the current Y position of this Ball.
         * @return the Y coordinate of this Ball within the GameArena.
         */
        public int getYPosition()
        {
            return yPosition;
        }

        /**
         * Obtains the size of this Ball.
         * @return the diameter of this Ball,in pixels.
         */
        public int getSize()
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
        public void setXPosition(int x)
        {
            this.xPosition = x;
        }

        /**
         * Moves the current position of this Ball to the given Y co-ordinate
         * @param y the new y co-ordinate of this Ball
         */
        public void setYPosition(int y)
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
