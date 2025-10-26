using ListFuncionario;

//declaração de vetor
List<Funcionario> vetF = new List<Funcionario>();

for (int i = 0; i < 3; i++)
{
    Funcionario f = new Funcionario();
    Console.Write("Digite o código: ");
    f.codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    f.nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    f.salario = Convert.ToDouble(Console.ReadLine());
    vetF.Add(f); //inserção de um objeto inteiro no vetor
}
//apresentar os atributos - FOR
foreach (Funcionario f in vetF)
    f.MostrarAtributos();
