using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentos {
    class VariavelEConstante {
        public static void Executar() {
            double salario = 300.20;
            Console.WriteLine($" Valor da variável salario: {salario} ");

            int inteiro = 10;
            Console.WriteLine($" Valor da variável inteiro: {inteiro} ");

            char caracteres = 'x';
            Console.WriteLine($" Valor da variável char: {caracteres} ");

            string texto = "Varias palavras";
            Console.WriteLine($" Valor da variável texto: {texto} ");

            float precoDeAlgo = 12099.99f;
            Console.WriteLine($" Valor da variável float: {precoDeAlgo} ");
        }
    }
}
