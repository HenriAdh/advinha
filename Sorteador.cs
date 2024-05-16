public class Sorteador
{
  public int Numero = 0;
  public int Dificuldade = 0;

  public Sorteador() { }

  public void ConfigurarDificuldade(int dificuldade)
  {
    Random random = new Random();
    Numero = random.Next(dificuldade * 20);
    Dificuldade = dificuldade;
  }

  public bool VerificarNumero(int num)
  {
    if (Numero == num)
    {
      Console.WriteLine($"\nVocê acertou! o número sorteado é: {Numero}");
      return true;
    }

    if (Numero > num)
    {
      Console.WriteLine($"\nO número sorteado é maior que o digitado.");
    }
    else
    {
      Console.WriteLine($"\nO Número sorteado é menor que o digitado.");
    }
    return false;
  }
}