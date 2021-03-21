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
            Disco disco1 = new Disco(1);
            Disco disco2 = new Disco(2);
            Disco disco3 = new Disco(3);
            Pila pilaA = new Pila();
            Pila pilaB = new Pila();
            Pila pilaC = new Pila();

            pilaA.push(disco3);
            pilaA.push(disco2);
            pilaA.push(disco1);

            Hanoi hanoi = new Hanoi();
            hanoi.recursivo(3, pilaA, pilaB, pilaC);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
