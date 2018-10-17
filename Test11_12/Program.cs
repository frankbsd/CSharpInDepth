using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from defect in SampleData.AllDefects
                        where defect.Status == Status.Closed
                        join subscription in SampleData.AllSubscriptions
                            on defect.Project equals subscription.Project
                        //下面是错误的，编译器会提示
                        //on subscription.Project equals defect.Project
                        select new { defect.Summary, subscription.EmailAddress };

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}", entry.EmailAddress, entry.Summary);
            }


            Console.ReadKey();
        }
    }
}
