using System;
using System.Collections.Generic;
using System.Text;

namespace dufflin_munder.Employee
{
    class AccountantEmployee : Employee
    {
        static public string[] Accountant = { "Oscar", "Kevin" };
        public static string AccountantSelection;
        public static void AccountantEmployeesOptions()
        {
            Console.WriteLine("\nChoose An Accountant:");
            // Use num to number the list of employee options
            int num = 1;
            // Loop through SalesEmployees and print to console
            foreach (string employee in Accountant)
            {
                Console.WriteLine($"{num}. {employee}");
                num++;
            }

        }
            public static void AccountantEmployeeSelection()
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                // Use user input to determine index of employee in List
                int index = userinput - 1;
                // Set property to user selection
                AccountantSelection = Accountant[index];
            }
    }
}
