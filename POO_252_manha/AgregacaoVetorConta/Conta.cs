using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVetorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        // o atributo titular estabelece a
        // relação de agregação entre a classe
        // Conta e a Cliente
        public List<Cliente> VetTitular { get; set; }
    }
}