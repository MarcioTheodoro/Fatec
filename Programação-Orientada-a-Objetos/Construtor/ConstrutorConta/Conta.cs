using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //prop -> Propriedades
        public int Numero { get; set; }//método de encapsulamento compacto
        public string? Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()//método construtor
        {
            //construtor padrão
        }
        public Conta(int numero)
        {//propriedade = parâmetro
            Numero = numero;
        }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Número: {Numero} \tTítular: {Titular} \tSaldo: {Saldo:c}");
        }
    }
}