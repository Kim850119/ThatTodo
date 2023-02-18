using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
    public class EmployeeEntity
    {
        public string? CustomerID { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? HomePhone { get; set; }
        public string? CellPhone { get; set; }
    }
}
