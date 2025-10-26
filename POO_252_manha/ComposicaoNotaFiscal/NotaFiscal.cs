using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        //o VetItens é o atributo da relação/associação da
        //composição que estabele a ligação entre as classes
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int numero, string data)
        {
            NumeroNf = numero;
            Data = data;
            VetItens = new List<ItemNotaFiscal>();
        }
        public NotaFiscal(List<ItemNotaFiscal> vetItens)
        {
            VetItens = vetItens;
        }
        //NotaFiscal(new List<ItemNotaFiscal>(), it1, it2, 3, "20/09/2025");
        public NotaFiscal(List<ItemNotaFiscal> vetIt2, ItemNotaFiscal it1, ItemNotaFiscal it2, int numero, string data)
        {
            NumeroNf = numero;
            Data = data;
            VetItens = vetIt2;
            VetItens.Add(it1);
            VetItens.Add(it2);
        }
        
        ~NotaFiscal()
        {   //tira a referência do objeto parte
            VetItens = null;// o coletor de lixo, avalia
            //as variáveis que estão sem referência de
            //memória, ou seja, que estão nulas, sem uso e
            //libera o espaço de memória
            Console.WriteLine("Destruindo o objeto da Nota Fiscal");
        }

    }
}