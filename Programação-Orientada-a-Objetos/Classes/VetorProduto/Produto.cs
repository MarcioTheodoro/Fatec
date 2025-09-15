using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorProduto
{
    public class Produto
    {
        public int codigo;
        public string? nome;
        public double preco;
        public int estoque;
        public double subtotal;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tPreço: R$" + preco + "\tEstoque: " + estoque);
        }

        public double CalcularAumento(double porcentagem)
        {
            preco += (preco * porcentagem / 100);
            return preco;
        }
        public double CalcularSubtotal()
        {
            subtotal = estoque * preco;
            return subtotal;
        }
        public int RetirarEstoque(int quantidade_escolhida)
        {
            estoque -= quantidade_escolhida;
            return estoque;
        }

    }
}