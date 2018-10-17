using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test15_04
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
            Console.ReadKey();
        }

        async static Task MainAsync()
        {
            Task<string> task = ReadFileSync("garbage file");
            try
            {
                string text = await task;
                Console.WriteLine("File contents: {0}", text);
            }
            catch (IOException e)
            {
                Console.WriteLine("Caught IOException: {0}", e.Message);
            }
        }

        async static Task<string> ReadFileSync(string fileName)
        {
            using (var reader = File.OpenText(fileName))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
