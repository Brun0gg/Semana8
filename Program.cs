using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> colaClientes = new Queue<string>();

            int opcion;
            do
            {
                Console.WriteLine("\n--- COLA DE ATENCIÓN EN BANCO ---");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Mostrar cola actual");
                Console.WriteLine("3. Atender cliente");              
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        
                        Console.Write("Ingrese el nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        colaClientes.Enqueue(cliente);
                        Console.WriteLine($"Cliente '{cliente}' agregado a la cola.");
                        break;

                    case 2:
                        
                        if (colaClientes.Count > 0)
                        {
                            Console.WriteLine("Clientes en espera:");
                            foreach (string c in colaClientes)
                                Console.WriteLine("- " + c);
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes en la cola.");
                        }
                        break;

                    case 3:
                       
                        if (colaClientes.Count > 0)
                        {
                            string atendido = colaClientes.Dequeue();
                            Console.WriteLine($"Cliente atendido: {atendido}");
                           
                            if (colaClientes.Count > 0)
                            {
                                Console.WriteLine("\nClientes restantes:");
                                foreach (string c in colaClientes)
                                    Console.WriteLine("- " + c);
                            }
                            else
                            {
                                Console.WriteLine("\nTodos los clientes han sido atendidos.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes por atender.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");

                        break;                 

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
