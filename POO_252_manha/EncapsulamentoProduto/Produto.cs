using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int qtde;
        public double subtotal;

        //declaração do métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " +
            nome + "\tPreço R$ " + preco + "\tQtde: " + qtde +
            "\tSubtotal R$ " + subtotal);
        }
        public void CalcularAumento(double porcentagem)
        {
            preco += preco * porcentagem / 100;
        }
        public void CalcularSubtotal()
        {
            subtotal = preco * qtde;
        }
        public void AtualizarEstoque(int quantidade)
        {
            qtde -= quantidade;
        }
    }
}