using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from user in Model.SampleData.AllUsers
                        select user;

            //=>执行真正的编译之前，上面语句转换成下面的语句
            var query2 = Model.SampleData.AllUsers.Select(user => user);

            foreach (var user in query)
            {
                Console.WriteLine(user);
            }

            Console.ReadKey();
        }
    }
}
