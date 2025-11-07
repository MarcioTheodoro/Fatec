using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public interface IAutenticavel
    {
        //o método da interface sempre será implicitamente abstrato, ou seja, não terá lógica de programação e termina com ponto e vírgula
        bool Autenticar(int senha);
    }
}