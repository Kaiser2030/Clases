using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class salon
    {
        private List<alumnos> lista = new List<alumnos>();

        public void Start()
        {
            

            int Opcion=int.Parse(Console.ReadLine());

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Que quiere hacer?");
                Console.WriteLine("1. Ingresar Alumno\n2. Remover Alumno\n3. Mostrar Alumnos");
            }

            switch (Opcion)
            {
                case 1:

                    IngresarAlumno();

                    break;
                        case 2:

                
                default: break;
            }

           
        }

        public void IngresarAlumnos()
        {
            string nombre = Console.ReadLine();
            float nota1 = float.Parse(Console.ReadLine());
            float nota2= float.Parse(Console.ReadLine());
            float nota3= float.Parse(Console.ReadLine());

            alumnos mewalumno = new alumnos(nombre, nota1, nota2, nota3);
            lista.Add(mewalumno);
        }

        //public string Lista() => lista;




    }
}
