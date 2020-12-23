using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Gabriel";
            double peso = 115.05;
            int idade = 27;
            float altura = 1.93f;

            Console.WriteLine($"Olá {nome}, sua altura é {altura}, seu peso é {peso} e sua idade é {idade}. ");
        }
    }
}

