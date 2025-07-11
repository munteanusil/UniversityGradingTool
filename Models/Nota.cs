using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogNoteApp.Models
{
    public class Nota
    {
        public int Id { get; set; }               // PK
        public int StudentId { get; set; }        // FK
        public int DisciplinaId { get; set; }     // FK
        public int Valoare { get; set; }          // nota numerică
        public DateTime DataNotarii { get; set; }
    }
}
