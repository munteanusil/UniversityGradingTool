using CatalogNoteApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace CatalogNoteApp.Data
{
    public static class StudentRepository
    {
        public static List<Student> GetAll()
        {
            var studenti = new List<Student>();
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM studenti", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studenti.Add(new Student
                    {
                        Id = reader.GetInt32("id"),
                        Nume = reader.GetString("nume"),
                        Prenume = reader.GetString("prenume"),
                        Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email"),
                        Grupa = reader.IsDBNull(reader.GetOrdinal("grupa")) ? null : reader.GetString("grupa")
                    });
                }
            }
            return studenti;
        }

        public static void Add(Student student)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO studenti (nume, prenume, email, grupa) VALUES (@nume, @prenume, @email, @grupa)", conn);
                cmd.Parameters.AddWithValue("@nume", student.Nume);
                cmd.Parameters.AddWithValue("@prenume", student.Prenume);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@grupa", student.Grupa);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Student student)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE studenti SET nume=@nume, prenume=@prenume, email=@email, grupa=@grupa WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.Parameters.AddWithValue("@nume", student.Nume);
                cmd.Parameters.AddWithValue("@prenume", student.Prenume);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@grupa", student.Grupa);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int id)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM studenti WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
