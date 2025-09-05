using VetorConta;

//declaração de variável vetor
Conta[] vetContas = new Conta[3];

//cadastrar contas
for (int i = 0; i < vetContas.Length; i++)
{
    //instanciação de CADA posição do vetor
    vetContas[i] = new Conta();
    Console.Write("Informe o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Informe o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

//apresentar os atributos
for (int i = 0; i < vetContas.Length; i++)
{
    vetContas[i].MostrarAtributos();
}

//apresentar os atributos - FOREACH
//apenas use o foeach se tiver conteúdo no vetor
foreach (Conta conta in vetContas)
{
    conta.MostrarAtributos();
}