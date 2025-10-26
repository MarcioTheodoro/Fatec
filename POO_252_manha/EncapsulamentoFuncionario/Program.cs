using EncapsulamentoFuncionario;

Funcionario f = new Funcionario();
//Neste momento todos os atributos estão usando o set
f.Codigo = 1;
f.Nome = "Bia";
f.Salario = 1518;

//agora neste momento todos os atributos estão usando o get
Console.WriteLine("Código" + f.Codigo);
Console.WriteLine("Nome" + f.Nome);
Console.WriteLine("Salário" + f.Salario);
//if (f.Salario > 1000) aqui usa o get
