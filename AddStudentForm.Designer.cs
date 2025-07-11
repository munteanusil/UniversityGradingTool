using System.Drawing;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    partial class AddStudentForm
    {
        private Label lblNume;
        private Label lblPrenume;
        private Label lblEmail;
        private Label lblGrupa;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtEmail;
        private TextBox txtGrupa;
        private Button btnSave;


        private void InitializeComponent()
        {
            // Etichete
            lblNume = new Label { Location = new Point(20, 20), Size = new Size(80, 20), Text = "Nume:" };
            lblPrenume = new Label { Location = new Point(20, 60), Size = new Size(80, 20), Text = "Prenume:" };
            lblEmail = new Label { Location = new Point(20, 100), Size = new Size(80, 20), Text = "Email:" };
            lblGrupa = new Label { Location = new Point(20, 140), Size = new Size(80, 20), Text = "Grupa:" };

            // Câmpuri text
            txtNume = new TextBox { Location = new Point(110, 20), Width = 150 };
            txtPrenume = new TextBox { Location = new Point(110, 60), Width = 150 };
            txtEmail = new TextBox { Location = new Point(110, 100), Width = 150 };
            txtGrupa = new TextBox { Location = new Point(110, 140), Width = 150 };

            // Buton salvare
            btnSave = new Button { Location = new Point(20, 190), Size = new Size(240, 30), Text = "Salvează" };
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Adaugă controalele
            this.Controls.AddRange(new Control[] {
                lblNume, txtNume,
                lblPrenume, txtPrenume,
                lblEmail, txtEmail,
                lblGrupa, txtGrupa,
                btnSave
            });

            this.ClientSize = new Size(290, 250);
            this.Name = "AddStudentForm";
            this.Text = "Adaugă Student";
        }
    }
}
