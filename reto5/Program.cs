using System;
using System.Collections.Generic;

namespace reto5
{
    public class Producto
    {
        // Atributos, getters y setters
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto()
        {
            // Constructor por defecto con valores predeterminados
            Id = 0;
            Nombre = "";
            Precio = 0.0;
            Stock = 0;
        }

        public Producto(int id, string nombre, double precio, int stock)
        {
            // Constructor sobrecargado con valores personalizados
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        // Metodos
        public void Vender(int cantidad)
        {
            if (cantidad > 0 && cantidad <= Stock)
            {
                Stock -= cantidad;
                Console.WriteLine("Venta exitosa. Stock actual: " + Stock);
            }
            else
            {
                throw new Exception("Cantidad no válida para la venta.");
            }
        }

        public void Reabastecer(int cantidad)
        {
            if (cantidad > 0)
            {
                Stock += cantidad;
                Console.WriteLine("Reabastecimiento exitoso. Stock actual: " + Stock);
            }
            else
            {
                throw new Exception("Cantidad no válida para el reabastecimiento.");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Producto: {Nombre}, Precio: ${Precio} MXN, Stock: {Stock} pz";
        }
    }

    internal class Program
    {
        static List<Producto> inventario = new List<Producto>();

        static void Main(string[] args)
        {
            try
            {
                bool ciclo = true;

                while (ciclo)
                {
                    Algoritmo();
                    Space();

                    Console.Write("-Intentar otra opcion (Presiona 1) \n-Salir del Programa (Presiona 2) \n-Elige una opcion: ");
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

        public static void Algoritmo()
        {
            Console.WriteLine("Programa de Marketplace \n");
            string[] menu = { "Agregar un nuevo producto (Presiona 1)", "Vender un producto existente (Presiona 2)", "Reabastecer un producto existente (Presiona 3)", "Mostrar información de todos los productos (Presiona 4)" };

            for (int i = 0; i < menu.Length; i++)
            {
                string myMenu = menu[i];
                Console.WriteLine((i + 1) + "-" + myMenu);
            }

            Console.Write("\nElige una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            Space();

            switch (opcion)
            {
                // Agregar un nuevo producto
                case 1:
                    Console.Write("Ingrese el ID del producto: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el precio del producto: ");
                    double precio = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el stock inicial del producto: ");
                    int stock = int.Parse(Console.ReadLine());

                    Producto nuevoProducto = new Producto(id, nombre, precio, stock);

                    inventario.Add(nuevoProducto);
                    Console.WriteLine("Producto agregado al inventario.");
                    break;

                // Vender un producto existente
                case 2:
                    Console.Write("Ingrese el ID del producto a vender: ");
                    int idVenta = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese la cantidad a vender: ");
                    int cantidadVenta = int.Parse(Console.ReadLine());

                    foreach (Producto product in inventario)
                    {
                        if (product.Id == idVenta)
                        {
                            product.Vender(cantidadVenta);
                            break;
                        }
                    }

                    break;

                // Reabastecer un producto existente
                case 3:
                    Console.Write("Ingrese el ID del producto a reabastecer: ");
                    int idReabastecimiento = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese la cantidad a reabastecer: ");
                    int cantidadReabastecimiento = int.Parse(Console.ReadLine());

                    foreach (Producto product in inventario)
                    {
                        if (product.Id == idReabastecimiento)
                        {
                            product.Reabastecer(cantidadReabastecimiento);
                            break;
                        }
                    }

                    break;

                // Mostrar información de todos los productos
                case 4:
                    Console.WriteLine("Inventario de productos:");
                    foreach (Producto product in inventario)
                    {
                        Console.WriteLine(product.ToString());
                    }
                    break;

                default:
                    Console.WriteLine("Elige una opcion valida!!");
                    break;
            }
        }

        public static void Space()
        {
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
        }
    }
}
