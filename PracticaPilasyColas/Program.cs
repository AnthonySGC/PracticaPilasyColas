using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPilasyColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Simulador de Cola de Impresión");
            Console.WriteLine("2. Pila de Palabras");
            Console.Write("Opción (1 o 2): ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                ColaImpresion();
            }
            else if (opcion == "2")
            {
                PilaDePalabras();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            Console.ReadKey();
        }

        // Cola de Impresión
        static void ColaImpresion()
        {
            // 1. Declarar una cola de tipo string para almacenar los nombres de los documentos.
            Queue<string> documentosCola = new Queue<string>();
            Console.WriteLine("--- SIMULADOR DE COLA DE IMPRESIÓN ---");
            Console.WriteLine();

            // 2. Permitir al usuario ingresar varios nombres de documentos a imprimir.
            Console.WriteLine("Introduce los nombres de los documentos a imprimir (escribe 'fin' para terminar):");
            string nombreDocumento;
            do
            {
                Console.Write("Documento a añadir: ");
                nombreDocumento = Console.ReadLine();

                if (nombreDocumento.ToLower() != "fin" && !string.IsNullOrWhiteSpace(nombreDocumento))
                {
                    documentosCola.Enqueue(nombreDocumento); // Añadir a la cola
                    Console.WriteLine($"'{nombreDocumento}' añadido a la cola.");
                }
            } while (nombreDocumento.ToLower() != "fin");

            // 6. Mostrar un mensaje si no hay documentos pendientes (al inicio)
            if (documentosCola.Count == 0)
            {
                Console.WriteLine("\nNo hay documentos pendientes de impresión.");
                return; // Termina el programa si no hay nada que hacer
            }

            // 3. Mostrar la cola completa (orden de impresión).
            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("COLA COMPLETA (Orden de impresión):");
            MostrarCola(documentosCola);
            Console.WriteLine("-------------------------------------------------");

            // 4. Atender el primer documento (Dequeue) simulando que se imprimió.
            Console.WriteLine("\n--- PROCESANDO IMPRESIÓN ---");
            string documentoImprimiendo = documentosCola.Dequeue(); // Quitar el primero
            Console.WriteLine($"Documento impreso (Dequeue): **{documentoImprimiendo}**");

            // 5. Mostrar los documentos restantes en la cola.
            Console.WriteLine("\n--- DOCUMENTOS RESTANTES EN COLA ---");
            MostrarCola(documentosCola);

            // 6. Mostrar un mensaje si no hay documentos pendientes (después de la impresión)
            if (documentosCola.Count == 0)
            {
                Console.WriteLine("\n¡La cola de impresión ha quedado vacía!");
            }
            else
            {
                Console.WriteLine($"\nQuedan {documentosCola.Count} documentos pendientes.");
            }
        }
        static void MostrarCola(Queue<string> cola)
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("   [Cola vacía]");
                return;
            }

            int i = 1;
            foreach (string doc in cola)
            {
                Console.WriteLine($"   {i}. {doc}");
                i++;
            }
        }

        // Pila de Palabras
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
