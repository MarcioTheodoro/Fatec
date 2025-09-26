using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Banco
    {
        public List<Poupancas> Poupancas { get; set; }
        public List<Correntes> Correntes { get; set; }

        public Banco(List<Poupancas> poupancas, List<Correntes> correntes)
        {
            Poupancas = poupancas;
            Correntes = correntes;
        }

        public Banco(List<Poupancas> poupancas)
        {
            
        }

        public Banco(List<Poupancas> poupancas, List<Correntes> correntes)
        {
            Poupancas = poupancas;
            Correntes = correntes;
        }
    }
}