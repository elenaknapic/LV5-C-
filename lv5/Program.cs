using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace lv5
{
    class Program
    {

        static void Main(string[] args)
        {
            //Z3
            //Dataset data = new Dataset(@"C:\Users\Elena\Source\Repos\lv5\lv5\bin\Debug\dat.cvs");
            //DataConsolePrinter.printData(data);

            //IDataset virtualpd = new VirtualProxyDataset(@"C:\Users\Elena\Source\Repos\lv5\lv5\bin\Debug\dat.cvs");
            //DataConsolePrinter.printData(virtualpd);

            //User user = User.GenerateUser("1.");
            //User usersec = User.GenerateUser("2.");
            //IDataset protectionproxy = new ProtectionProxyDataset(user);
            //IDataset protectionproxyd = new ProtectionProxyDataset(usersec);
            //DataConsolePrinter.printData(protectionproxy);
            //DataConsolePrinter.printData(protectionproxyd);

            //Z4
            //ITheme theme = new Theme2();
            //ReminderNote reminderNote = new ReminderNote("color", theme);
            //reminderNote.Show();

            //Z5
            //Grupa group = new Grupa("bilješka", theme);
            //group.AddinGroup("Elena");
            //group.AddinGroup("Lena");
            //group.Show();
            //group.RemovefromGroup("Lena");
            //group.Show();

            //Z6
            double[] a = { 3, 0, 2, 5, -1, 4, 1 };
            SortStrategy bubblesort = new BubbleSort();
            SortStrategy combsort = new CombSort();
            SortStrategy seqsort = new SequentialSort();
            NumberSequence number = new NumberSequence(a);
            NumberSequence sequenceSize = new NumberSequence(7);

            number.SetSortStrategy(bubblesort);
            number.Sort();
            number.ToString();
            number.SetSortStrategy(combsort);
            number.Sort();
            number.ToString();
            number.SetSortStrategy(seqsort);
            number.Sort();
            number.ToString();

 
        }
    }
}
