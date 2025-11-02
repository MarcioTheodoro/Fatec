using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        // APENAS na classe base/superclasse
        // coloque, caso seja necessário o
        // modificador de acesso/visibilidade
        // protected
        protected int codigo;
        protected string? nome;
        public int Codigo //propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        // neste caso do construtor, ocorre o polimorfismo
        // estático, esta na mesma casse e com quantidade
        // de parâmetros diferentes
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