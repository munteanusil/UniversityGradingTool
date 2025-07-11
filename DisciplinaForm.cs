using CatalogNoteApp;
using CatalogNoteApp.Data;
using CatalogNoteApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    public partial class DisciplinaForm : Form
    {
        private BindingList<Disciplina> _discipline;
      
 
      

        public DisciplinaForm()
        {
            InitializeComponent();
            LoadDiscipline();
        }

     

        private void LoadDiscipline()
        {
            var list = DisciplinaRepository.GetAll().ToList();
            _discipline = new BindingList<Disciplina>(list);
            dgvDiscipline.DataSource = _discipline;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddDisciplinaForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var disciplina = addForm.Disciplina;
                    DisciplinaRepository.Add(disciplina);
                    LoadDiscipline(); // Reîncarcă lista cu noua disciplină adăugată
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var disciplina in _discipline)
            {
                if (disciplina.Id == 0)
                    DisciplinaRepository.Add(disciplina);
                else
                    DisciplinaRepository.Update(disciplina);
            }

            LoadDiscipline();
            MessageBox.Show("Modificările au fost salvate cu succes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiscipline.CurrentRow == null) return;

            var disciplina = dgvDiscipline.CurrentRow.DataBoundItem as Disciplina;
            if (disciplina == null) return;

            if (disciplina.Id != 0)
                DisciplinaRepository.Delete(disciplina.Id);

            _discipline.Remove(disciplina);
        }
    }
}