using EncapsulamentoSEMConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        //c1.saldo = 130;//private não funciona o atributo 
        //c1.Sacar(1);//private não funciona a função/método
        c1.Depositar(10);
        c1.MostrarAtributos();
        //c1.SetSaldo(55);
        //Console.WriteLine(c1.GetSaldo());
        c1.Numero = 1;
        c1.Titular = " Bia";
        //c1.Saldo = 125; // usando o set
        Console.WriteLine(c1.Saldo); // usando o get
        c1.MostrarAtributos();

    }
}