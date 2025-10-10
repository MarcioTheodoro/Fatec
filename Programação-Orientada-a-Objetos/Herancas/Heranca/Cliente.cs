using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cliente
    {
        // APENAS na 
        protected int codigo;
        protected private string? nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string? Nome
        {
            get { return nome; }
            set { codigo = value; }
        }
    }
}