using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Verwendung Open Read() ReadLine()

namespace CrazyCarKonfigurator
{
    internal class Class_EinlesenCSV
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"D:\New folder\Data.csv"));
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
                foreach (var coloumn1 in listA)
                {
                    Console.WriteLine(coloumn1);
                }
                foreach (var coloumn2 in listA)
                {
                    Console.WriteLine(coloumn2);
                }
            }
        }
    }
}
*/


/* Verwendung TextFieldParser
 
using System;
using Microsoft.VisualBasic.FileIO;

class ReadingCSV
{
    public static void Main()
    {
        string coloumn1;
        string coloumn2;
        var path = @"D:\New folder\Data.csv";
        using (TextFieldParser csvReader = new TextFieldParser(path))
        {
            csvReader.CommentTokens = new string[] { "#" };
            csvReader.SetDelimiters(new string[] { "," });
            csvReader.HasFieldsEnclosedInQuotes = true;

            // Skip the row with the column names
            csvReader.ReadLine();

            while (!csvReader.EndOfData)
            {
                // Read current line fields, pointer moves to the next line.
                string[] fields = csvReader.ReadFields();
                coloumn1 = fields[0];
                coloumn2 = fields[1];
            }

        }
    }
}

*/