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
        public int Sale { get; set; }
        public string Recurring { get; set; }
        public string TimeFrame { get; set; }

        public NewSales(string salesAgent, string client, string clientID, int sale, string recurring, string timeFrame)
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
            Console.WriteLine("Monthly Sales Report");
            Console.WriteLine($"For: {AccountantEmployee.AccountantSelection}\n");

            //Loop over the Sale's Agents and # them
            //---------------------------------------------------
            // Use num to number the list of employee options
            int num = 1;
            int numClient = 1;
            string space = "";
            int totalSales = 0;
            // Loop through SalesEmployees and print to console
            foreach (string employee in SalesEmployee.SalesEmployees)
            {
                Console.WriteLine($"{num}. {employee}");
                Console.WriteLine($"{space.PadLeft(3)}Clients:");
                var clients = from s in SalesEmployee.listOfSales
                              where s.SalesAgent == employee
                              select s.Client;
                foreach (string client in clients)
                {
                    
                   Console.WriteLine($"{space.PadLeft(5)} {numClient}. {client}");
                    numClient++;
                }
                var salesTotal = from s in SalesEmployee.listOfSales
                                 where s.SalesAgent == employee
                                 select s.Sale;
                foreach (int sale in salesTotal)
                    {
                        totalSales = totalSales + sale;
                    }

                //console the total sales
                Console.WriteLine($"Total: ${totalSales}\n");
                num++;
                
                
                totalSales = 0;
            }

            //loop over saleslist (list of objects)
            //In the loop you would check if sale.SaleAgent == employee
            //foreach (sale in)
            //array.find(Employee == salesReportMessage.SaleAgent){do the things};
            //then you would pull the client out
            //for( sale in salelist) sale.Client;
            
            // var clients = for c in clientList
                          
        }
    }
}
