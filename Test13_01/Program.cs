using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dump(1, 2, 3);
            Dump(1, 2);
            Dump(1);

            //错误！
            //尽管编译器可以对可选参数和实参进行一些智能分析，来确定省略的参数类型，但它并没有这么做
            //它假设我们提供的实参顺序和参数定义的顺序是一样的
            //当漏掉一个实参时，编译器假设省略的为最后一个参数，然后倒数第二个参数，以此类推
            //TwoOptionalParameter("second");
            Console.ReadKey();
        }

        static void Dump(int x, int y = 20, int z = 30)
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }


        static void TwoOptionalParameter(int x = 10,string y = "default")
        {
            Console.WriteLine("x={0} y={1}", x, y);
        }
    }
}
