using AbstrataFuncionario;

Endereco e = new Endereco("Rua Terezina",75,"Vila Paulo Roberto", "PP");
Assalariado a1 = new Assalariado(10, "Assalariado 1", 1000, e);
Assalariado a2 = new Assalariado(11, "Assalariado 2", 1000, e);

Comissionado c1 = new Comissionado(30, "Comissionado 1", 1000, e, 20);
Comissionado c2 = new Comissionado(31, "Comissionado 2", 1000, e, 21);


Departamento d1 = new Departamento(1,"Suporte");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();
Console.WriteLine($"Total de salários: {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(2,"Desenvolvimento");

Dependente dependente = new Dependente(1, "Dependente 1", 16);
Dependente dependente2 = new Dependente(2, "Dependente 2", 20);