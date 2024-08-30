using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSystemData;


namespace Practica_3UI
{
    public partial class StudentSystem : Form
    {
        public StudentSystem()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            Student student = new Student();

            career.Name = CarreraTexBox.Text;
            student.FirstName = NombresTextBox.Text;
            student.LastName = ApellidosTextBox.Text;
            student.PhoneNumber = NombresTextBox.Text; 
            student.Career = career;

            EstudianteListBox.Items.Add(student);
            MessageBox.Show("Estudiante Registrado con Exito!! :)");
            LimpiarTextBox();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(EstudianteListBox.SelectedItem is Student selectedStudent)
            {
                EstudianteListBox.Items.Remove(selectedStudent);
                MessageBox.Show("Estudiante Eliminado!! :(");
            }
            else
            {
                MessageBox.Show("Posiblemente no hay estudiantes O \n No seleccionaste nada");
            }
        }
        public void LimpiarTextBox()
        {
            NombresTextBox.Clear();
            ApellidosTextBox.Clear();
            TelefonoTextBox.Clear();
            CarreraTexBox.Clear();
            NombresTextBox.Focus();
        }
    }
}
