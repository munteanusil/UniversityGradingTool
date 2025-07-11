using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CatalogNoteApp.Utils
{
    public class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["AgendaDb"].ConnectionString;
        }
    }
}
