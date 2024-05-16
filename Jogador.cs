public class Jogador
{
  public string Nome { get; }
  public int Vida { get; set; }

  public Jogador(string nome)
  {
    Nome = nome;
    Vida = 1;
  }

  public void ConfigurarVida(int vida)
  {
    Vida = vida;
  }

  public void PerderVida()
  {
    Vida -= 1;
  }
}