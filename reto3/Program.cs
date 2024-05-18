namespace reto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;

            while(ciclo)
            {
                algoritmo();
                space();

                Console.Write("-Hacer otro conversion (Presiona 1) \n-Salir del Programa (Presiona 2) \n-Elige una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine('\n');
                    Console.WriteLine('\n');
                    Console.WriteLine('\n');
                }
                else if (opcion == 2)
                {
                    ciclo = false;
                }
            }
        }

        public static void algoritmo()
        {

            Console.WriteLine("Conversiones Computacionales \n");
            string[] menu = { "Convertir de decimal a binario (Presiona 1)", "Convertir de decimal a octal (Presiona 2)", "Convertir de binario a decimal (Presiona 3)", "Convertir de octal a decimal (Presiona 4)", "Convertir de hexadecimal a decimal (Presiona 5)" };

            for (int i = 0; i < menu.Length; i++)
            {
                string myMenu = menu[i];

                Console.WriteLine((i + 1) + "-" + myMenu);
            }

            Console.Write("\nElige una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            
            space();

            switch(opcion)
            {
                //Decimal a Binario
                case 1:
                    Console.Write("Escribe un numero decimal: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(valor + " en binario: " + DecimalToBinary(valor));    

                    break;

                //Decimal a Octal
                case 2:
                    Console.Write("Escribe un numero decimal: ");
                    int valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(valor1 + " en octal: " + DecimalToOctal(valor1));

                    break;

                //Binario a Decimal
                case 3:
                    Console.Write("Escribe un numero binario: ");
                    string valor2 = Console.ReadLine();
                    Console.WriteLine(valor2 + " en decimal: " + BinaryToDecimal(valor2));

                    break;

                //Octal a Decimal
                case 4:
                    Console.Write("Escribe un numero octal: ");
                    string valor3 = Console.ReadLine();
                    Console.WriteLine(valor3 + " en decimal: " + OctalToDecimal(valor3));   

                    break;
                //Hexadecimal a Decimal
                case 5:
                    Console.Write("Escribe un numero hexadecimal: ");
                    string valor4 = Console.ReadLine();
                    Console.WriteLine(valor4 + " en decimal: " + HexadecimalToDecimal(valor4)); 

                    break;
            }


        }

        public static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public static string DecimalToOctal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 8);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public static int OctalToDecimal(string octalNumber)
        {
            return Convert.ToInt32(octalNumber, 8);
        }


        public static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            return Convert.ToInt32(hexadecimalNumber, 16);
        }

        public static void space()
        {
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
        }


    }
}