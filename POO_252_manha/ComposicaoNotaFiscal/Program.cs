using ComposicaoNotaFiscal;

ItemNotaFiscal it2 = new ItemNotaFiscal(22);
ItemNotaFiscal it1 = new ItemNotaFiscal(43);

NotaFiscal nf1 = new NotaFiscal(1,"26/09/2025");
nf1.VetItens.Add(it1);
nf1.VetItens.Add(it2);

List<ItemNotaFiscal> vetIt = new List<ItemNotaFiscal>();
vetIt.Add(it1);
vetIt.Add(it2);

NotaFiscal nf2 = new NotaFiscal(vetIt);
nf2.NumeroNf = 2;
nf2.Data = "25/09/2025";

NotaFiscal nf3 = new NotaFiscal(new List<ItemNotaFiscal>(), it1, it2, 3, "20/09/2025");

//var neste caso representa o tipo ItemNotaFiscal
//var é o tipo implicito
foreach (var item in nf3.VetItens)
    item.Mostrar();

//retira a referência do objeto TODO/diamante
nf3 = null;
//forçar o coletor de lixo a ser chamado o método
GC.Collect();//coleta o lixo, ou seja, procura os objetos
//sem referência,nulos e libera memória