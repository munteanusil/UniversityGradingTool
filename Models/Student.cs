using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogNoteApp.Models
{
    public class Student
    {

        public int Id { get; set; }            // PK
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Grupa { get; set; }

        public override string ToString()
        {
            return $"{Nume}";
        }
    }

}
