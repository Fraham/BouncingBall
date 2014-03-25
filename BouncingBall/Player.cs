using System;

namespace BouncingBall
{
    internal class Player : BouncingBall.Rectangle
    {
        /// <summary>
        /// Creating an instance of a player.
        /// </summary>
        /// <param name="xPosition">The x position of the player. Must be within border.</param>
        /// <param name="yPosition">The y position of the player. Must be within border.</param>
        /// <param name="colour">   The colour of the player.</param>
        /// <param name="xSpeed">   The speed of the player in the x direction.</param>
        /// <param name="ySpeed">   The speed of the player in the y direction.</param>
        /// <param name="height">   The height of the player.</param>
        /// <param name="width">    The width of the player.</param>
        public Player(int xPosition, int yPosition, String colour, int xSpeed, int ySpeed, int height, int width)
            : base(xPosition, yPosition, colour, xSpeed, ySpeed, height, width)
        { }

        /// <summary>
        /// Allows the player to move.
        /// </summary>
        /// <param name="gameWidth"> The width of the game.</param>
        /// <param name="gameHeight">The height of the game.</param>
        /// <param name="game">      The game being played</param>
        public void Move(int gameWidth, int gameHeight, frmBouncingBalls game)
        {
            int xChange = 0;
            int yChange = 0;

            if (game.LeftPressed())
            {
                if (GetXPosition() > 0)
                {
                    xChange = -GetXSpeed();
                }
            }
            if (game.RightPressed())
            {
                if (GetXPosition() < gameWidth - GetWidth())
                {
                    xChange = GetXSpeed();
                }
            }
            if (game.UpPressed())
            {
                if (GetYPosition() > 0)
                {
                    yChange = -GetYSpeed();
                }
            }
            if (game.DownPressed())
            {
                if (GetYPosition() < gameHeight - GetHeight())
                {
                    yChange = GetYSpeed();
                }
            }

            SetXPosition(GetXPosition() + xChange);
            SetYPosition(GetYPosition() + yChange);
        }
    }
}