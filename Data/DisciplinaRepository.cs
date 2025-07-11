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
    public class DisciplinaRepository
    {
        public static List<Disciplina> GetAll()
        {
            var list = new List<Disciplina>();
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM discipline", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Disciplina
                        {
                            Id = reader.GetInt32("id"),
                            Nume = reader.IsDBNull(reader.GetOrdinal("nume")) ? null : reader.GetString("nume"),
                            Acronim = reader.IsDBNull(reader.GetOrdinal("acronim")) ? null : reader.GetString("acronim"),
                            TipEvaluare = reader.IsDBNull(reader.GetOrdinal("tip_evaluare")) ? null : reader.GetString("tip_evaluare")
                        });
                    }
                }
            }
            return list;
        }

        public static void Add(Disciplina d)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO discipline (nume, acronim, tip_evaluare) VALUES (@nume, @acronim, @tip)", conn);
                cmd.Parameters.AddWithValue("@nume", d.Nume);
                cmd.Parameters.AddWithValue("@acronim", d.Acronim);
                cmd.Parameters.AddWithValue("@tip", d.TipEvaluare);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Disciplina d)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE discipline SET nume=@nume, acronim=@acronim, tip_evaluare=@tip WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", d.Id);
                cmd.Parameters.AddWithValue("@nume", d.Nume);
                cmd.Parameters.AddWithValue("@acronim", d.Acronim);
                cmd.Parameters.AddWithValue("@tip", d.TipEvaluare);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int id)
        {
            using (var conn = DbConnectorHelper.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM discipline WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
