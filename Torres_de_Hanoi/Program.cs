using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {   
            Disco miDisco = new Disco(1);
            Disco disco2 = new Disco(2);
            Disco disco3 = new Disco(3);
            // Probando Clase Disco
            Console.WriteLine("Probando clase Disco()");
            Console.WriteLine("El valor del disco es: " + miDisco.Valor + "\n");
 
            Pila miPila = new Pila();
            // Probando Pila.isEmpty
            Boolean pilaVacia = miPila.isEmpty();
            Console.WriteLine("Probando Pila.isEmpty()");
            Console.WriteLine("El tamaño de la pila es (0): " + miPila.Size);
            Console.WriteLine("¿Está la pila vacía? (true): " + pilaVacia + "\n");

            // Probando Pila.push
            miPila.push(disco3);
            Console.WriteLine("Probando Pila.push()");
            Console.WriteLine("Disco añadido a la pila, el tamaño de la pila es (1): " + miPila.Size);

            miPila.push(disco2);
            Console.WriteLine("Disco añadido a la pila, el tamaño de la pila es (2): " + miPila.Size);

            miPila.push(miDisco);
            Console.WriteLine("Disco añadido a la pila, el tamaño de la pila es (3): " + miPila.Size + "\n");

            // Probando Pila.pop
            Disco eliminado = miPila.pop();
            Console.WriteLine("Probando Pila.pop()");
            Console.WriteLine("Disco eliminado de la pila, el tamaño de la pila es (2): " + miPila.Size);
            Console.WriteLine("El valor del disco eliminado es (1): " + eliminado.Valor);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
