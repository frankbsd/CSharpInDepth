using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test16_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInfo();
            ShowInfo("LiesAdndDamnedLies", -10);

            Console.ReadKey();
        }

        static void ShowInfo([CallerFilePath] string file = null,
                             [CallerLineNumber] int line=0,
                             [CallerMemberName] string member=null)
        {
            Console.WriteLine("{0}:{1}-{2}", file, line, member);
        }
    }
}
