using System;
using dufflin_munder.Employee;
using dufflin_munder.Sales;

namespace dufflin_munder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SalesEmployee salesList = new SalesEmployee();

            salesList.listOfSales.Add(new NewSales("salesAgent", "client", "clientID", 1234, "Monthly", "3 months"));
            
            foreach (var sale in salesList.listOfSales)
            {
                Console.WriteLine(sale.Client);
            }
           
            
        
           


        }

        //void SalesMessage()
        //{
            //Console.WriteLine("Sales Agent: ");
            //Console.WriteLine("Client: "); 
            //Console.WriteLine("ClientID: "); 
            //Console.WriteLine("Sale: ");
            //Console.WriteLine("Recurring: "); 
            //Console.WriteLine("Time Frame: "); 
       //}

        
    }
}
