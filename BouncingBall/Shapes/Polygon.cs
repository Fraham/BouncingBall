using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    public class Polygon : Shape
    {
        public Polygon(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int height, int width, System.Drawing.Point[] points)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, height, width)
        { }

        public static float FindMinX(System.Drawing.Point[] points)
        {
            return 0;
        }

        public static float FindMinY(System.Drawing.Point[] points)
        {
            return 0;
        }

        public static float FindWidth(System.Drawing.Point[] points)
        {
            return 0;
        }

        public static float FindHeight(System.Drawing.Point[] points)
        {
            return 0;
        }
    }
}
