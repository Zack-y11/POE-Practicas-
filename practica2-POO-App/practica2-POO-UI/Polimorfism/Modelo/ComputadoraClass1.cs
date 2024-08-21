using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_POO_UI.Polimorfism.Modelo
{
    public class ComputadoraClass1
    {
        public virtual void Encender()
        {
            MessageBox.Show("Encendiendo computadora...");
        }
    }

    public class ComputadoraPortatil : ComputadoraClass1
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora portatil...");
        }
    }

    public class ComputadoraEscritorio : ComputadoraClass1
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora de Escritorio...");
        }
    }
}
