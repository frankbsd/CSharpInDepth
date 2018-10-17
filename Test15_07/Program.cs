using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = ThrowCancellationException();
            Console.WriteLine(task.Status);
            Console.ReadKey();
        }

        static async Task ThrowCancellationException()
        {
            throw new OperationCanceledException();
        }
    }
}
