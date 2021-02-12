using System;
using dufflin_munder.Employee;
using dufflin_munder.Sales;

namespace dufflin_munder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate instance of the class with the list
            SalesEmployee salesList = new SalesEmployee();

            //Calls menu screen
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
                            Console.WriteLine("Generate A Report");
                            break;
                        case "3":
                            Console.WriteLine("Update employee");
                            break;
                        case "4":
                            Console.WriteLine("New Sale Info");
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

                salesList.listOfSales.Add(new NewSales(salesAgent, client, clientId, sale, recurring, timeFrame));

                Console.WriteLine("\n\n");
                menuScreen();
            }

            //function that holds the menu screen
            void menuScreen()
            {
                Console.WriteLine("Welcome to Dufflin/Munder Cardboard Co. ");
                Console.WriteLine("Sales Portal");
                Console.WriteLine("1. Enter Sales");
                Console.WriteLine("2. Generate Report For Accountant");
                Console.WriteLine("3. Add New Sales Employee");
                Console.WriteLine("4. Find A Sale");
                Console.WriteLine("5. Exit");
            }












        }

        

        
    }
}

