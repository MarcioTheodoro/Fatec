using HerancaProduto;

Produto produto = new Produto(1, "Escova de dentes", 2.50);
produto.MostrarDados();
Perecivel perecivel = new Perecivel(2, "Refrigerante", 8);
perecivel.DtValidade = "12/08/2025";
perecivel.DtFabricacao = "10/09/2024";
perecivel.MostrarDados();