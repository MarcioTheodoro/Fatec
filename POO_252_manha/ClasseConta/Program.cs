//usar a namespace/subpasta
using ClasseConta;//ClasseConta é a namespace

//declarar uma variável
//tipo nome da variável
Conta c1;
//instanciar objeto
c1 = new Conta();
c1.numero = 1;
c1.titular = "Bia";
c1.saldo = 100;
c1.MostrarAtributos();
Console.WriteLine("Digite o valor a sacar: ");
double dinheiro = Convert.ToDouble(Console.ReadLine());
c1.Sacar(dinheiro);
c1.MostrarAtributos();

//declarar e instanciar um objeto
Conta c2 = new Conta();
Console.Write("Digite o número: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());
c2.MostrarAtributos();//chamada da função
c2.Depositar(50);// aqui pode ser digitado o valor 
c2.MostrarAtributos();


//objeto envia uma mensagem 

