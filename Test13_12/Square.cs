using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Test13_12
{
    public sealed class Square : IShape
    {
        private readonly Point topLeft;
        private readonly double sideLength;

        public Square(Point topLeft, double sideLength)
        {
            this.topLeft = topLeft;
            this.sideLength = sideLength;
        }

        public double Area
        {
            get { return sideLength * sideLength; }
        }

        public Rect BoundingBox
        {
            get
            {
                return new Rect(topLeft, new Size(sideLength, sideLength));
            }
        }

        public override string ToString()
        {
            return string.Format("TopLeft:{0} SideLength:{1} Area:{2}", topLeft, sideLength, Area);
        }
    }
}
