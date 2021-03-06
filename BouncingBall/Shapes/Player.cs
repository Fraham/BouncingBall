﻿using System;

namespace BouncingBall
{
    /// <summary>
    /// An object used in the game.
    /// </summary>
    public class Player : BouncingBall.Rectangle
    {
        /// <summary>
        /// Creating an instance of a player.
        /// </summary>
        /// <param name="xPosition">    The x position of the player. Must be within border.</param>
        /// <param name="yPosition">    The y position of the player. Must be within border.</param>
        /// <param name="fillColour">   The fill colour of the player.</param>
        /// <param name="xSpeed">       The speed of the player in the x direction.</param>
        /// <param name="ySpeed">       The speed of the player in the y direction.</param>
        /// <param name="height">       The height of the player.</param>
        /// <param name="width">        The width of the player.</param>
        /// <param name="outlineColour">The outline colour of the player.</param>
        public Player(int xPosition, int yPosition, String fillColour, int xSpeed, int ySpeed, int height, int width, String outlineColour)
            : base(xPosition, yPosition, fillColour, xSpeed, ySpeed, height, width, outlineColour)
        { }

        /// <summary>
        /// Allows the player to move.
        /// </summary>
        /// <param name="game">      The game being played</param>
        public void Move(Game game)
        {
            if (game.Left)
            {
                if (XPosition - XSpeed > 0)
                {
                    XPosition += -XSpeed;
                }
                else
                {
                    XPosition = 0;
                }
            }
            if (game.Right)
            {
                if (XPosition + Width + XSpeed < Game.Width)
                {
                    XPosition += XSpeed;
                }
                else
                {
                    XPosition = Game.Width - Width;
                }
            }
            if (game.Up)
            {
                if (YPosition - YSpeed > 0)
                {
                    YPosition += -YSpeed;
                }
                else
                {
                    YPosition = 0;
                }
            }
            if (game.Down)
            {
                if (YPosition + Height + YSpeed < Game.Height)
                {
                    YPosition += YSpeed;
                }
                else
                {
                    YPosition = Game.Height - Height;
                }
            }
        }
    }
}