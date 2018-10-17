using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test13_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dump(1, 2, 3);
            Dump(z: 3, y: 2, x: 1);
            Dump(1, z: 3, y: 2);


            Console.ReadKey();
        }

        static void Dump(int x,int y ,int z)
        {
            Console.WriteLine("x={0} y={1} z={2}", x, y, z);
        }
    }
}
