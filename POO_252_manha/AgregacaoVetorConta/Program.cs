using AgregacaoVetorConta;

Conta c = new Conta();
c.Numero = 44;
c.Saldo = 4400;
c.VetTitular = new List<Cliente>();
for (int i = 0; i < 3; i++)
{
    Cliente cli = new Cliente();
    Console.Write("Digite o nome: ");
    cli.Nome = Console.ReadLine();
    Console.Write("Digite o RG: ");
    cli.Rg = Convert.ToInt32(Console.ReadLine());
    c.VetTitular.Add(cli);//insere um objeto Cliente
}
Console.WriteLine("\n\nApresentação dos Titulares\n");
foreach (Cliente objCliente in c.VetTitular)
    objCliente.Mostrar();
