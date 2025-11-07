using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceFuncionario
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            //return Senha == senha ? true : false;
            if (Senha == senha)
            {
                Console.WriteLine("Gerente validado!");
                return true;
            }
            else
            {
                Console.WriteLine("Gerente inválidado!");
                return false;
            }
        }   
    }
}