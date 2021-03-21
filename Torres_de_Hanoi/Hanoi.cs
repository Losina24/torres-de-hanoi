using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public Hanoi(){
        }

        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top > b.Top) {
                Disco discoMovible = b.pop();
                a.push(discoMovible);
            } else {
                Disco discoMovible = a.pop();
                b.push(discoMovible);
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
