using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quantidade;
        public double subtotal;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tPreço: " + preco + "\tQuantidade: " + quantidade);
        }

        public double CalcularAumento(double porcentagem)
        {
            preco += (preco * porcentagem / 100);
            return preco;
        }
        public double CalcularSubtotal()
        {
            subtotal = quantidade * preco;
            return subtotal;
        }
        public int AtualizarEstoque(int quantidade_escolhida)
        {
            quantidade -= quantidade_escolhida;
            return quantidade;
        }

    }
}