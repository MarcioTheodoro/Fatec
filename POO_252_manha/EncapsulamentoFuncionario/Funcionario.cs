using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //implicitamente é criado o atributo numero e
        //desenvolvido o método/propriedade do 
        //encapsulamento get e set COMPLETO

        //encapsulamento compacto
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
    }
}