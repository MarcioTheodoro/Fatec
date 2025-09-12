using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //encapsulamento compacto
        public int Codigo { get; set; }
        public string? Nome {get; set;}
        public double Salario { get; set; }
        public static int contador = 0;

        //fazer 3 construtores
        public Funcionario()
        {
            contador++;
        }
        public Funcionario(int codigo)
        {
            Codigo = codigo;
            contador++;
        }
        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            contador++;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            contador++;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário: {Salario:c}");
        }
    }
}