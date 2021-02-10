using dufflin_munder.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace dufflin_munder.Employee
{
    class SalesEmployee : Employee
    {
        public List<NewSales> listOfSales { get; set; } = new List<NewSales>();

       
    }
}
