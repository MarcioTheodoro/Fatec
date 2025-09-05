using EncapsulamentoSEMConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta conta1 = new Conta();
        //conta1.saldo = 130; //private não funcionamento 
        //conta1.sacar(1);
        //conta1.SetSaldo(200);
        //Console.WriteLine(conta1.GetSaldo());

        conta1.Numero = 1;
        conta1.Titular = "Marcos";
        //conta1.Saldo = 180; //usando o set
        Console.WriteLine("Toma o saldo: " + conta1.Saldo); //usando o get
        conta1.MostrarAtributos();
    }
}