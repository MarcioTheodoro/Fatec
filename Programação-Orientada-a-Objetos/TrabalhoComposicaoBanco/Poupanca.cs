using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Poupanca
    {
        public double Saldo { get; set; }

        public Poupanca(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            Console.WriteLine(Saldo += valor);
        }
        public void Sacar(double valor)
        {
            Console.WriteLine(Saldo -= valor);
        }
        public void GerarRendimento()
        {
            Console.WriteLine($"Tipo Conta Poupança, Saldo: {Saldo:c}");
        }
    }
}