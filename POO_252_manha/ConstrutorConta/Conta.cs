using System;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }//método de encapsulamento compacto
        public string? Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }

        public Conta()//método construtor
        {
            Contador ++;
            //construtor padrão
        }
        public Conta(int numero)
        {//propriedade = parâmetro
            Numero = numero;
            Contador ++;
        }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Contador ++;
        }
        
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador ++;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Número: {Numero} Titular: {Titular} Saldo: {Saldo:c}");
        }
        
    }
}