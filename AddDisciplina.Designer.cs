using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogNoteApp
{
    public partial class AddDisciplinaForm
    {
        private Label lblNume;
        private Label lblAcronim;
        private Label lblTipEvaluare;
        private TextBox txtNume;
        private TextBox txtAcronim;
        private TextBox txtTipEvaluare;
        private Button btnSave;

        private void InitializeComponent()
        {
            this.lblNume = new Label();
            this.lblAcronim = new Label();
            this.lblTipEvaluare = new Label();
            this.txtNume = new TextBox();
            this.txtAcronim = new TextBox();
            this.txtTipEvaluare = new TextBox();
            this.btnSave = new Button();

            // lblNume
            this.lblNume.Text = "Nume:";
            this.lblNume.Location = new Point(20, 20);
            this.lblNume.Size = new Size(100, 20);

            // txtNume
            this.txtNume.Location = new Point(130, 20);
            this.txtNume.Size = new Size(200, 25);

            // lblAcronim
            this.lblAcronim.Text = "Acronim:";
            this.lblAcronim.Location = new Point(20, 60);
            this.lblAcronim.Size = new Size(100, 20);

            // txtAcronim
            this.txtAcronim.Location = new Point(130, 60);
            this.txtAcronim.Size = new Size(200, 25);

            // lblTipEvaluare
            this.lblTipEvaluare.Text = "Tip evaluare:";
            this.lblTipEvaluare.Location = new Point(20, 100);
            this.lblTipEvaluare.Size = new Size(100, 20);

            // txtTipEvaluare
            this.txtTipEvaluare.Location = new Point(130, 100);
            this.txtTipEvaluare.Size = new Size(200, 25);

            // btnSave
            this.btnSave.Text = "Salvează";
            this.btnSave.Location = new Point(130, 140);
            this.btnSave.Size = new Size(100, 30);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // Form
            this.ClientSize = new Size(360, 200);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblAcronim);
            this.Controls.Add(this.txtAcronim);
            this.Controls.Add(this.lblTipEvaluare);
            this.Controls.Add(this.txtTipEvaluare);
            this.Controls.Add(this.btnSave);
            this.Text = "Adaugă disciplină";
        }
    }
}
