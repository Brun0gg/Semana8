using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<string> pilaPalabras = new Stack<string>();

        Console.WriteLine("Ingrese 5 palabras:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Palabra {i}: ");
            string palabra = Console.ReadLine();
            pilaPalabras.Push(palabra);
        }

        Console.WriteLine("\nPalabras en orden inverso (última ingresada, primera mostrada):");
        foreach (string palabra in pilaPalabras)
        {
            Console.WriteLine(palabra);
        }

        if (pilaPalabras.Count == 0)
        {
            Console.WriteLine("\nLa pila está vacía.");
        }
        else
        {
            Console.WriteLine($"\nLa pila contiene {pilaPalabras.Count} palabras.");
        }

        Console.Write("\n¿Desea eliminar la última palabra ingresada? (s/n): ");
        string respuesta = Console.ReadLine().ToLower();

        if (respuesta == "s")
        {
            if (pilaPalabras.Count > 0)
            {
                string eliminada = pilaPalabras.Pop();
                Console.WriteLine($"Palabra eliminada: {eliminada}");
            }
            else
            {
                Console.WriteLine("No se puede eliminar, la pila está vacía.");
            }
        }

        Console.WriteLine("\nPila final:");
        if (pilaPalabras.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
        }
        else
        {
            foreach (string palabra in pilaPalabras)
            {
                Console.WriteLine(palabra);
            }
        }

        Console.WriteLine("\nPrograma finalizado.");
    }
}

