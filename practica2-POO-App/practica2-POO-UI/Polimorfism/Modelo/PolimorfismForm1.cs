using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2_POO_UI.Polimorfism.Modelo
{
    public partial class PolimorfismForm1 : Form
    {
        private List<ComputadoraClass1> computadores;
        public PolimorfismForm1()
        {
            InitializeComponent();
            computadores = new List<ComputadoraClass1>
            {
                new ComputadoraClass1(),
                new ComputadoraPortatil(),
                new ComputadoraEscritorio()
            };
        }

        private void encenderButton_Click(object sender, EventArgs e)
        {
            foreach(ComputadoraClass1 computadora in computadores)
            {
                computadora.Encender();
            }
        }
    }
}
