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
            // add data to list of sales for easier testing
            SalesEmployee.listOfSales.Add(new NewSales("Dwight Hyte", "Angela Martin", "1", 65, "Monthly", "3 Months"));
            SalesEmployee.listOfSales.Add(new NewSales("Phyllis Leaf", "Bob Vance", "2", 60, "Monthly", "5 Months"));
            SalesEmployee.listOfSales.Add(new NewSales("Tim Halbert", "Pam B", "3", 80, "Monthly", "6 Months"));
            SalesEmployee.listOfSales.Add(new NewSales("Dwight Hyte", "Creed Bratton", "4", 24, "Monthly", "3 Months"));
            SalesEmployee.listOfSales.Add(new NewSales("Phyllis Leaf", "Stanley Hudson", "5", 36, "Monthly", "5 Months"));
            SalesEmployee.listOfSales.Add(new NewSales("Tim Halbert", "Mose Schrute", "6", 42, "Monthly", "6 Months"));

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
                            // Print Sales Message 
                            SalesMessage();
                            break;
                        case "2":
                            // Print Accountant Employees options to console
                            AccountantEmployee.AccountantEmployeesOptions();
                            // Determine user selection of Accountant and set to property
                            AccountantEmployee.AccountantEmployeeSelection();
                            // Sales report message being called
                            NewSales.salesReportMessage();
                            menuScreen();
                            break;
                        case "3":
                            // Method to add new Sales Employee
                            SalesEmployee.AddSalesEmployee();
                            Console.WriteLine();
                            menuScreen();
                            break;
                        case "4":
                            findSales();
                            menuScreen();
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
                Console.WriteLine($"\nSales Agent: {SalesEmployee.SalesAgentSelection}");
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

                Console.WriteLine("\nYour sales report was received. Back to the Sales Portal!\n");
                menuScreen();
            }

            void findSales()
            {
                Console.Write("\nEnter a Client ID to find the sales report: ");
                var searchSale = Console.ReadLine();
                var sale = from s in SalesEmployee.listOfSales
                           where s.ClientID == searchSale
                           select s;
                foreach (var s in sale) {
                    Console.WriteLine($"\nSales Agent: {s.SalesAgent}");
                    Console.WriteLine($"ClientID: {s.ClientID}");
                    Console.WriteLine($"Sale: ${s.Sale}");
                    Console.WriteLine($"Recurring: {s.Recurring}");
                    Console.WriteLine($"Time Frame:{s.TimeFrame} \n");
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

