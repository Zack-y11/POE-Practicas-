namespace Practica_3UI
{
    partial class StudentSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NombreLabel = new Label();
            NombresTextBox = new TextBox();
            label2 = new Label();
            ApellidosTextBox = new TextBox();
            ApellidosLabel = new Label();
            TelefonoTextBox = new TextBox();
            TelefonoLabel = new Label();
            CarreraTexBox = new TextBox();
            CarreraLabel = new Label();
            AgregarButton = new Button();
            EliminarButton = new Button();
            EstudianteListBox = new ListBox();
            SuspendLayout();
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(126, 50);
            NombreLabel.Margin = new Padding(4, 0, 4, 0);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(138, 21);
            NombreLabel.TabIndex = 0;
            NombreLabel.Text = "Nombre Alumno";
            // 
            // NombresTextBox
            // 
            NombresTextBox.Location = new Point(357, 42);
            NombresTextBox.Margin = new Padding(4);
            NombresTextBox.Name = "NombresTextBox";
            NombresTextBox.Size = new Size(332, 29);
            NombresTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 2;
            label2.Text = "Registro de Alumnos";
            // 
            // ApellidosTextBox
            // 
            ApellidosTextBox.Location = new Point(357, 91);
            ApellidosTextBox.Margin = new Padding(4);
            ApellidosTextBox.Name = "ApellidosTextBox";
            ApellidosTextBox.Size = new Size(332, 29);
            ApellidosTextBox.TabIndex = 4;
            // 
            // ApellidosLabel
            // 
            ApellidosLabel.AutoSize = true;
            ApellidosLabel.Location = new Point(126, 94);
            ApellidosLabel.Margin = new Padding(4, 0, 4, 0);
            ApellidosLabel.Name = "ApellidosLabel";
            ApellidosLabel.Size = new Size(147, 21);
            ApellidosLabel.TabIndex = 3;
            ApellidosLabel.Text = "Apellidos Alumno";
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(357, 132);
            TelefonoTextBox.Margin = new Padding(4);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(332, 29);
            TelefonoTextBox.TabIndex = 6;
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.Location = new Point(126, 140);
            TelefonoLabel.Margin = new Padding(4, 0, 4, 0);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new Size(142, 21);
            TelefonoLabel.TabIndex = 5;
            TelefonoLabel.Text = "Telefono Alumno";
            // 
            // CarreraTexBox
            // 
            CarreraTexBox.Location = new Point(357, 182);
            CarreraTexBox.Margin = new Padding(4);
            CarreraTexBox.Name = "CarreraTexBox";
            CarreraTexBox.Size = new Size(332, 29);
            CarreraTexBox.TabIndex = 8;
            // 
            // CarreraLabel
            // 
            CarreraLabel.AutoSize = true;
            CarreraLabel.Location = new Point(126, 190);
            CarreraLabel.Margin = new Padding(4, 0, 4, 0);
            CarreraLabel.Name = "CarreraLabel";
            CarreraLabel.Size = new Size(130, 21);
            CarreraLabel.TabIndex = 7;
            CarreraLabel.Text = "Carrera Alumno";
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(178, 238);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(169, 38);
            AgregarButton.TabIndex = 9;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // EliminarButton
            // 
            EliminarButton.Location = new Point(404, 238);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(169, 38);
            EliminarButton.TabIndex = 10;
            EliminarButton.Text = "Eliminar";
            EliminarButton.UseVisualStyleBackColor = true;
            EliminarButton.Click += EliminarButton_Click;
            // 
            // EstudianteListBox
            // 
            EstudianteListBox.FormattingEnabled = true;
            EstudianteListBox.ItemHeight = 21;
            EstudianteListBox.Location = new Point(126, 302);
            EstudianteListBox.Name = "EstudianteListBox";
            EstudianteListBox.Size = new Size(563, 88);
            EstudianteListBox.TabIndex = 11;
            // 
            // StudentSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 402);
            Controls.Add(EstudianteListBox);
            Controls.Add(EliminarButton);
            Controls.Add(AgregarButton);
            Controls.Add(CarreraTexBox);
            Controls.Add(CarreraLabel);
            Controls.Add(TelefonoTextBox);
            Controls.Add(TelefonoLabel);
            Controls.Add(ApellidosTextBox);
            Controls.Add(ApellidosLabel);
            Controls.Add(label2);
            Controls.Add(NombresTextBox);
            Controls.Add(NombreLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StudentSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NombreLabel;
        private TextBox NombresTextBox;
        private Label label2;
        private TextBox ApellidosTextBox;
        private Label ApellidosLabel;
        private TextBox TelefonoTextBox;
        private Label TelefonoLabel;
        private TextBox CarreraTexBox;
        private Label CarreraLabel;
        private Button AgregarButton;
        private Button EliminarButton;
        private ListBox EstudianteListBox;
    }
}