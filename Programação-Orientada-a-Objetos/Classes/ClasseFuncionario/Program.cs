using ClasseFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.codigo = 1;
        funcionario1.nome = "Marcos";
        funcionario1.salario = 1800;
        funcionario1.MostrarAtributos();
        funcionario1.CalcularAumento(5);
        funcionario1.MostrarAtributos();

        Funcionario funcionario2 = new Funcionario();
        Console.Write("Informe o código: ");
        funcionario2.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o nome: ");
        funcionario2.nome = Console.ReadLine();
        Console.Write("Informe o salário: ");
        funcionario2.salario = Convert.ToDouble(Console.ReadLine());
        funcionario2.MostrarAtributos();
        Console.Write("Informe agora o valor da porcentagem: ")
        porcentagem = Convert.ToDouble(Console.ReadLine());
        funcionario2.CalcularAumento(porcentagem);
    }
}