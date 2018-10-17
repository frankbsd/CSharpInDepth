using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test13_04
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Dump(x: ++i, y: ++i, z: ++i);
            i = 0;
            Dump(z: ++i, x: ++i, y: ++i);

            Console.ReadKey();
            
        }

        static int Log(int value)
        {
            Console.WriteLine("Log: {0}",value);
            return value;
        }

        static void Dump(int x, int y, int z)
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }


    }
}
