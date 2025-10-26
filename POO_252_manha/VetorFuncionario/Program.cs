using VetorFuncionario;

//declaração de variável vetor
Funcionario[] vetF = new Funcionario[3];

double soma = 0;
//cadastrar contas
for (int i = 0; i < vetF.Length; i++)
{
    //instanciação de CADA posição/índice do vetor
    vetF[i] = new Funcionario();
    Console.Write("Digite o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
    soma = soma + vetF[i].salario;
}
Console.WriteLine($"A soma dos salários é {soma:c}");
//apresentar os atributos - FOR
foreach (Fucionario f in vetF)
{
    //soma = soma + f.salario;
    f.MostrarAtributos();
}

//somar todos os salários e apresentar o total

