using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class Class1
    {
        private float b;
        private float h;

        public Class1(float b, float h)
        {
            this.b = b; this.h = h; 
        }

        public float Area()
        { return b * h; }
    }
}
