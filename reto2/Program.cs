using System;

namespace reto2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int n1 = 1; n1 <= 1184; n1++)
            {
                for (int n2 = n1 + 1; n2 <= 285; n2++)
                {
                    encontrarAmigos(n1, n2);
                }
            }

            /*
       Console.Write("Dame un numero: ");
       int valor1 = int.Parse(Console.ReadLine());

       Console.Write("Dame otro numero: ");
       int valor2 = int.Parse(Console.ReadLine());

       if (amigos(valor1, valor2))
       {
           Console.WriteLine("Los valores de " + valor1 + " y " + valor2 + " son numeros amigos.");
       }

       else

       {
           Console.WriteLine("Los valores de " + valor1 + " y " + valor2 + " no son numeros amigos.");
       }
       */
        }

        public static int sumaFactores(int n)
        {
            int s = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    s += i;
                }
            }
            return s;
        }


        // Método para verificar si dos números son amigos y proporcionar una justificación
        public static void encontrarAmigos(int n1, int n2)
        {
            int sumaFactoresN1 = sumaFactores(n1);
            int sumaFactoresN2 = sumaFactores(n2);

            if (sumaFactoresN1 == n2 && sumaFactoresN2 == n1)
            {
                Console.WriteLine(n1 + " y " + n2 + " son numeros amigos.");
                Console.WriteLine("La suma de los divisores propios de " + n1 + " es " + sumaFactoresN1);
                Console.WriteLine("La suma de los divisores propios de " + n2 + " es " + sumaFactoresN2);
            }
            else { Console.WriteLine(n1 + " y " + n2 + " no son numeros amigos"); }
        }


       

    }


    /*

        public static int problema(int value)

        {
            int addition = 0;
            for (int i = 1; i <= value / 2; i++)
            {
                if (value % i == 0)
                {
                    addition += i;
                }
            }
            return addition;
        }

        public static bool amigos(int value1, int value2)

        {

            return (problema(value1) == value2)

            && (problema(value2) == value1);


        }

    */

}
