using AgregacaoConta;

Cliente cli = new Cliente();
cli.Nome = "Bia";
cli.Rg = 100;

Conta conta1 = new Conta();
conta1.Numero = 1;
conta1.Saldo = 1000;
// nesse momento efetivamos a agregação
// então o atributo titular passa a ser um objeto
conta1.Titular = cli;

Console.WriteLine("Número: " + conta1.numero);
Console.WriteLine("Nome: " + conta1.Titular.Nome);

Conta conta2 = new Conta();
conta2.Numero = 2;
conta2.Saldo = 2000;
conta2.Titular = new Cliente()
conta2.Titular.Nome = "Adamastor";
conta2.Titular.Rg = 22;