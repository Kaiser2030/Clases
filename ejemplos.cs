using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class ejemplos
    {
        public void Start()
        {
            Triangle t1 = new Triangle(3, 7);
            Triangle t2 = new Triangle(4, 8);

            Triangle[] tris = { t1, t2, new Triangle(1, 1) };
            //tris[3] = new Triangle(1, 2);

            List<Triangle> list = new List<Triangle>();
            list.Add(t1);
            list.Add(t2);
            

            Console.WriteLine(list.Count);

            list.Add(new Triangle(1, 2));
            Console.WriteLine(list.Count);

            Triangle r = list.Find(x => x.Area() == 5);

            list.Remove(t1);

            Console.WriteLine(list.Count);

            
        }
    }
}
