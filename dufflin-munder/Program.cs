using System;
using dufflin_munder.Employee;

namespace dufflin_munder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dufflin/Munder Cardboard Co. ");
            Console.WriteLine("Sales Portal");
            Console.WriteLine("1. Enter Sales");
            Console.WriteLine("2. Generate Report For Accountant");
            Console.WriteLine("3. Add New Sales Employee");
            Console.WriteLine("4. Find A Sale");
            Console.WriteLine("5. Exit");

            var running = true;
            while (running)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Which Sales Employee Are You?");
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
    }
}
