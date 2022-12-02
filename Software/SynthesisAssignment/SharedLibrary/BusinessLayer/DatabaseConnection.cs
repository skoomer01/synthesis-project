using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SharedLibrary.BusinessLayer
{
    public class DatabaseConnection
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi490388;User Id=dbi490388;Password=Qvp2dgPZVq;Encrypt=False;");
        }
    }
}
