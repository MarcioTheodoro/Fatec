using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoConta
{
    public class Poupanca : Conta
    {
        private double taxaRendimento;
        public double TaxaRendimento
        {
            get { return taxaRendimento; }
            set { taxaRendimento = value; }
        }

        public Poupanca(string nome, decimal saldo, double taxaRendimento) : base(nome, saldo)
        {
            TaxaRendimento = taxaRendimento;
        }

        public override void Mostrar()
        {
            base.Mostrar(); //chamando e reaproveitando a lógica da superclasse
            Console.WriteLine($"Taxa de {TaxaRendimento:c}");
        }
        
    }
}