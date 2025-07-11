using CatalogNoteApp.Models;
using System;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    public partial class AddDisciplinaForm : Form
    {
        public Disciplina Disciplina { get; private set; }

        public AddDisciplinaForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtAcronim.Text) ||
                string.IsNullOrWhiteSpace(txtTipEvaluare.Text))
            {
                MessageBox.Show("Completați toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Disciplina = new Disciplina
            {
                Nume = txtNume.Text,
                Acronim = txtAcronim.Text,
                TipEvaluare = txtTipEvaluare.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
