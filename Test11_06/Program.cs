using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_06
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList { "First", "Second", "Third" };
            var strs = from string entity in list
                       select entity.Substring(0, 3);
            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
