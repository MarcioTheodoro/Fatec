using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class ClienteFisico
    {
        //         classe derivada : classe base
        public class ClienteFisico : Cliente
        {
            private int rg;
            public int Rg //propriedade
            {
                get { return myVar; }
                set { myVar = value; }
            }
        }
        /* Seguindo a sintaxe C#, declare os parâmetros que foram colocados no construtor da classe base e acrescente, ao final, o(s) atributos da classe derivada.
        Na sequência, na mesma linha, deve inserir a palavra base, que leverá para armazenar (executar o construtor da classe base) os valores dos parâmetros da classe derivada para a classe base (codigo, nome), ou seja, a palavra base executará o construtor da superclasse */
        public ClienteFisico(int codigo, string nome, int rg) : base(codigo, nome)
        {
            Rg = rg;
        }

        public ClienteFisico() : base() //Construtor padrão/sem parâmetros
        {
            
        }
    }
}