using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        //declaração do atributos
        private int numero;//atributo
        private string titular;
        private double saldo;
        //declaração dos métodos
        public int Numero //propriedade
        {
            get { return numero; }
            set { // vale numeros de 100 a 500
                if (value >= 100 && value <= 500)
                    numero = value; 
                else
                    Console.WriteLine("Número inválido!");
            }
        }
        public string Titular
        {
            get { return titular.ToUpper(); }
            set { titular = value; }
        }
        private bool saldo;
        public bool Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
    }
}