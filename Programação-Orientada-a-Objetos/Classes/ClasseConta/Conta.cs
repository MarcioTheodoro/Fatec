using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classe -> atributos -> Métodos

namespace ClasseConta
{
    public class Conta()
    {
        //declaração de atributos-características
        public int numero;
        public string titular;
        public double saldo;

        //declaração de métodos-funções
        public double Sacar(double valor)
        {
            saldo -= valor;
            return saldo;
        }
        public double Depositar(double valor)
        {
            saldo += valor;
            return saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número da conta: " + numero + "\tTitular da conta: " + titular + "\tSaldo da conta: " + saldo);
        }
    }
}