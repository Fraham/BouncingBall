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
    }
}
