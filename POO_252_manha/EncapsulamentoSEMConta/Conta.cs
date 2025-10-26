using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoSEMConta
{
    public class Conta
    {
        //declaração de atributos-características
        private int numero;
        private string? titular;
        private double saldo;
        /* formato de programação anterior de C#, mas
        JAVA E PHP utilizam
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }*/
        public int Numero{ //propriedade
            get{ return numero;}//atributo
            set{ numero = value;}
        }
        public string? Titular{ //propriedade
            set{ titular = value; }
            get{ return titular; }//atributo
        }
        public double Saldo //propriedade
        {
            /*set{
                saldo = value;
            }*/
            get{
                return saldo;
            }
        }
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