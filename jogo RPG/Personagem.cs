public class Personagem : Entidade
{
    public string Classe;

    public Personagem(string nome, string classe, int pontosDeVida, int ataque)
        : base(nome, pontosDeVida, ataque)
    {
        Classe = classe;
    }

    public void Curar()
    {
        int cura = 20;
        PontosDeVida += cura;
        Console.WriteLine($"{Nome} se curou e agora tem {PontosDeVida} pontos de vida.");
    }
}
