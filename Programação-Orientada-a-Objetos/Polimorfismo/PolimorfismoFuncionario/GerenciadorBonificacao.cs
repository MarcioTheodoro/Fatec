using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao 
    {
       private double totalBonificacao { get; set; }
        public double TotalizadorBonificacao(Funcionario funcionario)
        {
            return totalBonificacao += funcionario.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Secretario secretario)
        {
            return totalBonificacao += secretario.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Gerente gerente)
        {
            return totalBonificacao += gerente.CalcularBonificacao();
        }
        public double TotalizadorBonificacao(Diretor diretor)
        {
            return totalBonificacao += diretor.CalcularBonificacao();   
        }
    }
}