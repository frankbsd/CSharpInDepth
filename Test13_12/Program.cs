using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test13_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口的协变性
            List<IShape> shapesByAdding = new List<IShape>();
            shapesByAdding.AddRange(Shapes.Circles);
            shapesByAdding.AddRange(Shapes.Squares);


            List<IShape> shapesByConcat = Shapes.Circles.Concat<IShape>(Shapes.Squares).ToList();


            //接口的逆变性
            IComparer<IShape> areaCompare = new AreaComparer();
            Shapes.Squares.Sort(areaCompare);
            foreach (var item in Shapes.Squares)
            {
                Console.WriteLine(item);
            }

            Shapes.Circles.Sort(areaCompare);
            foreach (var item in Shapes.Circles)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
