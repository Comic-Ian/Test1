using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test1
{
    class Helllworld
    {

        static int num1 = 0;
        static int num2 = 0;

        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            //Console.WriteLine("Hello World!!!");

            //Rectangle r = new Rectangle();
            //r.Display();

            //Exchange e = new Exchange();

            Int32 a = 2;
            Int16 b = (Int16)a;

            String c = "";
            bool isempty = string.IsNullOrEmpty("");


            int? nulla = null;

            Type atype = typeof(Int32);
            Type anulltype = typeof(Int32?);
            try
            {
                int x = 0;

                int y = 0;
                int xx = x / y;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Console.WriteLine("请输入a的值：");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入b的值：");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("交换之前a的值：{0}", a);
            //Console.WriteLine("交换之前b的值：{0}", b);

            //e.swap(ref a, ref b);

            //Console.WriteLine("交换之后a的值：{0}", a);
            //Console.WriteLine("交换之后b的值：{0}", b);

            //CarModel car = new CarModel();
            //car.CarName = "xxxx";
            //car.CarNo = 100;

            //car.SetCarType(9);

            //Console.WriteLine(car.CarName);


            IFunc peoplefunc = new People();
            peoplefunc.Eat();
            peoplefunc.Eat("11111");

            People peolerun = new People();
            peolerun.Runs();
            peolerun.Runs2();


            IFunc pigfunc = new Pig();
            pigfunc.Eat();

            Console.ReadKey(false);
        }
    }
}
