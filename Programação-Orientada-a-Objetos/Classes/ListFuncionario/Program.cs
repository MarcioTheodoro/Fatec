using ListFuncionario;

//declaração de vetor
List<Funcionario> vetFuncionarios = new List<Funcionario>();

for (int i = 0; i < 3; i++)
{
    Funcionario funcionario = new Funcionario();

    Console.Write("Informe o código do funcionário: ");
    funcionario.codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o nome do funcionário: ");
    funcionario.nome = Console.ReadLine();
    Console.Write("Informe o salario do funcionário: ");
    funcionario.salario = Convert.ToDouble(Console.ReadLine());
    vetFuncionarios.Add(funcionario); //inserção de um objeto inteiro no vetor
}

//apresentar os valores dos atributos - For
foreach (Funcionario funcionario in vetFuncionarios)
{
    funcionario.MostrarAtributos();
}