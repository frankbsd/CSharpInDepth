using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_01.Model
{
    public static class StaticCounter
    {
        static int next = 1;
        public static int Next()
        {
            return next++;
        }
    }
}
