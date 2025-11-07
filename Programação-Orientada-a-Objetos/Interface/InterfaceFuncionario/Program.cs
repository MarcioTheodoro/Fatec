using InterfaceFuncionario;

Gerente gerente = new Gerente();
gerente.Senha = 100;

IAutenticavel ia = gerente;
ia.Autenticar(100);

Diretor diretor = new Diretor();
diretor.Senha = 200;
ia = diretor;
Console.WriteLine("Diretor: " + ia.Autenticar(200));