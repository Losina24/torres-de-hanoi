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
                if(b.isEmpty()){
                    Disco discoMovible = a.pop();
                    b.push(discoMovible);
                } else {
                    Disco discoMovible = b.pop();
                    a.push(discoMovible);
                }
                
            } else if (a.Top < b.Top) {
                if(a.isEmpty()){
                    Disco discoMovible = b.pop();
                    a.push(discoMovible);
                } else {
                    Disco discoMovible = a.pop();
                    b.push(discoMovible);
                }
            } 
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n%2 != 0) {
                while(fin.Size != n) {
                    mover_disco(ini, fin);
                    m++;
                    if(fin.Size == n){
                        break;
                    }

                    mover_disco(ini, aux);
                    m++;
                    if(fin.Size == n){
                        break;
                    }

                    mover_disco(aux, fin);
                    m++;
                    if(fin.Size == n){
                        break;
                    }
                }
            }
            
            if (n%2 == 0) {
                while(fin.Size != n) {
                    mover_disco(ini, aux);
                    m++;
                    if(fin.Size == n){
                        break;
                    }

                    mover_disco(ini, fin);
                    m++;
                    if(fin.Size == n){
                        break;
                    }

                    mover_disco(aux, fin);
                    m++;
                    if(fin.Size == n){
                        break;
                    }
                }
            }

            return m;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if(n == 1){
                mover_disco(ini, fin);
                m++;
            } else {
                m += recursivo(n-1, ini, aux, fin);
                mover_disco(ini, fin);
                m++;
                m += recursivo(n-1, aux, fin, ini);
            }
            Console.WriteLine("Moviendo Inicio y Fin...\nTop Inicio: " + ini.Top);
                    Console.WriteLine("Top Final: " + fin.Top);
                    Console.WriteLine("Top Auxiliar: " + aux.Top);
                    Console.WriteLine("Tamaño Fin: " + fin.Size);
                    Console.WriteLine("m: " + m + "\n\n");
            return m;
        }

    }
}
