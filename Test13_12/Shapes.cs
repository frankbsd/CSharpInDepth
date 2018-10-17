using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Test13_12
{
    public static class Shapes
    {
        private static readonly List<Circle> circles = new List<Circle>
        {
            new Circle (new Point(0,0),15),
            new Circle(new Point(10,5),20)
        };

        private static readonly List<Square> squares = new List<Square>
        {
            new Square(new Point(5,10),5),
            new Square (new Point(-10,0),2)
        };

        public static List<Circle> Circles { get { return circles; } }
        public static List<Square> Squares { get { return squares; } }
    }
}
