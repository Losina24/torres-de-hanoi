using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        /* Atributos */
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        /* Métodos */
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;
            this.Elementos = new List<Disco>();
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size = Size++;
        }

        public Disco pop()
        {
            Size = Size--;
            Disco discoEliminado = Elementos[Size];
            Elementos.RemoveAt(Size);
            Top = Elementos[Size--].Valor;
            return discoEliminado;
        }                

        public bool isEmpty()
        {
            if (Size > 0)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }

    }
}
