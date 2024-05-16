Console.Write("Olá jogador! Como gostaria de ser chamado? ");
string nome = Console.ReadLine() ?? "Jogador";

Jogador jogador = new Jogador(nome);
Sorteador sorteador = new Sorteador();
Menu menus = new Menu();

while (true)
{
  menus.MenuInicial(jogador);
  string escolha = Console.ReadLine() ?? "";
  if (escolha == "3")
  {
    break;
  };

  switch (escolha)
  {
    case "1":
      sorteador.ConfigurarDificuldade(1);
      break;
    case "2":
      sorteador.ConfigurarDificuldade(2);
      break;
    default:
      Console.Clear();
      Console.WriteLine("Por favor, escolha uma opção válida.");
      Console.ReadKey();
      break;
  }

  while (true)
  {
    int palpite = menus.MenuJogo(jogador, sorteador.Dificuldade);
    bool acertou = sorteador.VerificarNumero(palpite);
    Console.ReadKey();
    if (acertou)
    {
      bool res = menus.MenuJogarNovamente();
      if (res)
      {
        break;
      }
    }
    else
    {
      jogador.PerderVida();
    }
  }
}