using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test16_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "x", "y","z" };
            var actions = new List<Action>();
            foreach (var value in values)
            {
                actions.Add(() => Console.WriteLine(value));
            }

            //在C# 5以前，显示3行"z",注意区别
            foreach (var action in actions)
            {
                action();
            }

            Console.ReadKey();
        }
    }
}
