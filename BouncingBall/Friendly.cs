using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class Friendly : Rectangle
    {
        /// <summary>
        /// Creating an instance of a rectangle.
        /// </summary>
        /// <param name="xPosition">The x position of the rectangle. Must be within border.</param>
        /// <param name="yPosition">The y position of the rectangle. Must be within border.</param>
        /// <param name="height">   The height of the rectangle.</param>
        /// <param name="width">    The width of the rectangle.</param>
        /// <param name="colour">   The colour of the rectangle.</param>
        /// <param name="xSpeed">   The speed of the rectangle in the x direction.</param>
        /// <param name="ySpeed">   The speed of the rectangle in the y direction.</param>
        public Friendly(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int height, int width)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, height, width)
        { }

        /// <summary>
        /// Creating an instance of a rectangle.
        /// </summary>
        public Friendly()
        { }
    }
}
