using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member_space
{
    class member_Data : DatabaseConnection
    {
        public int Id { get; set; }
    public string first_Name { get; set; }
    public string second_Name { get; set; }

    public member_Data() { int Id, first_Name, second_Name; }
}
}

