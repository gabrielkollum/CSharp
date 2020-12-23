using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp.OrientacaoObjeto {
    class Calcular {
        public static int memoria;

        public Calcular Somar(int a) {
            memoria += a;
            return this;
        }

        public Calcular Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public Calcular Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public int Resultado() {
            return memoria;
        }

        public void Imprimir() {
            Console.WriteLine($"Seu Resultado é{Resultado()}" );
        }

    }
}
