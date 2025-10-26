//estruturas de repetição
int i;
for (i = 1; i < 5; i++)
    Console.WriteLine("5 x " + i + " = " + i * 5);
i = 1;
while (i < 5 )
{
    Console.WriteLine("w 5 x " + i + " = " + i * 5);
    i = i + 1;
}
Console.WriteLine(">>>>>> " + i);
i = 1;
do
{
    Console.WriteLine("d 5 x " + i + " = " + i * 5);
    i = i + 1;
} while (i < 5);
//Estrutura de decisão
/*int idade = 0;
if (idade >= 18)
    Console.WriteLine("Maior idade");
else if (idade == 0)
    Console.WriteLine("Você não existe");
else
{
    Console.Write("Menor ");
    Console.Write("idade");
}
Console.WriteLine("Menu");
Console.WriteLine("1- somar");
Console.WriteLine("2- dividir");
Console.WriteLine("3- sair");
Console.Write("Digite a opção: ");
int opcao = Convert.ToInt32(Console.ReadLine()); 
switch (opcao)
{
    case 1: Console.WriteLine("Realizando a soma");
            break;
    case 2: 
        Console.WriteLine("Realizando a divisão");
        break;
    default: Console.WriteLine("Opção inválida!");
             break;
}
*/


/*Console.Write("Digite o ano de nascimento: ");
int ano = Convert.ToInt32(Console.ReadLine());
int idade = 2025 - ano;
Console.WriteLine("Sua idade é: " + idade);*/
