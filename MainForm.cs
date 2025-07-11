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

    public partial class MainForm : Form
    {

        private BindingList<Student> _students;

        public MainForm()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            var list = StudentRepository.GetAll().ToList();
            _students = new BindingList<Student>(list);
            dgvContacts.DataSource = _students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contact = new Student();
            _students.Add(contact);
            dgvContacts.CurrentCell = dgvContacts.Rows[dgvContacts.Rows.Count - 1].Cells["FirstName"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var contact in _students)
            {
                if (contact.Id == 0)
                    StudentRepository.Add(contact);
                else
                    StudentRepository.Update(contact);
            }

            LoadContacts();
            MessageBox.Show("Modificările au fost salvate cu succes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null) return;

            var contact = dgvContacts.CurrentRow.DataBoundItem as Student;
            if (contact == null) return;

            if (contact.Id != 0)
                StudentRepository.Delete(contact.Id);

            _students.Remove(contact);
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            form.ShowDialog();
        }

        private void btnDiscipline_Click(object sender, EventArgs e)
        {
            var form = new DisciplinaForm();
            form.ShowDialog();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            var form = new NoteForm();
            form.ShowDialog();
        }

    }

}


