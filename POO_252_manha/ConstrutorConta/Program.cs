using ConstrutorConta;
int contador = 0;
Conta c1 = new Conta();
contador ++;
c1.Mostrar();

Conta c2 = new Conta(1);
c2.Mostrar();

Conta c3 = new Conta(2, "Bia");
c3.Mostrar();

Conta c4 = new Conta(4, "Leo", 400);
c4.Mostrar();

Console.WriteLine("Qtde de instâncias: " + Conta.Contador);