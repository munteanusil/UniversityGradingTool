using System.Windows.Forms;

namespace CatalogNoteApp
{
    partial class DisciplinaForm :Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDiscipline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;

        private void InitializeComponent()
        {
            this.dgvDiscipline = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).BeginInit();
            this.SuspendLayout();

            // dgvDiscipline
            this.dgvDiscipline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscipline.Location = new System.Drawing.Point(20, 60);
            this.dgvDiscipline.Name = "dgvDiscipline";
            this.dgvDiscipline.Size = new System.Drawing.Size(600, 300);
            this.dgvDiscipline.TabIndex = 0;
            this.dgvDiscipline.AutoGenerateColumns = true;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adaugă";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(130, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(240, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Șterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // DisciplinaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.dgvDiscipline);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Name = "DisciplinaForm";
            this.Text = "Gestionare Discipline";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscipline)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
