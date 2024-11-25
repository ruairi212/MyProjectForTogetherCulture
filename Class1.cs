using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace member_space
{
    class dashBoard_Data : DatabaseConnection
    {
        private DateTime start_Date;
        private DateTime end_Date;
        private int number_Days; 
        public int total_Members { get; set; }
        public int total_Users { get; set; }

        // dashboard data displayed
        public int Get_Totals() 
        {
            using (var connection = get_Connection()) 
            {
                connection.Open();
                using (var command = new MySqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT count(MemberID) FROM `member`";
                    total_Members = Convert.ToInt32(command.ExecuteScalar());
                   
                    command.CommandText = "SELECT count(email) FROM `nonmember`";
                    total_Users = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return total_Members;
            
        }
}
}

