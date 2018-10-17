using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from defect in SampleData.AllDefects
                        where defect.AssignedTo != null
                        group defect.Summary by defect.AssignedTo;

            foreach (var entry in query)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var summary in entry)
                {
                    Console.WriteLine("     {0}", summary);
                }
            }

            Console.ReadKey();
        }
    }
}
