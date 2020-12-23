using System;
using System.Collections.Generic;

using CSharp.Fundamentos;
using CSharp.EstruturasDeControle;
using CSharp.OrientacaoObjeto;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariavelEConstante.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Fomatando Numero - Fundamentos", FomatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},

                // Orientação a Objeitos
                {"Orientação a Objetos", Calculadora.Executar},
                {"Exercitar", Exercitar.Executar},
                {"Escrevendo", Lendo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}