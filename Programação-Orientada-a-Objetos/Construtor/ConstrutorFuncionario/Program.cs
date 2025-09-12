using ConstrutorFuncionario;

Funcionario funcionario1 = new Funcionario();
funcionario1.Mostrar();

Funcionario funcionario2 = new Funcionario(1);
funcionario2.Mostrar();

Funcionario funcionario3 = new Funcionario(2, "Marcola");
funcionario3.Mostrar();

Funcionario funcionario4 = new Funcionario(3, "Isolda", 1800);
funcionario4.Mostrar();

Console.WriteLine("Quantidade de instâncias: " + Funcionario.contador);