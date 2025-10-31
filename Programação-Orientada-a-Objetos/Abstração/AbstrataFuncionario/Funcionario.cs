using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected double salario;
        protected Endereco? endereco;

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
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Endereco? _Endereco
        {// _Endereco é a propriedade
         // Endereco é a classe/tipo
            get { return endereco; }
            set { endereco = value; }
        }
        public Funcionario(int codigo, string? nome, double salario, Endereco endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            _Endereco = endereco;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis);
        public int CalcularTotalDependente()
        {
            
        }
    }
}