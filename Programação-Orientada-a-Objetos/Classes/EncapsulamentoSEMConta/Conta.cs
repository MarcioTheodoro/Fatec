using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classe -> atributos -> Métodos

namespace EncapsulamentoSEMConta
{
    public class Conta()
    {
        //declaração de atributos-características
        private int numero;
        private string titular;
        private double saldo;

        /* Formato anterior de programação anterior de C#, mas JAVA e PHP utilizam
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }*/

        public int Numero { //propriedade
            get{ return numero; } //atributo
            set{ numero = value; }
        }

        public string? Titular { //propriedade
            get{ return titular; } //atributo
            set{ titular = value; }
        }

        public double Saldo //propriedade 
        {
            /*set {
                saldo = value;
            }*/
            get {
                return saldo;
            }
        }

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