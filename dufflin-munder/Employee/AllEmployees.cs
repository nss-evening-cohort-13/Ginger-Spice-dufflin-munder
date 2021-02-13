using System;
using System.Collections.Generic;
using System.Text;
using dufflin_munder.Employee;

namespace dufflin_munder.Employee
{
    class AllEmployees
    {
        public string Name { get; set; }
        public int OfficeId { get; set; }
        public List<SalesEmployee> SalesEmployees { get; set; } = new List<SalesEmployee>();
        public string Location { get; set; }

        public AllEmployees(string name, int officeId, string location)
        {
            Name = name;
            Location = location;
            OfficeId = officeId;
        }
    }
}
