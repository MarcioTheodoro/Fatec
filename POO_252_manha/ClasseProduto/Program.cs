using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        //fazer as instâncias
        Produto p1 = new Produto();
        p1.codigo = 1;
        p1.nome = "impressora";
        p1.preco = 100;
        p1.qtde = 2;
        p1.MostrarAtributos();
        p1.CalcularAumento(10);
        p1.CalcularSubtotal();
        p1.AtualizarEstoque(1);

        Produto p2 = new Produto();
        p2.codigo = 2;
        p2.nome = "monitor";
        p2.preco = 2000;
        p2.qtde = 5;
        p2.MostrarAtributos();
        p2.CalcularAumento(10);
        p2.CalcularSubtotal();
        p2.AtualizarEstoque(1);
        p2.MostrarAtributos();
    }
}