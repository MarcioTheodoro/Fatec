using VetorProduto;

Produto[] vetProdutos = new Produto[2];

for (int i = 0; i < vetProdutos.Length; i++)
{
    vetProdutos[i] = new Produto();
    Console.Write("Informe o código do produto: ");
    vetProdutos[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe o nome do produto: ");
    vetProdutos[i].nome = Console.ReadLine();
    Console.Write("Informe o preço do produto: ");
    vetProdutos[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Informe o estoque do produto: ");
    vetProdutos[i].estoque = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < vetProdutos.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("Produto(s) em índice par, Informe uma porcentagem: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        vetProdutos[i].CalcularAumento(porcentagem);
    }
    else
    {
        int quantidade_desejada = 0;
        Console.Write("Produto(s) em índice ímpar, quanto deseja retirar do estoque? ");
        quantidade_desejada = Convert.ToInt32(Console.ReadLine());
        vetProdutos[i].RetirarEstoque(quantidade_desejada);
    }
}

foreach (Produto produto in vetProdutos)
{
    produto.MostrarAtributos();
}

Console.WriteLine("Após cálculo do subtotal.... ");

foreach (Produto produto in vetProdutos)
{
    produto.MostrarAtributos();
    Console.WriteLine("Subtotal: " + produto.CalcularSubtotal());
}
