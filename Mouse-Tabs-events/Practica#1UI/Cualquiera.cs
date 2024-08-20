using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1UI
{
    public partial class rastreoMouse : Form
    {
        public rastreoMouse()
        {
            InitializeComponent();
        }

        private void wheelGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void downUpPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            downUpPictureBox.BackColor = Color.Beige;
        }

        private void downUpPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            downUpPictureBox.BackColor = Color.Transparent;
        }

        private void rastreoMouse_MouseMove(object sender, MouseEventArgs e)
        {
            ejeXLabel.Text = e.X.ToString();
            ejeYLabel.Text = e.Y.ToString();
        }

        private void rastreoMouse_MouseClick(object sender, MouseEventArgs e)
        {
            string buttonClicked = "";
            switch (e.Button)
            {
                case MouseButtons.Left:
                    buttonClicked = "Izquierdo";
                    break;
                case MouseButtons.Right:
                    buttonClicked = "Derecho";
                    break;
                case MouseButtons.Middle:
                    buttonClicked = "Central";
                    break;
            }
            wheelLabel.Text = buttonClicked;
        }
    }
}
