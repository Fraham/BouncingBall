using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Enemy : Ball
    {
        /// <summary>
        /// Creating an instance of a enemy.
        /// </summary>
        /// <param name="xPosition">The x position of the enemy. Must be within border.</param>
        /// <param name="yPosition">The y position of the enemy. Must be within border.</param>
        /// <param name="size">     The size of the enemy.</param>
        /// <param name="colour">   The colour of the enemy.</param>
        /// <param name="xSpeed">   The speed of the enemy in the x direction.</param>
        /// <param name="ySpeed">   The speed of the enemy in the y direction.</param>
        public Enemy(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int size)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, size)
        { }

        /// <summary>
        /// Creating an instance of a enemy.
        /// </summary>
        public Enemy()
        {
        }
    }
}