using CatalogNoteApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CatalogNoteApp.Data
{
    public class DbConnectorHelper
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationHelper.GetConnectionString());
        }
    }
}
