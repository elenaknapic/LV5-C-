using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z4
    interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);
    }
}
