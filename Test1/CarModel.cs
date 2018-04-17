using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class CarModel
    {

        public string CarName { get; set; }


        private int carno = 0;

        public int CarNo
        {

            get
            {
                return carno;
            }
            set
            {
                this.carno = value;
            }

        }

        private int CarType { get; set; }

        public void SetCarType(int type)
        {
            this.CarType = type;
        }

    }




    public interface IFunc
    {

        void Eat();

        void Eat(string name);

    }


    public abstract class Run
    {
        public abstract void Runs();
        public virtual void Runs2()
        {
            Console.WriteLine("虚方法:1");
        }

    }



    public class People : Run, IFunc
    {

        #region Eat feeee


        public void Eat()
        {
            Console.WriteLine("人吃饭");
        }
        #endregion
        public void Eat(string name)
        {
            Console.WriteLine(name + "吃饭");
        }

        public override void Runs()
        {
            Console.WriteLine("重写抽象方法");
        }

        //public override void Runs2()
        //{
        //    Console.WriteLine("重写虚方法后的数:3");
        //}

    }

    public class Pig : IFunc
    {
        public void Eat()
        {
            Console.WriteLine("猪吃饭");
        }
        public void Eat(string name)
        {
            Console.WriteLine(name + "吃饭");
        }
    }

}
