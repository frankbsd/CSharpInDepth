using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from user in SampleData.AllUsers
                        orderby user.Name.Length
                        select user.Name;
            foreach (var name in query)
            {
                Console.WriteLine("{0}: {1}", name.Length, name);
            }

            var query2 = from user in SampleData.AllUsers
                         let length = user.Name.Length
                         orderby length
                         select new { Name = user.Name, Length = length };
            foreach (var name in query2)
            {
                Console.WriteLine("{0}: {1}", name.Length, name.Name);
            }

            Console.ReadKey();
        }
    }
}
