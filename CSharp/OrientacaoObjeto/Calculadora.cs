using System;
using System.Collections.Generic;
using System.Text;

using CSharp.OrientacaoObjeto;

namespace CSharp.OrientacaoObjeto {
    class Calculadora {
        int a = 10;

        public static void Executar() {
            Calculadora calc = new Calculadora();
            Console.WriteLine(calc.a);  
        }
    }
}
