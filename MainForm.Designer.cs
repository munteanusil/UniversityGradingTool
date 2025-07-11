using System.Drawing;
using System;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    partial class MainForm
    {
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private Button btnStudenti;
        private Button btnDiscipline;
        private Button btnNote;

        private void InitializeComponent()
        {
            this.dgvContacts = new DataGridView();
            this.btnAdd = new Button();
            this.btnSave = new Button();
            this.btnDelete = new Button();
            this.btnStudenti = new Button();
            this.btnDiscipline = new Button();
            this.btnNote = new Button();

            var leftPanel = new Panel();
            var crudPanel = new Panel();

            // === LEFT MENU PANEL ===
            leftPanel.Location = new Point(0, 0);
            leftPanel.Size = new Size(150, 400);
            leftPanel.BackColor = Color.LightGray;
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            this.btnStudenti.Location = new Point(15, 20);
            this.btnStudenti.Size = new Size(120, 40);
            this.btnStudenti.Text = "Studenți";
            this.btnStudenti.Click += new EventHandler(this.btnStudenti_Click);

            this.btnDiscipline.Location = new Point(15, 70);
            this.btnDiscipline.Size = new Size(120, 40);
            this.btnDiscipline.Text = "Discipline";
            this.btnDiscipline.Click += new EventHandler(this.btnDiscipline_Click);

            this.btnNote.Location = new Point(15, 120);
            this.btnNote.Size = new Size(120, 40);
            this.btnNote.Text = "Note";
            this.btnNote.Click += new EventHandler(this.btnNote_Click);

            leftPanel.Controls.Add(this.btnStudenti);
            leftPanel.Controls.Add(this.btnDiscipline);
            leftPanel.Controls.Add(this.btnNote);

            // === CRUD PANEL ===
            crudPanel.Location = new Point(160, 10);
            crudPanel.Size = new Size(500, 40);

            // === TITLU APLICAȚIE ===
            Label lblTitlu = new Label();
            lblTitlu.Text = "Catalog Note Studenți";
            lblTitlu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point(300, 13); // Poziție sus-centru aproximativ
            this.Controls.Add(lblTitlu);

            // === DATA GRID ===
            this.dgvContacts.Location = new Point(160, 60);
            this.dgvContacts.Size = new Size(600, 300);
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AutoGenerateColumns = true;

            // === FORM ===
            this.ClientSize = new Size(800, 400);
            this.Controls.Add(leftPanel);
            this.Controls.Add(crudPanel);
            this.Controls.Add(this.dgvContacts);
            this.Text = "Agenda Studenți";
        }
    }
}


