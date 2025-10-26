using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoConta
{
    public class Conta
    {
        protected string? nome;
        protected decimal saldo;
        // a palavra virtual indica que ocorrerá o 
        // polimorfismo na classe derivada
        public virtual void Mostrar()
        {
            Console.WriteLine($"Nome: {nome} Saldo {saldo:c}");
        }
        public Conta(string nome, decimal saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
    }
}