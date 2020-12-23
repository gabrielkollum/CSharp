using System;
using System.Globalization;

namespace CSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual a seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a seu salario? ");
            double salario = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture);


            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
