using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Bia";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Lúcia";
cf.Rg = 123;
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(3,"Lia",300);
cf2.Mostrar();
