using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test15_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var task = DelayFor30Secnds(source.Token);
            source.CancelAfter(TimeSpan.FromSeconds(1));
            Console.WriteLine("Initial status: {0}", task.Status);

            try
            {
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Caught {0}", e.InnerExceptions[0]);
            }

            Console.WriteLine("Final status: {0}", task.Status);

            Console.ReadKey();
        }

        async static Task DelayFor30Secnds(CancellationToken token)
        {
            Console.WriteLine("Wating for 30 seconds....");
            await Task.Delay(TimeSpan.FromSeconds(30), token);
        }
    }
}
