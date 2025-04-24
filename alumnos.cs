using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class alumnos
    {
        private string Nombre;
        private float nota1;
        private float nota2;
        private float nota3;

        public alumnos(string nombre, float nota1, float nota2, float nota3)
        {
            Nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public string Name() => Nombre;
        public float promedio() => ((nota1 + nota2 + 2 * nota3) / 4);

      
       
    }
}
