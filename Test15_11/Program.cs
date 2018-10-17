using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = SumCharactersAsync("test");
            Console.WriteLine(task.Result);
            Console.ReadKey();
        }

        async static Task<int> SumCharactersAsync(IEnumerable<char> text)
        {
            int total = 0;
            foreach (var ch in text)
            {
                int unicode = ch;
                await Task.Delay(unicode * 10);
                total += unicode;
                Console.WriteLine(string.Format("unicode:{0}\ttotal:{1}", unicode, total));
            }

            await Task.Yield();
            Console.WriteLine(total);
            return total;
        }
    }
}
