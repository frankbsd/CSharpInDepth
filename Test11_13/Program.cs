using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from defect in SampleData.AllDefects
                        join subscription in SampleData.AllSubscriptions
                          on defect.Project equals subscription.Project
                          into groupedSubscriptions
                        select new { Defect = defect, Subscription = groupedSubscriptions };
            foreach (var entry in query)
            {
                Console.WriteLine(entry.Defect.Summary);
                foreach (var subscription in entry.Subscription)
                {
                    Console.WriteLine("     {0}", subscription.EmailAddress);
                }
            }

            Console.ReadKey();

        }
    }
}
