using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        //declaração da propriedade
        public int Qtde { get; set; }
        //declaração do contrutor
        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }
        //declaração do destrutor
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destruindo o objeto Item de Nota Fiscal");
            //aqui é o momento de você 
            //implementar uma lógica para
            //encerramento/fechamento de recursos
            //abertos
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade: " + Qtde);
        }
    }
}