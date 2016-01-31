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
        // opens file at path passed in, processes file, then closes file when done. 
        public bool ImportCSV(string pathToCSVFile, WineItemCollections wineItemCollection)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);
                 

                while ((line = streamReader.ReadLine()) != null)
                {
                    ProcessLine(line, wineItemCollection);
                }

                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        // processes file - splits line at commas into 3-element array, each element is then
        // passed to wineItem and then added to wineItemCollection array. 
        public void ProcessLine(string line, WineItemCollections wineItemCollection)
        {
            string[] fileArray = line.Split(',');

            WineItem wineItem = new WineItem(fileArray[0], fileArray[1], fileArray[2]);
            wineItemCollection.AddWineItem(wineItem);

        }
    }
}
