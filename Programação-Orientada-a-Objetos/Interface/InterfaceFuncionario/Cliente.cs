using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            return Senha == senha ? true : false;
        }
    }
}