using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nElige figura: 1.Rectángulo  2.Círculo  3.Triángulo");
                string op = Console.ReadLine();

                if (op == "1")
                {
                    Console.Write("Base: "); int b = int.Parse(Console.ReadLine());
                    Console.Write("Altura: "); int h = int.Parse(Console.ReadLine());
                    var r = new rectangulo(b, h);
                    Console.WriteLine($"Área del rectángulo: {r.Area()}");
                }
                else if (op == "2")
                {
                    Console.Write("Radio: "); int r = int.Parse(Console.ReadLine());
                    var c = new Circulo(r);
                    Console.WriteLine($"Área del círculo (aprox): {c.Area()}");
                }
                else if (op == "3")
                {
                    Console.Write("Base: "); int b = int.Parse(Console.ReadLine());
                    Console.Write("Altura: "); int h = int.Parse(Console.ReadLine());
                    var t = new Triangle(b, h);
                    Console.WriteLine($"Área del triángulo: {t.Area()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.Write("¿Otra figura? (s para seguir / otra tecla para salir): ");
                string seguir = Console.ReadLine().ToLower();
                if (seguir != "s")
                    break;
            }

            Console.WriteLine("Fin del programa.");

            while (true) 
            {
                Console.Write("Ingresa el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Ingresa la operación [+,-,*,/, %]: ");
                string operacion = Console.ReadLine();

                int resultado = 0;
                bool valido = true;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: división por cero");
                            valido = false;
                        }
                        break;
                    case "%":
                        if (num2 != 0)
                            resultado = num1 % num2;
                        else
                        {
                            Console.WriteLine("Error: módulo por cero");
                            valido = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no válida");
                        valido = false;
                        break;
                }

                if (valido)
                    Console.WriteLine("Resultado: " + resultado);

                Console.ReadLine();
            }
        }
            
        

    }
    
}
