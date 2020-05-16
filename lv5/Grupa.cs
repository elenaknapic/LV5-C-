using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z5
    class Grupa : Note
    {
        public List<string> list;

        public Grupa(string message, ITheme theme) : base(message, theme)
        {
            list = new List<string>();
        }
        public void AddinGroup(string name)
        {
            list.Add(name);
        }
        public void RemovefromGroup(string name)
        {
            list.Remove(name);
        }

        public static String Builder(List<string> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in lista)
            {
                stringBuilder.Append(s).Append(", ");
            }
            return stringBuilder.ToString();
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Grupa: ");
            string framedMessage = Builder(list);
            Console.WriteLine(framedMessage);
            Console.ResetColor();

        }


    }
}
