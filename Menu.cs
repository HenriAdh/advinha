using System;
public class Menu
{
  public void MenuInicial(Jogador jogador)
  {
    Console.Clear();
    Console.WriteLine($"Bem vindo {jogador.Nome}, escolha uma opção:");
    Console.WriteLine($"--------------------------------------------");
    Console.WriteLine($"[1] Nível fácil        - número entre 0 e 20");
    Console.WriteLine($"[2] Nível dificil      - número entre 0 e 40");
    Console.WriteLine($"[3] Sair\n");
  }

  public int MenuJogo(Jogador jogador, int dificuldade)
  {
    Console.Clear();
    Console.WriteLine($"Vidas: {jogador.Vida}\n");
    Console.WriteLine($"Qual seria o seu palpite? (0 a {dificuldade * 20})");
    int palpite = Convert.ToInt32(Console.ReadLine() ?? "41");
    return palpite;
  }

  public bool MenuJogarNovamente()
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("Deseja jogar novamente? (s/n)");
      string? resposta = Console.ReadLine();

      switch (resposta)
      {
        case "s":
          return true;
        case "n":
          return false;
        default:
          Console.WriteLine("\nDigite \"s\" para sim ou \"n\" para não");
          break;
      }
    }
  }
}