using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPilasyColas
{
    internal class Program
    {
        static void PilaDePalabras()
        {
            // Pila para almacenar las palabras
            Stack<string> palabras = new Stack<string>();

            // Solicitud al usuario para que ingrese cinco palabras
            Console.WriteLine("Ingrese 5 palabras:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Palabra #{i}: ");
                string palabra = Console.ReadLine();
                palabras.Push(palabra); // Insertar la palabra en la pila
            }

            // Foreach para mostrar las palabras en orden inverso
            Console.WriteLine("\nPalabras en orden inverso (última ingresada primero):");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            // Verificar si la pila está vacía y mostrar la cantidad de palabras
            if (palabras.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
            }
            else
            {
                Console.WriteLine($"\nLa pila contiene {palabras.Count} palabras.");
            }

            // Opción para eliminar la última palabra ingresada
            Console.Write("\n¿Desea eliminar la última palabra ingresada? (s/n): ");
            string opcion = Console.ReadLine();

            if (opcion.ToLower() == "s")
            {
                string eliminada = palabras.Pop();
                Console.WriteLine($"Se eliminó la palabra: {eliminada}");
            }

            // Mostrar el resultado final
            Console.WriteLine("\nPila final:");
            if (palabras.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
            }
            else
            {
                foreach (string palabra in palabras)
                {
                    Console.WriteLine(palabra);
                }
            }
        }
    }
}
