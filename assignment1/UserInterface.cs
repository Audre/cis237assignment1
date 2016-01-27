using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public int GetUserInput()
        {
            this.PrintMenu();

            String input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("This is not a valid entry. Please enter either 1, 2, 3, 4, or 5.");
                Console.WriteLine();
                this.PrintMenu();
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("     1. Load List" + Environment.NewLine +
                              "     2. Print List" + Environment.NewLine +
                              "     3. Search For an Item" + Environment.NewLine +
                              "     4. Add New Wine" + Environment.NewLine +
                              "     5. Exit");
        }
    }
}
