using CatalogNoteApp.Data;
using CatalogNoteApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogNoteApp.Data
{
    public class NotaRepository
    {
        public static List<Nota> GetAll()
        {
            var list = new List<Nota>();
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM note", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Nota
                        {
                            Id = reader.GetInt32("id"),
                            StudentId = reader.GetInt32("student_id"),
                            DisciplinaId = reader.GetInt32("disciplina_id"),
                            Valoare = reader.GetInt32("valoare"),
                            DataNotarii = reader.GetDateTime("data_notarii")
                        });
                    }
                }
            }
            return list;
        }

        public static void Add(Nota n)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO note (student_id, disciplina_id, valoare, data_notarii) VALUES (@sid, @did, @val, @data)", conn);
                cmd.Parameters.AddWithValue("@sid", n.StudentId);
                cmd.Parameters.AddWithValue("@did", n.DisciplinaId);
                cmd.Parameters.AddWithValue("@val", n.Valoare);
                cmd.Parameters.AddWithValue("@data", n.DataNotarii);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int id)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM note WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Nota n)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE note SET student_id=@sid, disciplina_id=@did, valoare=@val, data_notarii=@data WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", n.Id);
                cmd.Parameters.AddWithValue("@sid", n.StudentId);
                cmd.Parameters.AddWithValue("@did", n.DisciplinaId);
                cmd.Parameters.AddWithValue("@val", n.Valoare);
                cmd.Parameters.AddWithValue("@data", n.DataNotarii);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
