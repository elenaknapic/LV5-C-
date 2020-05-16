using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //z4
    class Theme2 : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
