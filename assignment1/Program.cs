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
            bool isLoadedCSV = false;
            UserInterface ui = new UserInterface();
            WineItem wineItem = new WineItem();
            WineItemCollections wineItemCollection = new WineItemCollections();
            CSVProcessor file = new CSVProcessor();


            int choice = ui.GetUserInput();

            while (choice != 5) // exits program if user selects 5, otherwise menu keeps displaying
            {
                switch (choice)
                {
                    case 1:
                        {
                            if (!isLoadedCSV) // loads file first time, afterward displays that it's already been loaded
                            {
                                file.ImportCSV("../../../datafiles/WineList.csv", wineItemCollection);
                                Console.WriteLine("File successfully loaded.");
                                Console.WriteLine();
                                isLoadedCSV = true;
                            }
                            else
                            {
                                Console.WriteLine("File has already been loaded.");
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2: 
                        {
                            // displays all wine items
                            Console.WriteLine(wineItemCollection.ToString());
                            Console.WriteLine();
                            break;
                        }

                    case 3:
                        {
                            // allows user to search for wine by ID and displays wine info or that wine does not exist
                            Console.WriteLine("Enter the ID you wish to search for: ");
                            string userSearch = Console.ReadLine();
                            wineItemCollection.SearchWine(userSearch);
                            Console.WriteLine();
                            break;
                        }

                    case 4:
                        {
                            // allows user to add wine item to array

                            
                            Console.WriteLine("Please enter the wine ID: ");
                            string userID = Console.ReadLine();

                            Console.WriteLine("Please enter the wine description: ");
                            string userDescription = Console.ReadLine();

                            Console.WriteLine("Please enter the wine pack: ");
                            string userPack = Console.ReadLine();

                            WineItem userWineItem = new WineItem(userID, userDescription, userPack);
                            wineItemCollection.AddWineItem(userWineItem);

                            Console.WriteLine();
                            Console.WriteLine(userWineItem.ToString() + " successfully added.");
                            Console.WriteLine();
                            break;
                        }
                }

                choice = ui.GetUserInput();
            }



        }
    }
}
