using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        StreamReader inputFile;
        String readLine = String.Empty;

        public void OpenFile()
        {
            inputFile = File.OpenText(@"../../../datafiles\WineList.csv");
        }

        public void ReadFile()
        {

            readLine = inputFile.ReadLine();
        }

        public void ToWineItem()
        {
            String[] fileArray = new String[3];
            while (!inputFile.EndOfStream)
            {
                this.ReadFile();
                fileArray = readLine.Split(',');

                WineItem wineItem = new WineItem(fileArray[0], fileArray[1], fileArray[2]);
                //Console.WriteLine(wineItem.ToString());
                WineItemCollections wineItemCollection = new WineItemCollections(wineItem);
                //Console.WriteLine(wineItemCollection.ToString());
            }
            

        }
        
    }
}
