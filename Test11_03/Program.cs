using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new Dummy<string>();
            var query = from dummy in source
                        where dummy.ToString() == "Ignored"
                        select "Anything";

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }

    static class Extensions
    {
        public static Dummy<T> Where<T>(this Dummy<T> dummy,Func<T,bool> predicate)
        {
            Console.WriteLine("Where called");
            return dummy;
        }
    }

    class Dummy<T>
    {
        public Dummy<U> Select<U>(Func<T,U> selector)
        {
            Console.WriteLine("Select called");
            return new Dummy<U>();
        }
    }
}
