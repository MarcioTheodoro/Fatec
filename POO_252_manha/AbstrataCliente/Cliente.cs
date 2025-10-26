using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {//a palavra abstract determina que a classe
    // Cliente não pode ser instanciada
        protected int codigo;
        protected string? nome;
        protected int idade;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
        public virtual void MostrarAtributos()
        {// método concreto tem lógica
            Console.WriteLine("Código: " + Codigo + 
            "\tNome: " + Nome);
        }
        public abstract void VerificarIdade();
        //método abstrato não tem lógica na classe base
    }
}