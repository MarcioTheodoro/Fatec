using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero; //atributo
        private double saldo;
        private string? titular;

        //declaração dos métodos
        public int Numero //propriedade
        {
            get { return numero; }
            set { //vale números de 100 a 500
                if (value >= 100 && value <= 500)
                    numero = value;
                else
                    Console.WriteLine("Número inválido!"); 
            }
        }

        public string? Titular
        {
            get { return titular.ToUpper(); }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
        
    }
}