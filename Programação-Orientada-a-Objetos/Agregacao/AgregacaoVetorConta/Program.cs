using AgregacaoVetorConta;

Conta conta = new Conta();
conta.Numero = 44;
conta.Saldo = 4400;
conta.VetTitular = new List<Cliente>();
for (int i = 0; i < 3; i++)
{
    Cliente cliente = new Cliente();
    Console.WriteLine("Informe o nome: ");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("Informe o RG: ");
    cliente.Rg = Convert.ToInt32(Console.ReadLine());
    conta.VetTitular.Add(cliente); //Insere um objeto

}
foreach (Cliente OBJCliente in conta.VetTitular)
{
    cliente.Mostrar();
}