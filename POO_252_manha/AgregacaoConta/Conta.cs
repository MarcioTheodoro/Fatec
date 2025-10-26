using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        // o atributo titular estabelece a
        // relação de agregação entre a classe
        // Conta e a Cliente
        public Cliente Titular { get; set; }
    }
}