using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {

            double nota = 7.0;

            if (nota > 7.0) {
                Console.WriteLine("Parabéns");

            } else if(nota > 6.0) {
                Console.WriteLine("Outra coisa!");
            }

            switch (nota) {
                case 0:
                    Console.WriteLine("1");
                    break;
                case 2:
                    break;
            }


        }
    }
}
