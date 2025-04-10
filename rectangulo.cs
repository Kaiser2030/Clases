using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class rectangulo
    {
        public int Base, Altura;
        public rectangulo(int b, int h) { Base = b; Altura = h; }
        public int Area() { return Base * Altura; }
    }
}
