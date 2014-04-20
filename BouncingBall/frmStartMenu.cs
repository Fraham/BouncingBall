using System;
using System.Windows.Forms;

namespace BouncingBall
{
    /// <summary>
    /// The start menu for the game.
    /// </summary>
    public partial class frmStartMenu : Form
    {
        /// <summary>
        /// Makes a start menu.
        /// </summary>
        public frmStartMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the options menu.
        /// 
        /// If a game is playing it will close the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form form = null;
            foreach (Form OpenForms in Application.OpenForms)
            {
                if (OpenForms.Name == "frmBouncingBalls")
                {
                    form = OpenForms;
                }
            }

            if (form != null)
            {
                form.Close();
            }

            frmOptions frmO = new frmOptions();

            frmO.ShowDialog();
        }

        /// <summary>
        /// Opens a new game.
        /// 
        /// If a game is playing it will focus that game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Boolean found = false;

            foreach (Form OpenForms in Application.OpenForms)
            {
                if (OpenForms.Name == "frmBouncingBalls")
                {
                    found = true;
                    OpenForms.Focus();
                }
            }

            if (!found)
            {
                frmBouncingBalls frmBB = new frmBouncingBalls();

                frmBB.Show();
            }
        }
    }
}