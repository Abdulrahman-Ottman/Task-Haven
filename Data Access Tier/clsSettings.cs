using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Tier
{
     class clsSettings
    {
        public static string connectionString { get; set; } = "Server=.;Database=TaskHavenDB;User Id=sa;Password=abood;";
        public static SqlConnection connection = new SqlConnection(connectionString);
    }
}
