using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dufflin_munder.Employee
{
    class SalesEmployee : Employee
    {
        public static List<string> SalesEmployees = new List<string>() { "Dwight Hyte", "Tim Halbert", "Phyllis Leaf" };
        // Store user selection of Sales Agent
        public static string SalesAgentSelection;
        public static string FirstName;

        public static void SalesEmployeesOptions()
        {
            Console.WriteLine("Which Sales Employee Are You?");
            // Use num to number the list of employee options
            int num = 1;
            // Loop through SalesEmployees and print to console
            foreach (string employee in SalesEmployees)
            {
                Console.WriteLine($"{num}. {employee}");
                num++;
            }
        }

        public static void SalesEmployeeSelection()
        {
            int userinput = Convert.ToInt32(Console.ReadLine());
            // Use user input to determine index of employee in List
            int index = userinput - 1;
            // Set property to user selection
            SalesAgentSelection = SalesEmployees[index];
            // Split full name and set first name to variable in order to greet agent
            string[] splitName = SalesAgentSelection.Split(" ");
            FirstName = splitName[0];
            Console.WriteLine($"Hi, {FirstName}!");
        }
    }

}
