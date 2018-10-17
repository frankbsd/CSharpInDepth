using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var dates = new DateTimeRange(SampleData.Start, SampleData.End);

            var query = from date in dates
                        join defect in SampleData.AllDefects
                        on date equals defect.Created.Date
                        into joined
                        select new { Date = date, Count = joined.Count() };

            foreach (var grouped in query)
            {
                Console.WriteLine("{0:d}: {1}", grouped.Date, grouped.Count);
            }

            Console.ReadKey();
        }
    }
}
