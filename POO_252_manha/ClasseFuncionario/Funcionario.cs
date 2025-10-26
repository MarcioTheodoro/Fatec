using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace é a pasta ClasseFunionario
namespace ClasseFuncionario 
{
    public class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;
        //declaração de métodos-funções
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " +
            nome + "\tSalário R$ " + salario);
        }
        public void CalcularAumento(double porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
    }
}