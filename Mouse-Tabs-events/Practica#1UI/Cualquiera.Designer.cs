namespace Practica_1UI
{
    partial class rastreoMouse
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
            downUpGroupBox = new GroupBox();
            downUpPictureBox = new PictureBox();
            moveGroupBox = new GroupBox();
            ejeYLabel = new Label();
            label3 = new Label();
            ejeXLabel = new Label();
            label = new Label();
            wheelGroupBox = new GroupBox();
            wheelLabel = new Label();
            downUpGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)downUpPictureBox).BeginInit();
            moveGroupBox.SuspendLayout();
            wheelGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // downUpGroupBox
            // 
            downUpGroupBox.Controls.Add(downUpPictureBox);
            downUpGroupBox.Location = new Point(77, 45);
            downUpGroupBox.Name = "downUpGroupBox";
            downUpGroupBox.Size = new Size(256, 139);
            downUpGroupBox.TabIndex = 0;
            downUpGroupBox.TabStop = false;
            downUpGroupBox.Text = "MouseDown y MouseUp";
            // 
            // downUpPictureBox
            // 
            downUpPictureBox.BorderStyle = BorderStyle.FixedSingle;
            downUpPictureBox.Location = new Point(44, 32);
            downUpPictureBox.Name = "downUpPictureBox";
            downUpPictureBox.Size = new Size(157, 88);
            downUpPictureBox.TabIndex = 0;
            downUpPictureBox.TabStop = false;
            downUpPictureBox.MouseDown += downUpPictureBox_MouseDown;
            downUpPictureBox.MouseUp += downUpPictureBox_MouseUp;
            // 
            // moveGroupBox
            // 
            moveGroupBox.Controls.Add(ejeYLabel);
            moveGroupBox.Controls.Add(label3);
            moveGroupBox.Controls.Add(ejeXLabel);
            moveGroupBox.Controls.Add(label);
            moveGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moveGroupBox.Location = new Point(412, 45);
            moveGroupBox.Name = "moveGroupBox";
            moveGroupBox.Size = new Size(256, 139);
            moveGroupBox.TabIndex = 1;
            moveGroupBox.TabStop = false;
            moveGroupBox.Text = "Mouse Move";
            // 
            // ejeYLabel
            // 
            ejeYLabel.AutoSize = true;
            ejeYLabel.Location = new Point(125, 78);
            ejeYLabel.Name = "ejeYLabel";
            ejeYLabel.Size = new Size(45, 17);
            ejeYLabel.TabIndex = 3;
            ejeYLabel.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 78);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Eje Y: ";
            // 
            // ejeXLabel
            // 
            ejeXLabel.AutoSize = true;
            ejeXLabel.Location = new Point(125, 32);
            ejeXLabel.Name = "ejeXLabel";
            ejeXLabel.Size = new Size(45, 17);
            ejeXLabel.TabIndex = 1;
            ejeXLabel.Text = "label2";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(41, 32);
            label.Name = "label";
            label.Size = new Size(47, 17);
            label.TabIndex = 0;
            label.Text = "Eje X: ";
            // 
            // wheelGroupBox
            // 
            wheelGroupBox.Controls.Add(wheelLabel);
            wheelGroupBox.Location = new Point(259, 212);
            wheelGroupBox.Name = "wheelGroupBox";
            wheelGroupBox.Size = new Size(256, 139);
            wheelGroupBox.TabIndex = 2;
            wheelGroupBox.TabStop = false;
            wheelGroupBox.Text = "Mouse Wheel";
            wheelGroupBox.Enter += wheelGroupBox_Enter;
            // 
            // wheelLabel
            // 
            wheelLabel.AutoSize = true;
            wheelLabel.Location = new Point(92, 72);
            wheelLabel.Name = "wheelLabel";
            wheelLabel.Size = new Size(71, 15);
            wheelLabel.TabIndex = 4;
            wheelLabel.Text = "Nada tal vez";
            // 
            // rastreoMouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wheelGroupBox);
            Controls.Add(moveGroupBox);
            Controls.Add(downUpGroupBox);
            Name = "rastreoMouse";
            Text = "Cualquiera";
            MouseClick += rastreoMouse_MouseClick;
            MouseMove += rastreoMouse_MouseMove;
            downUpGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)downUpPictureBox).EndInit();
            moveGroupBox.ResumeLayout(false);
            moveGroupBox.PerformLayout();
            wheelGroupBox.ResumeLayout(false);
            wheelGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox downUpGroupBox;
        private Label label;
        private GroupBox moveGroupBox;
        private GroupBox wheelGroupBox;
        private Label ejeYLabel;
        private Label label3;
        private Label ejeXLabel;
        private PictureBox downUpPictureBox;
        private Label wheelLabel;
    }
}