using ClasseProduto;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto1 = new Produto();
        produto1.codigo = 1;
        produto1.nome = "Pacote de Balões";
        produto1.preco = 2.50;
        produto1.quantidade = 20;

        Produto produto2 = new Produto();
        produto2.codigo = 1;
        produto2.nome = "Skate";
        produto2.preco = 199.99;
        produto2.quantidade = 10;

        produto1.MostrarAtributos();
        Console.WriteLine("Subtotal: R$" + produto1.CalcularSubtotal());

        Console.Write("\nPara aumentar o preco, informe a porcentagem: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        produto1.CalcularAumento(porcentagem);
        produto1.MostrarAtributos();
        Console.WriteLine("Subtotal: R$" + produto1.CalcularSubtotal());

        Console.Write("\nInforme a quantidade a ser retirada: ");
        int quantidade_escolhida = Convert.ToInt32(Console.ReadLine());
        produto1.AtualizarEstoque(quantidade_escolhida);
        produto1.MostrarAtributos();
    }
}