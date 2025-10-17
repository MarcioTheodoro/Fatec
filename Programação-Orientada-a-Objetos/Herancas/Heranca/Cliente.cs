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
        protected private string? nome; //protected permite o acesso da classe que o declarou e por todas as classes filhas
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string? Nome //private apenas restringe o acesso, ponto
        {
            get { return nome; }
            set { codigo = value; }
        }

        /* Neste caso do construtor, ocorre o polimorfismo estático, esta na mesa classe e com quantidade de parãmetros
        */

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Cliente()
        {
            
        }
    }
}