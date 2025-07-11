using CatalogNoteApp.Data;
using CatalogNoteApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    public partial class NoteForm : Form
    {
        private List<Nota> note;

        public NoteForm()
        {
            InitializeComponent();
            LoadStudenti();
            LoadDiscipline();
            LoadNote();
        }

        private void LoadStudenti()
        {
            var studenti = StudentRepository.GetAll();

            // Adăugăm opțiunea "Toți"
            studenti.Insert(0, new Student { Id = 0, Nume = "Toți", Prenume = "" });

            cmbStudenti.DataSource = studenti;
            cmbStudenti.DisplayMember = "Nume";
            cmbStudenti.ValueMember = "Id";
        }

        private void LoadDiscipline()
        {
            var discipline = DisciplinaRepository.GetAll();

            // Adăugăm opțiunea "Toate"
            discipline.Insert(0, new Disciplina { Id = 0, Nume = "Toate" });

            cmbDiscipline.DataSource = discipline;
            cmbDiscipline.DisplayMember = "Nume";
            cmbDiscipline.ValueMember = "Id";
        }


        private void LoadNote()
        {
            note = NotaRepository.GetAll();

            var studenti = StudentRepository.GetAll();
            var discipline = DisciplinaRepository.GetAll();

            var table = note.Select(n => new
            {
                n.Id,
                Student = studenti.FirstOrDefault(s => s.Id == n.StudentId)?.ToString(),
                Disciplina = discipline.FirstOrDefault(d => d.Id == n.DisciplinaId)?.ToString(),
                n.Valoare,
                n.DataNotarii,
                Promovat = n.Valoare >= 5 ? "Da" : "Nu"
            }).ToList();

            dgvNote.DataSource = table;
        }


        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            int studentId = (int)cmbStudenti.SelectedValue;
            int disciplinaId = (int)cmbDiscipline.SelectedValue;

            var studenti = StudentRepository.GetAll();
            var discipline = DisciplinaRepository.GetAll();

            var filtrate = note
                .Where(n =>
                    (studentId == 0 || n.StudentId == studentId) &&
                    (disciplinaId == 0 || n.DisciplinaId == disciplinaId))
                .Select(n => new
                {
                    n.Id,
                    Student = studenti.FirstOrDefault(s => s.Id == n.StudentId)?.ToString(),
                    Disciplina = discipline.FirstOrDefault(d => d.Id == n.DisciplinaId)?.Nume,
                    n.Valoare,
                    n.DataNotarii,
                    Promovat = n.Valoare >= 5 ? "Da" : "Nu"
                })
                .ToList();

            dgvNote.DataSource = filtrate;
        }


        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            if (cmbStudenti.SelectedItem == null || cmbDiscipline.SelectedItem == null)
            {
                MessageBox.Show("Selectează un student și o disciplină.");
                return;
            }

            var nota = new Nota
            {
                StudentId = ((Student)cmbStudenti.SelectedItem).Id,
                DisciplinaId = ((Disciplina)cmbDiscipline.SelectedItem).Id,
                Valoare = (int)numValoare.Value,
                DataNotarii = dtpData.Value.Date
            };

            NotaRepository.Add(nota);
            MessageBox.Show("Notă adăugată cu succes.");
            LoadNote(); // reîncarcă grila
        }

        private void btnMedie_Click(object sender, EventArgs e)
        {
            int studentId = (int)cmbStudenti.SelectedValue;
            var medie = note
                .Where(n => n.StudentId == studentId)
                .Select(n => n.Valoare)
                .DefaultIfEmpty(0)
                .Average();

            lblMedie.Text = $"Medie: {medie:F2}";
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveDialog.FileName = "catalog_note.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName))
                {
                    sw.WriteLine("ID,Student,Disciplina,Nota,Data,Promovat");
                    foreach (var n in note)
                    {
                        var student = StudentRepository.GetAll().FirstOrDefault(s => s.Id == n.StudentId)?.ToString();
                        var disciplina = DisciplinaRepository.GetAll().FirstOrDefault(d => d.Id == n.DisciplinaId)?.ToString();
                        var promovare = n.Valoare >= 5 ? "Da" : "Nu";

                        sw.WriteLine($"{n.Id},{student},{disciplina},{n.Valoare},{n.DataNotarii:yyyy-MM-dd},{promovare}");
                    }
                }

                MessageBox.Show("Export realizat cu succes!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
