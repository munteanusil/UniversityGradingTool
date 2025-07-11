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
using CatalogNoteApp;

namespace CatalogNoteApp
{
    public partial class StudentForm : Form
    {
        private BindingList<Student> _studenti;


        public StudentForm()
        {
            InitializeComponent();
            LoadStudenti();
        }

        private void LoadStudenti()
        {
            var list = StudentRepository.GetAll().ToList();
            _studenti = new BindingList<Student>(list);
            this.dgvStudenti.DataSource = _studenti;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var student = addForm.Student;
                StudentRepository.Add(student);
                LoadStudenti();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var student in _studenti)
            {
                if (student.Id == 0)
                    StudentRepository.Add(student);
                else
                    StudentRepository.Update(student);
            }

            LoadStudenti();
            MessageBox.Show("Modificările au fost salvate cu succes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.CurrentRow == null) return;

            var student = dgvStudenti.CurrentRow.DataBoundItem as Student;
            if (student == null) return;

            if (student.Id != 0)
                StudentRepository.Delete(student.Id);

            _studenti.Remove(student);
        }


    }
}



