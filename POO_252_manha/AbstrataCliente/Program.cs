using AbstrataCliente;

//Cliente c = new Cliente();
// aqui ocorre erro na compilação, pois não pode
// instanciar um objeto de uma classe abstrata

ClienteFisico cf = new ClienteFisico(1,"Bia",20, 100);
cf.MostrarAtributos();

ClienteJuridico cj = new ClienteJuridico(2,"Empresa",45,10000);
cj.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdadeClientes(cf);

t.AvaliarIdadeClientes(cj);
