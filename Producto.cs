using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tecno1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INVENTARIO TECNOPUNTO ===");

            // El for se repite 3 veces
            for (int i = 1; i <= 3; i++)
            {
                bool datosValidos = false;

                // esto es para que se repita hasta que el usuario escriba datos correctos
                while (datosValidos == false)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- Producto " + i + " ---");

                        Console.Write("Código: ");
                        string codigo = Console.ReadLine();

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Precio: ");
                        double precio = double.Parse(Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        // Se crea el objeto
                        Producto producto = new Producto(codigo, nombre, precio, cantidad);

                        Console.WriteLine();
                        producto.MostrarInfo();

                        // Si llega aqui, todo estaba bien y se sale del while
                        datosValidos = true;
                    }
                    catch (FormatException)
                    {
                        // Escribieron letras donde iba un numero
                        Console.WriteLine("Error: el precio y la cantidad deben ser números. Intente de nuevo.");
                    }
                    catch (Exception ex)
                    {
                        // Errores de las propiedades (nombre vacio, precio malo, etc.)
                        Console.WriteLine("Error: " + ex.Message + " Intente de nuevo.");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}