using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from left in Enumerable.Range(1, 4)
                        from right in Enumerable.Range(11, left)
                        select new { Left = left, Right = right };

            foreach (var pair in query)
            {
                Console.WriteLine("{0}  -----   {1}", pair.Left, pair.Right);

            }

            Console.ReadKey();
        }
    }
}
