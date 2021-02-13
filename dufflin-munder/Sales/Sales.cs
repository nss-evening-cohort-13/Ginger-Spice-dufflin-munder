using dufflin_munder.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dufflin_munder.Sales
{
    class NewSales
    {
        public string SalesAgent { get; set; }
        public string Client { get; set; }
        public string ClientID { get; set; }
        public decimal Sale { get; set; }
        public string Recurring { get; set; }
        public string TimeFrame { get; set; }

        public NewSales(string salesAgent, string client, string clientID, decimal sale, string recurring, string timeFrame)
        {
            SalesAgent = salesAgent;
            Client = client;
            ClientID = clientID;
            Sale = sale;
            Recurring = recurring;
            TimeFrame = timeFrame;
            
        }

        public static void salesReportMessage()
        {
            Console.WriteLine("\nMonthly Sales Report");
            Console.WriteLine($"For: {AccountantEmployee.AccountantSelection}\n");

            //Loop over the Sale's Agents and # them
            //---------------------------------------------------
            // Use num to number the list of employee options
            int num = 1;
            int numClient = 1;
            string space = "";
            decimal totalSales = 0;
            // Loop through SalesEmployees and print to console
            foreach (string employee in SalesEmployee.SalesEmployees)
            {
                Console.WriteLine($"{num}. {employee}");
                // Add indentation to the left of the string
                Console.WriteLine($"{space.PadLeft(3)}Clients:");

                // Loop through objects in listOfSales to find the clients assigned to each Sales Agent
                var clients = from s in SalesEmployee.listOfSales
                              where s.SalesAgent == employee
                              select s.Client;

                // Loop through the clients to print each client under the assigned Sales Agent
                foreach (string client in clients)
                {
                   Console.WriteLine($"{space.PadLeft(5)} {numClient}. {client}");
                    numClient++;
                }

                // Loop through objects in listOfSales to pull the Sales for each Sales Agent
                var salesTotal = from s in SalesEmployee.listOfSales
                                 where s.SalesAgent == employee
                                 select s.Sale;

                // Loop through each sales and add up the total
                foreach (decimal sale in salesTotal)
                    {
                        totalSales = totalSales + sale;
                    }

                //console the total sales
                Console.WriteLine($"Total: ${totalSales}\n");
                num++;
                
                
                totalSales = 0;
            }
                
        }
    }
}
