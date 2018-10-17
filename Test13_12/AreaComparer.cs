using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test13_12
{
    class AreaComparer : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            return x.Area.CompareTo(y.Area);
        }
    }
}
