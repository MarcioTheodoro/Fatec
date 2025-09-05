using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string? nome;
        public double salario;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: R$" + salario);
        }
        public double CalcularAumento(double porcentagem)
        {
            salario += (salario * porcentagem / 100);
            return salario;
        }
    }
}