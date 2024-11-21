using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member_space
{
    class member_dashBoard_Data_ : DatabaseConnection
    {
        private DateTime start_Date;
        private DateTime end_Date;
        private int number_Days;
        public int memeber_Id { get; set; }
        public string first_Name { get; set; }
        public string second_Name { get; set; }
        public  string email {  get; set; }
        public DateTime date_Of_Birth { get; set; }
        public DateTime registration_Date { get; set; }

        public string membership_Type { get; set; }

    
}
}

