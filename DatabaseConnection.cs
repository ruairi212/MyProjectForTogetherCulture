using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace member_space
{
    public class DatabaseConnection
    {
        private string connection_String;
        public DatabaseConnection() 
        {
            connection_String = "example";
        }
        protected SqlConnection get_Connection()
        { 
            return new SqlConnection(connection_String); 
        }
     }
}
