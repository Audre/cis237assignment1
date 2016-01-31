using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollections
    {
        // backing field
        private WineItem[] wineItems;
        private int index = 0;

        // default constructor
        public WineItemCollections()
        {
           wineItems = new WineItem[4000];
        }
        
        // property 
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        //public void AddWineItem(WineItem wineItem, int index)
        //{
        //    this.index = index;
        //    wineItems[index] = wineItem;
        //}

        // adds wineItem to array, increments counter for total items in array
        public void AddWineItem(WineItem userWine)
        {
            wineItems[this.index] = userWine;
            this.index++;
        }

        // searches array for user-input ID and prints out wine information if found
        // loops through array and converts each element into string, splits at spaces, 
        // then gets the ID (first entry) and compares that to what the user entered.
        // if found, displays wine info, otherwise displays wine is not found. 
        public void SearchWine(string wineToFind)
        {
            string tempString = string.Empty;
            string[] tempArray;
            bool isWineFound = false;

            for (int counter = 0; counter < index; counter ++)
            {

                tempString = wineItems[counter].ToString();
                tempArray = tempString.Split(' ');
                tempString = tempArray[0];
                if (tempString.Equals(wineToFind))
                {
                    tempString = wineItems[counter].ToString();
                    isWineFound = true;
                    break;
                }
            }

            if (isWineFound)
            {
                    Console.WriteLine(tempString);
            }
            else
            {
                    Console.WriteLine("That ID is not in the database.");
            }

        }

        // overrides ToString() method to display all items in wine array - 
        // goes through wineItems array and adds each element to variable to 
        // print all contents in array
        public override string ToString()
        {
            bool isEmpty = true;
            string wineConcat = "";
            foreach (WineItem wineItem in wineItems)
            {
                if (wineItem != null)
                {
                    isEmpty = false;
                    wineConcat += wineItem.ToString() + Environment.NewLine;
                }
            }
            if (isEmpty)
            {
                return "There are no wine items in the collection.";
            }
            else
            {
                return wineConcat;
            }
        }
    }
}
