using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Test13_12;

namespace Test13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //委托的协变性
            Func<Square> squareFactory = () => new Square(new Point(5, 5), 10);
            Func<IShape> shapeFactory = squareFactory;

            //委托的逆变性
            Action<IShape> shapePrinter = shape => Console.WriteLine(shape.Area);
            Action<Square> squarePrinter = shapePrinter;


            squarePrinter(squareFactory());
            shapePrinter(shapeFactory());


            Converter<object, string> converter = x => x.ToString();
            Converter<string, string> contravariance = converter;
            Converter<object, object> convariance = converter;
            Converter<string, object> both = converter;
            Console.ReadKey();
        }
    }
}
