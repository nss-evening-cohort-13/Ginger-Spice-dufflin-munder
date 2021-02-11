using System;
using dufflin_munder.Employee;

namespace dufflin_munder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Sales Employees options to console
            SalesEmployee.SalesEmployeesOptions();
            // Determine user selection of Sales Agent and set to property
            SalesEmployee.SalesEmployeeSelection();
        }
    }
}
