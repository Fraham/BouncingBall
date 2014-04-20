using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmO = new frmOptions();

            frmO.ShowDialog();
        }
    }
}
