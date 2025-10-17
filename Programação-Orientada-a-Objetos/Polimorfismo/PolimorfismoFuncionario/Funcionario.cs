using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;

        public virtual void Mostrar()
        {
            Console.WriteLine($"Codigo: {codigo} Nome: {nome} Salário: {salario:c}");
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

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
        
        public virtual double CalcularBonificacao()
        {// apresentar no método Main()
            return Salario * 10 / 100;
        }

        //setas brancas -> herança -> :
        //setas trastejadas -> dependência -> basta incluir um atributo de outra classe como parâmetro num método
        //base() -> chama o construtor da classe-mãe
    }
}