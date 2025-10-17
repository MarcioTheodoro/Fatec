using Heranca;

Cliente cliente = new Cliente();
cliente.Codigo = 1;
cliente.Nome = "Marcola";

ClienteFisico clienteFisico = new ClienteFisico();
clienteFisico.Codigo = 2;
clienteFisico.Nome = "Matheus";
clienteFisico.Rg = 321;

ClienteFisico clienteFisico1 = new ClienteFisico(3, "Sandro", 5000);
clienteFisico1.Mostrar();