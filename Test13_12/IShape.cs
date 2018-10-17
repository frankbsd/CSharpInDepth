using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Test13_12
{
    public interface IShape
    {
        double Area { get; }
        
        Rect BoundingBox { get; }
    }
}
