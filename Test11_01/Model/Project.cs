using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test11_01.Model
{
    public class Project
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Project: {0}", Name);
        }
    }
}
