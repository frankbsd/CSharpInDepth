using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            AppendTimeStamp("utf8.txt", "First message");
            AppendTimeStamp("ascii.txt", "ASCII", Encoding.ASCII);
            AppendTimeStamp("utf.txt", "Message in th future", null, new DateTime(2030, 1, 1));

            Console.ReadKey();
        }

        static void AppendTimeStamp(string filename,string message,Encoding encoding=null, DateTime? timeStamp = null)
        {
            Encoding realEncoding = encoding ?? Encoding.UTF8;
            DateTime realTimeStamp = timeStamp ?? DateTime.Now;

            using(TextWriter writer=new StreamWriter(filename, true, realEncoding))
            {
                writer.WriteLine("{0:s}: {1}", realTimeStamp, message);
            }
        }
    }
}
