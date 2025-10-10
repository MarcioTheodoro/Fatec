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
    }
}