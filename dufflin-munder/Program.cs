using System;
using dufflin_munder.Employee;
using dufflin_munder.Sales;
using System.Linq;

namespace dufflin_munder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Calls menu screen
            Console.WriteLine("Welcome to Dufflin/Munder Cardboard Co.\nSales Portal \n");
            menuScreen();

            //loop variable
            var running = true;

            //starts the game loop
            menuChoiceLoop();






            //fucntion that holds the loop
            void menuChoiceLoop()
            {
                while (running)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            // Print Sales Employees options to console
                            SalesEmployee.SalesEmployeesOptions();
                            // Determine user selection of Sales Agent and set to property
                            SalesEmployee.SalesEmployeeSelection();
                            SalesMessage();
                            break;
                        case "2":
                            // Print Accountant Employees options to console
                            AccountantEmployee.AccountantEmployeesOptions();
                            // Determine user selection of Accountant and set to property
                            AccountantEmployee.AccountantEmployeeSelection();
                            // Sales report message being called
                            NewSales.salesReportMessage();
                            break;
                        case "3":
                            SalesEmployee.AddSalesEmployee();
                            Console.WriteLine();
                            menuScreen();
                            break;
                        case "4":
                            Console.WriteLine("New Sale Info");
                            findSales();
                            break;
                        case "5":
                            Console.WriteLine("Goodbye!");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Please choose one of the 5 options");
                            break;
                    }
                }
            }
            
            //function that holds the sales message
            void SalesMessage()
            {
            Console.WriteLine($"Sales Agent: {SalesEmployee.SalesAgentSelection}");
                var salesAgent = SalesEmployee.SalesAgentSelection;
                Console.Write("Client: ");
                var client = Console.ReadLine();
                Console.Write("ClientID: ");
                var clientId = Console.ReadLine();
                Console.Write("Sale: $");
                var sale = Convert.ToInt32(Console.ReadLine());
                Console.Write("Recurring: ");
                var recurring = Console.ReadLine();
                Console.Write("Time Frame: ");
                var timeFrame = Console.ReadLine();

                SalesEmployee.listOfSales.Add(new NewSales(salesAgent, client, clientId, sale, recurring, timeFrame));

                Console.WriteLine();
                menuScreen();
            }

            void findSales()
            {
                Console.WriteLine("Enter a Client ID to find the sales report!");
                var searchSale = Console.ReadLine();
                var sale = from s in SalesEmployee.listOfSales
                              where s.ClientID == searchSale
                              select s;
                foreach (var s in sale) {
                    Console.WriteLine($"Sales Agent: {s.SalesAgent}");
                    Console.WriteLine($"ClientID: {s.ClientID}");
                    Console.WriteLine($"Sale: ${s.Sale}");
                    Console.WriteLine($"Recurring: {s.Recurring}");
                    Console.WriteLine($"Time Frame:{s.TimeFrame} ");
                }
                //foreach (var salesPerson in SalesEmployee)
                //{
                //    var foundSale = salesPerson.ListOfSales.Find(sale => sale.ClientId == searchSale);
                //    if (foundSale != null)
                //    {
                //        Console.WriteLine($"Sales Agent {salesPerson.FirstName} {salesPerson.LastName}");
                //        Console.WriteLine($"ClientID: {foundSale.ClientId}");
                //        Console.WriteLine($"Sale: ${foundSale.Sale}");
                //        Console.WriteLine($"Recurring: {foundSale.Recurring}");
                //        Console.WriteLine($"Time Frame:{foundSale.TimeFrame} ");
                //    }    
                //}
            }

            //function that holds the menu screen
            void menuScreen()
            {
                Console.WriteLine("1. Enter Sales");
                Console.WriteLine("2. Generate Report For Accountant");
                Console.WriteLine("3. Add New Sales Employee");
                Console.WriteLine("4. Find A Sale");
                Console.WriteLine("5. Exit");
            }












        }

        

        
    }
}

