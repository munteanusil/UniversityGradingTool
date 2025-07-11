using CatalogNoteApp.Models;
using System;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    public partial class AddStudentForm : Form
    {
        public Student Student { get; private set; }

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student = new Student
            {
                Nume = txtNume.Text,
                Prenume = txtPrenume.Text,
                Email = txtEmail.Text,
                Grupa = txtGrupa.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
