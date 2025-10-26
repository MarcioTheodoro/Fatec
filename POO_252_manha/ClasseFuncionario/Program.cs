using ClasseFuncionario;
//using carrega a namespace/pasta
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "Bia";
        f1.salario = 1000;
        f1.MostrarAtributos();//envio de mensagem
        f1.CalcularAumento(5);//faz de conta que digitei
        f1.MostrarAtributos();
        
        Funcionario f2 = new Funcionario();
        Console.Write("Digite o código: ");
        f2.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome: ");
        f2.nome = Console.ReadLine();
        Console.Write("Digite o salário: ");
        f2.salario = Convert.ToDouble(Console.ReadLine());
        f2.MostrarAtributos();
        f2.CalcularAumento(7);
        f2.MostrarAtributos();
    }
}