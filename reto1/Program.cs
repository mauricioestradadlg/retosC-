using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //calculadora();
            
            bool ciclo = true;

            while (ciclo)
            {
                calculadora();

                Console.Write("-Hacer otro calculo (Presiona 1) \n-Salir del Programa (Presiona 2) \n-Elige una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                if( opcion == 1 ) {
                    Console.WriteLine('\n');
                    Console.WriteLine('\n');
                    Console.WriteLine('\n');
                }
                else if( opcion == 2 )
                {
                    ciclo = false;
                }
            }
            

            
        }

        static void calculadora()
        {
            Console.WriteLine("Calculadora Aritmetica \n");
            string[] menu = { "Sumar (Presiona 1)", "Restar (Presiona 2)", "Multiplicar (Presiona 3)", "Dividir (Presiona 4)" };

            for (int i = 0; i < menu.Length; i++)
            {
                string myMenu = menu[i];

                Console.WriteLine((i + 1) + "-" + myMenu);
            }

            Console.Write("\nElige una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            double x;
            double y;


            switch(opcion)
            {
                case 1:
                    Console.Write("Numero 1: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado = " + sumar(x,y));
                    break;
                case 2:
                    Console.Write("Numero 1: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado = " + restar(x, y));
                    break;
                case 3:
                    Console.Write("Numero 1: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado = " + multiplicar(x, y));
                    break;
                case 4:
                    Console.Write("Numero 1: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado = " + dividir(x, y));
                    break;
                default:
                    Console.WriteLine("Elige una opcion valida!!");
                    break;
            }

        }

        static double sumar(double x, double y)
        {
            return x + y;
        }

        static double restar(double x, double y)
        {
            return x - y;
        }

        static double multiplicar(double x, double y)
        {
            return x * y;
        }

        static double dividir(double x, double y)
        {
            return x / y;
        }
    }
}
