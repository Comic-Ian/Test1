using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exchange
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            int max;

            temp = x;
            x = y;
            y = temp;

            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }

            Console.WriteLine("较大的值为：{0}", max);
            Console.ReadLine();

        }




    }
}
