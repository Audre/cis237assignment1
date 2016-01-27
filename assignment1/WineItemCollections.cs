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
        private WineItem[] wineItemCollection = new WineItem[4000];

        // default constructor
        public WineItemCollections()
        {

        }

        public WineItemCollections(WineItem wineItem)
        {
            wineItemCollection[0] = wineItem;
        }

        public void AddWineItem(WineItem wineItem)
        {

        }

        public override string ToString()
        {
            bool isEmpty = true;
            string wineConcat = "";
            foreach (WineItem wineItem in wineItemCollection)
            {
                if (wineItem != null)
                {
                    isEmpty = false;
                    wineConcat += wineItem.ToString();
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
