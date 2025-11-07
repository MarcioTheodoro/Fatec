using InterfaceExercicio;

ContaCorrente contaCorrente = new ContaCorrente();
contaCorrente.Saldo = 2000;

SeguroDeVida seguroDeVida = new SeguroDeVida();

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

ITributavel tributavel = contaCorrente;
Console.WriteLine($"Conta corrente: {tributavel.CalculaTributos():c}");
totalizador.Adiciona(tributavel);

tributavel = seguroDeVida;
Console.WriteLine($"Seguro de vida: {tributavel.CalculaTributos():c}");
totalizador.Adiciona(tributavel);

Console.WriteLine($"Total de tributos: {totalizador.Total:c}");