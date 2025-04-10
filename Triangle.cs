using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class Triangle
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            Console.WriteLine("Se creo un triangulo");
            this.b = b;
            this.h = h;
        }

        public Triangle (string b, string h)
        {
            this.b = float.Parse(b);
            this.h = float.Parse(h);
        }

        public float Area() 
        {
            return b * h / 2;
        }

      
         

    }
}
