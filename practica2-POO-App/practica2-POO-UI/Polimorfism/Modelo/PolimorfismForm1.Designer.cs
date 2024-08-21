namespace practica2_POO_UI.Polimorfism.Modelo
{
    partial class PolimorfismForm1
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
            encenderButton = new Button();
            SuspendLayout();
            // 
            // encenderButton
            // 
            encenderButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encenderButton.Location = new Point(171, 69);
            encenderButton.Name = "encenderButton";
            encenderButton.Size = new Size(420, 236);
            encenderButton.TabIndex = 0;
            encenderButton.Text = "Encender Computadora";
            encenderButton.UseVisualStyleBackColor = true;
            encenderButton.Click += encenderButton_Click;
            // 
            // PolimorfismForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(encenderButton);
            Name = "PolimorfismForm1";
            Text = "PolimorfismForm1";
            ResumeLayout(false);
        }

        #endregion

        private Button encenderButton;
    }
}