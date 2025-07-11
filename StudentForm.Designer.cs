using System.Windows.Forms;

namespace CatalogNoteApp
{
    partial class StudentForm :Form
    {
       
            private System.Windows.Forms.DataGridView dgvStudenti;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnSave;
            private System.Windows.Forms.Button btnDelete;

            private void InitializeComponent()
            {
                this.dgvStudenti = new System.Windows.Forms.DataGridView();
                this.btnAdd = new System.Windows.Forms.Button();
                this.btnSave = new System.Windows.Forms.Button();
                this.btnDelete = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
                this.SuspendLayout();

                // dgvStudenti
                this.dgvStudenti.Location = new System.Drawing.Point(20, 60);
                this.dgvStudenti.Size = new System.Drawing.Size(600, 300);
                this.dgvStudenti.AllowUserToAddRows = false;
                this.dgvStudenti.AutoGenerateColumns = true;

                // btnAdd
                this.btnAdd.Location = new System.Drawing.Point(20, 20);
                this.btnAdd.Size = new System.Drawing.Size(100, 25);
                this.btnAdd.Text = "Adaugă";
                this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

                // btnSave
                this.btnSave.Location = new System.Drawing.Point(130, 20);
                this.btnSave.Size = new System.Drawing.Size(100, 25);
                this.btnSave.Text = "Salvează";
                this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

                // btnDelete
                this.btnDelete.Location = new System.Drawing.Point(240, 20);
                this.btnDelete.Size = new System.Drawing.Size(100, 25);
                this.btnDelete.Text = "Șterge";
                this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

                // StudentForm
                this.ClientSize = new System.Drawing.Size(650, 400);
                this.Controls.Add(this.dgvStudenti);
                this.Controls.Add(this.btnAdd);
                this.Controls.Add(this.btnSave);
                this.Controls.Add(this.btnDelete);
                this.Name = "StudentForm";
                this.Text = "Gestionare Studenți";
                ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
                this.ResumeLayout(false);
            }
        }
    
}