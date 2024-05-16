Console.Write("Olá jogador! Como gostaria de ser chamado? ");
string? nome = Console.ReadLine();
if (nome == null || nome == ""){
  nome = "Jogador";
}

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
      jogador.ConfigurarVida(5);
      Jogar();
      break;
    case "2":
      sorteador.ConfigurarDificuldade(2);
      jogador.ConfigurarVida(10);
      Jogar();
      break;
    default:
      Console.Clear();
      Console.WriteLine("Por favor, escolha uma opção válida.");
      Console.ReadKey();
      break;
  }
}

void Jogar(){
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
        sorteador.ConfigurarDificuldade(sorteador.Dificuldade);
        jogador.ConfigurarVida(sorteador.Dificuldade * 5);
      }
      else
      {
        break;
      }
    }
    else
    {
      jogador.PerderVida();
      if (jogador.Vida == 0)
      {
        Console.WriteLine($"\nGame Over! O número sorteado foi: {sorteador.Numero}");
        bool res = menus.MenuJogarNovamente();
        if (res)
        {
          sorteador.ConfigurarDificuldade(sorteador.Dificuldade);
          jogador.ConfigurarVida(sorteador.Dificuldade * 5);
        }
        else
        {
          break;
        }
      }
    }
  }
}