using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_08
{
    class Program
    {
        static void Main(string[] args)
        {
            User tim = SampleData.Users.TesterTim;
            var query = from defect in SampleData.AllDefects
                        where defect.Status != Status.Closed
                        where defect.AssignedTo == tim
                        orderby defect.Severity descending, defect.LastModified
                        select defect;

            foreach (var item in query)
            {
                Console.WriteLine("{0}: {1} ({2:d})", item.Severity, item.Summary, item.LastModified);
            }

            Console.ReadKey();
        }
    }
}
