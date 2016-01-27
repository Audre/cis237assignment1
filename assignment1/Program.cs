using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInput();

            while (choice != 2)
            {
                switch (choice)
                {
                    case 1:
                        {
                            CSVProcessor file = new CSVProcessor();
                            file.OpenFile();
                            file.ToWineItem();
                            Console.WriteLine("File successfully loaded.");
                            break;
                        }
                    case 2:
                        {

                        }
                }
            }



        }
    }
}
