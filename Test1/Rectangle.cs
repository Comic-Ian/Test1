using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Rectangle
    {

        int a;
        int b;
        public void Station()
        {
            Console.WriteLine("请输入a的值：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入b的值：");
            b = Convert.ToInt32(Console.ReadLine());
        }
        //加法
        public int addition()
        {
            return a + b;
        }
        //减法
        public int subtraction()
        {
            return a - b;
        }
        //乘法
        public int multiplication()
        {
            return a * b;
        }
        //除法
        public int divisionMethod()
        {
            return a / b;
        }

        public void Display()
        {
            Station();
            Console.WriteLine("ab之和为：{0}", addition());
            Console.WriteLine("ab之差为：{0}", subtraction());
            Console.WriteLine("ab之积为：{0}", multiplication());
            Console.WriteLine("ab之余为：{0}", divisionMethod());
        }
    }
}
