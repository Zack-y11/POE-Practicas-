namespace Practica_1UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KeyPressTextBox = new TextBox();
            KeyDownTextBox = new TextBox();
            SuspendLayout();
            // 
            // KeyPressTextBox
            // 
            KeyPressTextBox.Location = new Point(277, 29);
            KeyPressTextBox.Name = "KeyPressTextBox";
            KeyPressTextBox.Size = new Size(166, 23);
            KeyPressTextBox.TabIndex = 0;
            KeyPressTextBox.KeyPress += KeyPressTextBox_KeyPress;
            // 
            // KeyDownTextBox
            // 
            KeyDownTextBox.Location = new Point(277, 110);
            KeyDownTextBox.Name = "KeyDownTextBox";
            KeyDownTextBox.Size = new Size(166, 23);
            KeyDownTextBox.TabIndex = 1;
            KeyDownTextBox.KeyDown += KeyDownTextBox_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KeyDownTextBox);
            Controls.Add(KeyPressTextBox);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox KeyPressTextBox;
        private TextBox KeyDownTextBox;
    }
}
