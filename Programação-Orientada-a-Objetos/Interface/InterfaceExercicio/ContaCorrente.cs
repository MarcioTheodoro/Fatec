using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercicio
{
    public class ContaCorrente : ITributavel 
    {
        public double Saldo { get; set; }
        public double CalculaTributos()
        {
            return Saldo * 5 / 100;
        }
    }
}