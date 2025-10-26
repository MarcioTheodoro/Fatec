using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string? dtValidade;
        private string? dtFabricacao;
        public string? DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        public string? DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        public Perecivel(int codigo, string? nome, double preco) : base(codigo, nome, preco)
        {
            DtValidade = dtValidade;
            DtFabricacao = dtFabricacao;
        }
        ~Perecivel()
        {

        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"\tData de validade: {DtValidade} \tData de Fabricação: {DtFabricacao}");
        }
    }
}