using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_05
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList { "First", "Second", "Third" };
            IEnumerable<string> strs = list.Cast<string>();
            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }

            list = new ArrayList { 1, "not an int", 2, 3 };
            IEnumerable<int> ints = list.OfType<int>();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
