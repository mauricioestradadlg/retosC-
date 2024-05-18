namespace reto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool ciclo = true;

                while (ciclo)
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
            catch (Exception ex)
            {
                Console.WriteLine("Hiciste algo mal: " + ex.ToString());
            }

            finally
            {
                Console.WriteLine("\n");
                Console.WriteLine("FIN DEL PROGRAMA");
            }
        }

        public static void algoritmo()
        {

            Console.WriteLine("Programa de Matrices \n");
            string[] menu = { "Suma de Matrices (Presiona 1)", "Multiplicar Entero por Matriz (Presiona 2)", "Impresion de Matriz (Presiona 3)" };

            for (int i = 0; i < menu.Length; i++)
            {
                string myMenu = menu[i];

                Console.WriteLine((i + 1) + "-" + myMenu);
            }

            Console.Write("\nElige una opcion: ");
            int opcion = int.Parse(Console.ReadLine());


            space();

            int filas;
            int columnas;
            int [][] matrix;

            switch (opcion)
            {
                //Suma de Matrices
                case 1:
                    Console.Write("Escribe la cantidad de filas: ");
                    filas = int.Parse(Console.ReadLine());

                    Console.Write("Escribe la cantidad de columnas: ");
                    columnas = int.Parse(Console.ReadLine());

                    int[][] matrix1 = RandomMatrix(filas, columnas);
                    int[][] matrix2 = RandomMatrix(filas, columnas);

                    space();

                    Console.WriteLine("Matriz 1:");
                    PrintMatrix(matrix1);

                    space();

                    Console.WriteLine("Matriz 2:");
                    PrintMatrix(matrix2);

                    space();

                    int[][] result = AddMatrix(matrix1, matrix2);

                    Console.WriteLine("Matriz Resultado:");
                    PrintMatrix(result);

                    break;

                //Multiplicar Int por Matriz
                case 2:
                    Console.Write("Escribe la cantidad de filas: ");
                    filas = int.Parse(Console.ReadLine());

                    Console.Write("Escribe la cantidad de columnas: ");
                    columnas = int.Parse(Console.ReadLine());

                    Console.Write("Escribe el valor del entero: ");
                    int myInt = int.Parse(Console.ReadLine());


                    matrix = RandomMatrix(filas, columnas);

                    space();

                    Console.WriteLine("Matriz Original:");
                    PrintMatrix(matrix);

                    space();

                    int[][] product = Multiply(matrix, myInt);

                    Console.WriteLine("Matriz Resultado:");
                    PrintMatrix(product);

                    break;

                //Impresion de Matriz
                case 3:
                    Console.Write("Escribe la cantidad de filas: ");
                    filas = int.Parse(Console.ReadLine());

                    Console.Write("Escribe la cantidad de columnas: ");
                    columnas = int.Parse(Console.ReadLine());


                    matrix = RandomMatrix(filas, columnas);

                    space();

                    Console.WriteLine("MATRIZ: ");

                    space();


                    PrintMatrix(matrix);

                    break;

                default:
                    Console.WriteLine("Elige una opcion valida!!");
                    break;


            }


        }

        public static int[][] AddMatrix(int[][] matrix1, int[][] matrix2)
        {
            int filas = matrix1.Length;
            int columnas = matrix1[0].Length;
            int[][] result = new int[filas][];

            for (int i = 0; i < filas; i++)
            {
                result[i] = new int[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    result[i][j] = matrix1[i][j] + matrix2[i][j];
                }
            }

            return result;
        }

        public static void PrintMatrix(int[][] matrix)
        {
            int filas = matrix.Length;
            int columnas = matrix[0].Length;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public static int[][] RandomMatrix(int filas, int columnas)
        {
            int[][] matrix = new int[filas][];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                matrix[i] = new int[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    matrix[i][j] = random.Next(11);
                }
            }

            return matrix;
        }


        public static int[][] Multiply(int[][] matrix, int myInt)
        {
            int filas = matrix.Length;
            int columnas = matrix[0].Length;
            int[][] product = new int[filas][];

            for (int i = 0; i < filas; i++)
            {
                product[i] = new int[columnas];
                for (int j = 0; j < columnas; j++)
                {
                    product[i][j] = matrix[i][j] * myInt;
                }
            }

            return product;
        }


        public static void space()
        {
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
        }


    }
}