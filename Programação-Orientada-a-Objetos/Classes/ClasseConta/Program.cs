//usar a namespace
using ClasseConta;

//declarar / instanciar
Conta conta = new Conta();
conta.numero = 1;
conta.titular = "Marcola";
conta.saldo = 1500.00;

Console.WriteLine("Informe um valor pra sacar: ");
double valorSaque = Convert.ToDouble(Console.ReadLine());
conta.Sacar(valorSaque);
conta.MostrarAtributos();

Console.WriteLine("Informe um valor pra depositar: ");
double valorDeposito = Convert.ToDouble(Console.ReadLine());
conta.Depositar(valorDeposito);
conta.MostrarAtributos();


Conta conta2 = new Conta();
Console.Write("Informe o número: ");
conta2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o titular: ");
conta2.titular = Console.ReadLine();
Console.Write("Informe o saldo: ");
conta2.saldo = Convert.ToDouble(Console.ReadLine());
conta2.MostrarAtributos();