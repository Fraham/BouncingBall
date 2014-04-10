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
        /// <param name="fillColour">   The fill colour of the enemy.</param>
        /// <param name="xSpeed">   The speed of the enemy in the x direction.</param>
        /// <param name="ySpeed">   The speed of the enemy in the y direction.</param>
        public Enemy(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int size, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, size, outlineColour)
        { }

        /// <summary>
        /// Creating an instance of a enemy.
        /// </summary>
        public Enemy()
        {
        }

        /// <summary>
        /// If the enemy collides with the player.
        /// </summary>
        /// <param name="p">The player.</param>
        /// <returns></returns>
        public bool Collides(Player p)
        {
            return (XPosition < p.XPosition + p.Width &&
            XPosition + Width > p.XPosition &&
            YPosition < p.YPosition + p.Height &&
            YPosition + Height > p.YPosition);
        }

        /// <summary>
        /// Moves the ball one unit depending on the x and y speed. Makes sure the ball does not go
        /// outside the game area.
        /// </summary>
        /// <param name="gameHeight">The height of the game.</param>
        /// <param name="gameWidth"> The width of the game.</param>
        /// <param name="game">      The game.</param>
        public void Move(float gameWidth, float gameHeight, Game game)
        {
            if (XPosition + Width + XSpeed > gameWidth || XPosition + XSpeed < 0)
            {
                XSpeed = -XSpeed;
            }

            if (YPosition + Height + YSpeed > gameHeight || YPosition + XSpeed < 0)
            {
                YSpeed = -YSpeed;
            }

            XPosition += XSpeed;
            YPosition += YSpeed;

            if (Collides(game.player))
            {
                //remove enemy
            }
        }
    }
}