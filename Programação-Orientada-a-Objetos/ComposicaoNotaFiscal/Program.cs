using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(22);
ItemNotaFiscal it2 = new ItemNotaFiscal(43);

NotaFiscal notaFiscal1 = new NotaFiscal(1, "26/09/2025");
notaFiscal1.VetItens.Add(it1);
notaFiscal1.VetItens.Add(it2);

List<ItemNotaFiscal> vetIt = new List<ItemNotaFiscal>();
vetIt.Add(it1);
vetIt.Add(it2);

NotaFiscal notaFiscal2 = new NotaFiscal(vetIt);
notaFiscal2.NumeroNF = 2;
notaFiscal2.Data = "25/09/2025";

//var neste caso representa o tipo ItemNotaFiscal
//var é o tipo implicito
foreach (var item in notaFiscal.VetItens)
{
    item.Mostrar();
}
//retira a referência do objeto TODO/diamante
notaFiscal = null;
//forçar o coletor de lixo as ser chamado o método
GC.Collect(); //Garbage Colletor, coleta o lixo, ou seja, procura os objetos sem referência, nulos e
//libera memória