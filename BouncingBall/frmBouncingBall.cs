using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BouncingBall
{
    public partial class frmBouncingBalls : Form
    {
        public frmBouncingBalls()
        {
            InitializeComponent();

            Thread run = new Thread(new ThreadStart(Game));

            run.Start();
        }

        public void Game()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
