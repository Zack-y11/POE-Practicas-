using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_POO_UI.Encapsulamiento.Modelo
{
    public class Cuenta
    {
        private double saldo; //this is an attribute and private, and we when can't change with methods.

        //encapsulamiento
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Methods:
        private void Depositar (double monto)
        {
            Saldo += monto;
            MessageBox.Show("Deposito realizado con exito");
        }

        private void Retirar(double monto)
        {
            if(monto <= saldo)
            {
                saldo -= monto;
                MessageBox.Show("Retiro realizado con exito");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        public void RealizarDeposito(double monto)
        {
            Depositar(monto);
        }
        public void RealizarRetiro(double monto)
        {
            Retirar(monto);
        }
        public void SaldoActual()
        {
            MessageBox.Show($"La cantidad de saldo en su cuenta es ${Saldo}");
        }

    }
    
}
