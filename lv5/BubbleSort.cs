using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z6
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
          {
          
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        Swap(ref array[j + 1], ref array[j]);
                    }
                }
            }
        }
    }
}
