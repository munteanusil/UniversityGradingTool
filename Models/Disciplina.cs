using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogNoteApp.Models
{
    public class Disciplina
    {

        public int Id { get; set; }            // PK
        public string Nume { get; set; }
        public string Acronim { get; set; }
        public string TipEvaluare { get; set; }  // examen / colocviu

        public override string ToString()
        {
            return Nume;
        }
    }

}
