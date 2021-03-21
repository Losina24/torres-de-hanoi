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
            Console.WriteLine("El valor del disco es: " + miDisco.Valor);

            Disco disco2 = new Disco(2);
            Disco disco3 = new Disco(3);
            Pila miPila = new Pila();
            miPila.push(disco3);
            Console.WriteLine("Disco añadido a la pila, el tamaño de la pila es: " + miPila.Size);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
