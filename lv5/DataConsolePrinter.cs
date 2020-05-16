using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z3
    class DataConsolePrinter
    {
        public static void printData(IDataset dataset)
        {
            try
            {
                List<List<string>> print = new List<List<string>>(dataset.GetData());
                foreach (List<string> list in print)
                {

                    foreach (string s in list)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("/n");
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Unkown type");
            }

        }

        internal static void printData(Dataset data)
        {
            throw new NotImplementedException();
        }
    }
}
