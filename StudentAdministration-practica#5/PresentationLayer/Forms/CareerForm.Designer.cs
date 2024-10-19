namespace PresentationLayer.Forms
{
    partial class CareerForm
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
            dgvCareers = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            txtDescriptionCareer = new TextBox();
            txtNameCareer = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCareers).BeginInit();
            SuspendLayout();
            // 
            // dgvCareers
            // 
            dgvCareers.AllowUserToAddRows = false;
            dgvCareers.AllowUserToDeleteRows = false;
            dgvCareers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCareers.Location = new Point(385, 52);
            dgvCareers.MultiSelect = false;
            dgvCareers.Name = "dgvCareers";
            dgvCareers.ReadOnly = true;
            dgvCareers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCareers.Size = new Size(382, 299);
            dgvCareers.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(138, 328);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionCareer
            // 
            txtDescriptionCareer.Location = new Point(10, 181);
            txtDescriptionCareer.Multiline = true;
            txtDescriptionCareer.Name = "txtDescriptionCareer";
            txtDescriptionCareer.Size = new Size(320, 116);
            txtDescriptionCareer.TabIndex = 13;
            // 
            // txtNameCareer
            // 
            txtNameCareer.Location = new Point(10, 89);
            txtNameCareer.Name = "txtNameCareer";
            txtNameCareer.Size = new Size(320, 23);
            txtNameCareer.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 143);
            label3.Name = "label3";
            label3.Size = new Size(204, 21);
            label3.TabIndex = 11;
            label3.Text = "Descripcion de la Carrera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 52);
            label2.Name = "label2";
            label2.Size = new Size(177, 21);
            label2.TabIndex = 10;
            label2.Text = "Nombre de la Carrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 1);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 9;
            label1.Text = "Administrador de Carreras";
            // 
            // CareerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCareers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtDescriptionCareer);
            Controls.Add(txtNameCareer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CareerForm";
            Text = "CareerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCareers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCareers;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtDescriptionCareer;
        private TextBox txtNameCareer;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}