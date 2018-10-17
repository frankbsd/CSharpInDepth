using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test11_01.Model;

namespace Test11_15
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var query = from user in SampleData.AllUsers
                        from project in SampleData.AllProjects
                        select new { User = user, Project = project };

            foreach (var pair in query)
            {
                Console.WriteLine("{0}/{1}", pair.User.Name, pair.Project.Name);
            }

            Console.ReadKey();
        }
    }
}
