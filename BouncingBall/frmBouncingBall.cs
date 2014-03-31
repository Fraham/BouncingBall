using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BouncingBall
{
    /// <summary>
    /// The game class, used to show and run the game.
    /// </summary>
    public partial class frmBouncingBalls : Form
    {
        private Game GameRun;

        /// <summary>
        /// Initialise a new game.
        /// </summary>
        public frmBouncingBalls()
        {
            InitializeComponent();

            GameRun = new Game(picGame.Width, picGame.Height, this);
        }

        #region KeyEvents

        /// <summary>
        /// Setting the current keys that are pressed to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void frmBouncingBalls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                GameRun.Right = true;
            if (e.KeyCode == Keys.Up)
                GameRun.Up = true;
            if (e.KeyCode == Keys.Left)
                GameRun.Left = true;
            if (e.KeyCode == Keys.Down)
                GameRun.Down = true;
        }

        /// <summary>
        /// When the keys are not pressed anymore, set them to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">     </param>
        private void frmBouncingBalls_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                GameRun.Right = false;
            if (e.KeyCode == Keys.Up)
                GameRun.Up = false;
            if (e.KeyCode == Keys.Left)
                GameRun.Left = false;
            if (e.KeyCode == Keys.Down)
                GameRun.Down = false;
        }

        #endregion KeyEvents
    }
}