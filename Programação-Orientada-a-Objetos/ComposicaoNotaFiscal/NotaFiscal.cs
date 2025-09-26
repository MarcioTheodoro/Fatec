using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }
        //o VetItens é o atributo da relação/associação da composição que estabelece a ligação entre
        //classes
        public List<ItemNotaFiscal> VetItens { get; set; } //devemos instanciar "amarradamente"
        //ou seja, logo no construtor

        public NotaFiscal(List<ItemNotaFiscal> vetItens)
        {
            NumeroNF = numero;
            VetItens = vetItens;
        }

        ~NotaFiscal()
        {
            //tira a referência do objeto parte
            VetItens = null; //o coletor de lixo, avalia as variáveis que estão sem referência de
            //memória, ou seja, que estão nulas, sem uso e libera o espaço de memória
            Console.WriteLine("Destruindo o objeto da Nota Fiscal");
        }
    }
}