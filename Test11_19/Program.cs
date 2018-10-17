using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from defect in SampleData.AllDefects
                        where defect.AssignedTo != null
                        group defect by defect.AssignedTo into grouped
                        select new { Assignee = grouped.Key, Count = grouped.Count() };

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}", entry.Assignee.Name, entry.Count);
            }

            Console.ReadKey();
        }
    }
}
