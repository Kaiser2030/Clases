using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class Circulo
    {
        public int Radio;
        public Circulo(int r) { Radio = r; }
        public int Area() { return (int)(3.14 * Radio * Radio); }
    }
}
