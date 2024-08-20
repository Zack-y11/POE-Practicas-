namespace Practica_1UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        MessageBox.Show("Guardar accion realizada", "Informacion");
                        break;
                    case Keys.O:
                        MessageBox.Show("Abrir accion realizada", "Informacion");
                        break;
                }
            }
        }

        private void KeyPressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   //verificar si es letra
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                //convertir a mayuscula
            }
            else if (!char.IsControl(e.KeyChar))
            {   
                //sino se cumple cancelar el evento
                e.Handled = true;
            }
        }

        private void KeyDownTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("Se ha presionado Tab, mostrando la ayuda personalizada");
            }
        }
    }
}
