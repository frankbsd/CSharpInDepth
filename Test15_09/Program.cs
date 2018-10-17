using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, Task<int>> function = async x =>
              {
                  Console.WriteLine("Starting... x={0}", x);
                  await Task.Delay(x * 1000);
                  Console.WriteLine("Finish.. x={0}", x);
                  return x * 2;
              };


            Task<int> first = function(5);
            Task<int> second = function(3);
            Console.WriteLine("First result: {0}", first.Result);
            Console.WriteLine("Second result: {0}", second.Result);

            Console.ReadKey();
        }
    }
}
