using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_07
{
    class Program
    {
        static void Main(string[] args)
        {
            User tim = SampleData.Users.TesterTim;
            var query = from defect in SampleData.AllDefects
                            //where defect.Status != Status.Closed
                            //where defect.AssignedTo == tim
                        where defect.Status != Status.Closed && defect.AssignedTo == tim
                        select defect.Summary;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****");
            query = from defect in SampleData.AllDefects
                    select defect.Summary;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var query2 = from defect in SampleData.AllDefects
                         where defect.Status != Status.Closed
                         where defect.AssignedTo == tim
                         select defect;
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
