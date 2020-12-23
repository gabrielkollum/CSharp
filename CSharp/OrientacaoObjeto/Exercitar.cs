using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OrientacaoObjeto {
    class Exercitar {

        class Carro {
            private string modelo;
            private uint cilindrada;
            private int ano;

            //// Contrutor
            //public Carro(string modelo, uint cilindrada, int ano) {
            //    Modelo = modelo;
            //    Cilindrada = cilindrada;
            //    Ano = ano;
            //}

            public string Modelo {
                get {
                    return "Tipo do carro" + modelo;
                }
                set {
                    modelo = value;
                }
            }


            public uint Cilindrada {
                get {
                    return cilindrada;
                }
                set {
                    cilindrada = value;
                }
            }


            public int Ano {
                get {
                    return ano;
                }
                set {
                    ano = value;
                }
            }

            public override bool Equals(object obj) {
                return obj is Carro carro &&
                       modelo == carro.modelo;
            }

            public override int GetHashCode() {
                return HashCode.Combine(modelo);
            }

            ////Getters and Setters
            //public string GetModelo() {
            //    return Modelo;
            //}

            //public void SetModelo(string modelo) {
            //    Modelo = modelo;
            //}

            //public uint GetCilindrada() {
            //    return Cilindrada;
            //}

            //public void SetCilindrada(uint cilindrada) {
            //    Cilindrada = cilindrada;
            //}

            //public int GetAno() {
            //    return Ano;
            //}

            //public void SetAno(int ano) {
            //    Ano = ano;
            //}
        }


        public static void Executar() {

            Carro meu = new Carro();

            meu.Ano = 2015;
            meu.Cilindrada = 400;
            meu.Modelo = "Cobalt";

            Console.WriteLine($"{meu.Ano}, {meu.Cilindrada}, {meu.Modelo}. ");


        }
    }
}

