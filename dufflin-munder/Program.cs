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
            //variables
            var client = string.Empty;
            var salesAgent = string.Empty;
            var clientId = string.Empty;
            decimal sale = 0;
            var recurring = string.Empty;
            var timeFrame = string.Empty;

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
                salesAgent = SalesEmployee.SalesAgentSelection;
                Console.Write("Client: ");
                client = Console.ReadLine();
                checkIfBlank(client);
                Console.Write("ClientID: ");
                clientId = Console.ReadLine();
                checkIfBlank(clientId);
                Console.Write("Sale: $");
                sale = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Recurring: ");
                recurring = Console.ReadLine();
                checkIfBlank(recurring);
                Console.Write("Time Frame: ");
                timeFrame = Console.ReadLine();
                checkIfBlank(timeFrame);

                SalesEmployee.listOfSales.Add(new NewSales(salesAgent, client, clientId, sale, recurring, timeFrame));

                Console.WriteLine();
                menuScreen();
            }

            void checkIfBlank(string check)
            {
                if (string.IsNullOrEmpty(check) && client == string.Empty)
                {
                    //Error message for leaving it blank
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Error! Client can't be empty!");
                    Console.WriteLine("-----------------------------\n");

                    //Re-Printing the sales message
                    Console.WriteLine($"Sales Agent: {SalesEmployee.SalesAgentSelection}");
                    salesAgent = SalesEmployee.SalesAgentSelection;
                    Console.Write("Client: ");
                    client = Console.ReadLine();
                    checkIfBlank(client);
                }
                else if (string.IsNullOrEmpty(check) && clientId == string.Empty)
                {
                    //Error message for leaving it blank
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Error! Client Id can't be empty!");
                    Console.WriteLine("-----------------------------\n");

                    //Re-Printing the sales message
                    Console.WriteLine($"Sales Agent: {SalesEmployee.SalesAgentSelection}");
                    salesAgent = SalesEmployee.SalesAgentSelection;
                    Console.WriteLine($"Client: {client}");
                    client = client;
                    Console.Write("ClientID: ");
                    clientId = Console.ReadLine();
                    checkIfBlank(clientId);
                }
                else if (string.IsNullOrEmpty(check) && recurring == string.Empty)
                {
                    //Error message for leaving it blank
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Error! Recurring can't be empty!");
                    Console.WriteLine("-----------------------------\n");

                    //Re-Printing the sales message
                    Console.WriteLine($"Sales Agent: {SalesEmployee.SalesAgentSelection}");
                    salesAgent = SalesEmployee.SalesAgentSelection;
                    Console.WriteLine($"Client: {client}");
                    client = client;
                    Console.WriteLine($"ClientID: {clientId}");
                    clientId = clientId;
                    Console.WriteLine($"Sale: ${sale}");
                    sale = sale;
                    Console.Write("Recurring: ");
                    recurring = Console.ReadLine();
                    checkIfBlank(recurring);
                }
                else if (string.IsNullOrEmpty(check) && timeFrame == string.Empty)
                {
                    //Error message for leaving it blank
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Error! Time Frame can't be empty!");
                    Console.WriteLine("-----------------------------\n");

                    //Re-Printing the sales message
                    Console.WriteLine($"Sales Agent: {SalesEmployee.SalesAgentSelection}");
                    salesAgent = SalesEmployee.SalesAgentSelection;
                    Console.WriteLine($"Client: {client}");
                    client = client;
                    Console.WriteLine($"ClientID: {clientId}");
                    clientId = clientId;
                    Console.WriteLine($"Sale: ${sale}");
                    sale = sale;
                    Console.WriteLine($"Recurring: {recurring}");
                    recurring = recurring;
                    Console.Write("Time Frame: ");
                    timeFrame = Console.ReadLine();
                    checkIfBlank(timeFrame);
                }
                else
                {
                  
                }
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

