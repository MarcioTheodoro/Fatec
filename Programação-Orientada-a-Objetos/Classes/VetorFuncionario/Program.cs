using VetorFuncionario;

//declarar um vetor de funcionarios com 3 posições/índices
Funcionario[] vetFuncionarios = new Funcionario[3];
double somatoria = 0;

//cadastrar os funcionários
for (int i = 0; i < vetFuncionarios.Length; i++)
{
    //instanciação de cada posição do vetor
    vetFuncionarios[i] = new Funcionario();
    Console.Write("Informe o código do funcionário: ");
    vetFuncionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o nome do funcionário: ");
    vetFuncionarios[i].nome = Console.ReadLine();
    Console.Write("Informe o salario do funcionário: ");
    vetFuncionarios[i].salario = Convert.ToInt32(Console.ReadLine());
    somatoria += vetFuncionarios[i].salario;
}

//apresentar os valores dos atributos - For
for (int i = 0; i < vetFuncionarios.Length; i++)
{
    vetFuncionarios[i].MostrarAtributos();
}

Console.WriteLine("\nAgora veja com foreach:");

//Agora com foreach
foreach (Funcionario funcionario in vetFuncionarios)
{
    funcionario.MostrarAtributos();
}

//somar todos os salários e apresentar o total
Console.WriteLine($"\nAqui está o total dos salários: {somatoria:c}");