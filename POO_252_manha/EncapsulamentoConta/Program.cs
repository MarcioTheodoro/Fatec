using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.Numero = 200;
        c1.Titular = "Bia";
        c1.Saldo = 100;
        Console.WriteLine("Número: " + c1.Numero);
        Console.WriteLine("Titular: " + c1.Titular);
        Console.WriteLine($"Saldo {c1.Saldo:c}");
    }
}