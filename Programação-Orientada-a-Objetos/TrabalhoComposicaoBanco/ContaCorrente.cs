using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }

        public ContaCorrente(double saldo, chequeEspecial)
        {
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
        }
        public void Depositar(double valor)
        {
            Console.WriteLine(Saldo += valor);
        }
        public void Sacar(double valor)
        {
            Console.WriteLine(Saldo -= valor);
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo: {Saldo:c}");
            Console.WriteLine("Cheque especial: " + ChequeEspecial);
        }
    }
}