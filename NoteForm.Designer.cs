using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    partial class NoteForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.ComboBox cmbDiscipline;
        private System.Windows.Forms.Button btnFiltrare;
        private System.Windows.Forms.Button btnMedie;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.Label lblMedie;
        private Button btnAdaugaNota;
        private NumericUpDown numValoare;
        private DateTimePicker dtpData;


        private void InitializeComponent()
        {
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.cmbDiscipline = new System.Windows.Forms.ComboBox();
            this.numValoare = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.btnFiltrare = new System.Windows.Forms.Button();
            this.btnMedie = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.lblMedie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValoare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.Location = new System.Drawing.Point(20, 20);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(180, 24);
            this.cmbStudenti.TabIndex = 0;
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.Location = new System.Drawing.Point(220, 20);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.Size = new System.Drawing.Size(180, 24);
            this.cmbDiscipline.TabIndex = 1;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // numValoare
            // 
            this.numValoare.Location = new System.Drawing.Point(420, 20);
            this.numValoare.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numValoare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numValoare.Name = "numValoare";
            this.numValoare.Size = new System.Drawing.Size(60, 22);
            this.numValoare.TabIndex = 2;
            this.numValoare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(500, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 22);
            this.dtpData.TabIndex = 3;
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.Location = new System.Drawing.Point(670, 20);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(110, 25);
            this.btnAdaugaNota.TabIndex = 4;
            this.btnAdaugaNota.Text = "Adaugă notă";
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.Location = new System.Drawing.Point(20, 60);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrare.TabIndex = 5;
            this.btnFiltrare.Text = "Filtrare";
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // btnMedie
            // 
            this.btnMedie.Location = new System.Drawing.Point(140, 60);
            this.btnMedie.Name = "btnMedie";
            this.btnMedie.Size = new System.Drawing.Size(120, 30);
            this.btnMedie.TabIndex = 6;
            this.btnMedie.Text = "Afișează Medie";
            this.btnMedie.Click += new System.EventHandler(this.btnMedie_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(280, 60);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(120, 30);
            this.btnExportCSV.TabIndex = 7;
            this.btnExportCSV.Text = "Exportă CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.ColumnHeadersHeight = 29;
            this.dgvNote.Location = new System.Drawing.Point(20, 110);
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.ReadOnly = true;
            this.dgvNote.RowHeadersWidth = 51;
            this.dgvNote.Size = new System.Drawing.Size(760, 260);
            this.dgvNote.TabIndex = 8;
            // 
            // lblMedie
            // 
            this.lblMedie.Location = new System.Drawing.Point(20, 380);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(300, 25);
            this.lblMedie.TabIndex = 9;
            this.lblMedie.Text = "Medie: -";
            // 
            // NoteForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.cmbDiscipline);
            this.Controls.Add(this.numValoare);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.btnMedie);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.dgvNote);
            this.Controls.Add(this.lblMedie);
            this.Name = "NoteForm";
            this.Text = "Gestionare Note";
            ((System.ComponentModel.ISupportInitialize)(this.numValoare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }
    }

}

