using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos-características
        public int numero;
        public string titular;
        public double saldo;

        //declaração de métodos-funções
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
            //saldo = saldo + valorDeposito
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número da conta: " + numero +
            "\tTitular da conta: " + titular +
            "\tSaldo da conta: " + saldo);
        }
    }
}