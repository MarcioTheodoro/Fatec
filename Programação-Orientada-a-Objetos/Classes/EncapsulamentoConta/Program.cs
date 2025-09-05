using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta conta = new Conta();
        conta.Numero = 350;
        conta.Titular = "Marcos";
        conta.Saldo = 1500;
        Console.WriteLine("Número: " + conta.Numero + "\tTitular: " + conta.Titular + $"\tSaldo: {conta.Saldo:c}");
    }
}