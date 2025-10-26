using AgregacaoConta;

Cliente cli = new Cliente();
cli.Nome = "Bia";
cli.Rg = 100;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 1000;
// Nesse momento efetiva a agregação
// então o atributo titular passa a ser
// um objeto
c1.Titular = cli;

Console.WriteLine("Número: " + c1.Numero);
Console.WriteLine("Nome: " + c1.Titular.Nome);

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 2000;
c2.Titular = new Cliente();
c2.Titular.Nome = "Cleo";
c2.titular.Rg = 22;
