using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2_POO_UI.Encapsulamiento.Modelo
{
    public partial class EncapsulamientoForm : Form
    {
        Cuenta cuenta = new Cuenta();
        public EncapsulamientoForm()
        {
            InitializeComponent();
        }

        private void EncapsulamientoForm_Load(object sender, EventArgs e)
        {

        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            cuenta.RealizarDeposito(double.Parse(cantidadTextBox.Text));


            cantidadTextBox.Text = string.Empty;
        }

        private void retitarButton_Click(object sender, EventArgs e)
        {
            cuenta.RealizarRetiro(double.Parse(cantidadTextBox.Text));


            cantidadTextBox.Text = string.Empty;
        }

        private void saldoButton_Click(object sender, EventArgs e)
        {
            cuenta.SaldoActual();

        }
    }
}
