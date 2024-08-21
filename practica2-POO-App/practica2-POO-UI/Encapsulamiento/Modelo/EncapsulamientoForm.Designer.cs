namespace practica2_POO_UI.Encapsulamiento.Modelo
{
    partial class EncapsulamientoForm
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
            label1 = new Label();
            cantidadTextBox = new TextBox();
            saldoButton = new Button();
            retitarButton = new Button();
            depositarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 38);
            label1.Name = "label1";
            label1.Size = new Size(345, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto a depositar o retirar";
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.BorderStyle = BorderStyle.FixedSingle;
            cantidadTextBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cantidadTextBox.Location = new Point(351, 111);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(125, 27);
            cantidadTextBox.TabIndex = 1;
            // 
            // saldoButton
            // 
            saldoButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saldoButton.Location = new Point(539, 184);
            saldoButton.Name = "saldoButton";
            saldoButton.Size = new Size(125, 29);
            saldoButton.TabIndex = 2;
            saldoButton.Text = "Saldo";
            saldoButton.UseVisualStyleBackColor = true;
            saldoButton.Click += saldoButton_Click;
            // 
            // retitarButton
            // 
            retitarButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retitarButton.Location = new Point(351, 184);
            retitarButton.Name = "retitarButton";
            retitarButton.Size = new Size(125, 29);
            retitarButton.TabIndex = 3;
            retitarButton.Text = "Retirar";
            retitarButton.UseVisualStyleBackColor = true;
            retitarButton.Click += retitarButton_Click;
            // 
            // depositarButton
            // 
            depositarButton.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositarButton.Location = new Point(169, 184);
            depositarButton.Name = "depositarButton";
            depositarButton.Size = new Size(125, 29);
            depositarButton.TabIndex = 4;
            depositarButton.Text = "Depositar";
            depositarButton.UseVisualStyleBackColor = true;
            depositarButton.Click += depositarButton_Click;
            // 
            // EncapsulamientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(depositarButton);
            Controls.Add(retitarButton);
            Controls.Add(saldoButton);
            Controls.Add(cantidadTextBox);
            Controls.Add(label1);
            Name = "EncapsulamientoForm";
            Text = "EncapsulamientoForm";
            Load += EncapsulamientoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cantidadTextBox;
        private Button saldoButton;
        private Button retitarButton;
        private Button depositarButton;
    }
}