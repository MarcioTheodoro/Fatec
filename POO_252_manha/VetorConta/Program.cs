using VetorConta;

//declaração de variável vetor
Conta[] vetContas = new Conta[3];

//cadastrar contas
for (int i = 0; i < vetContas.Length; i++)
{
    //instanciação de CADA posição/índice do vetor
    vetContas[i] = new Conta();
    Console.Write("Digite o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}
//apresentar os atributos - FOR
for (int i = 0; i < vetContas.Length; i++)
    vetContas[i].MostrarAtributos();

//apresentar os atributos - FOREACH
//apenas use o foreach SE TIVER CONTEÚDO NO VETOR
foreach (Conta c in vetContas)
    c.MostrarAtributos();