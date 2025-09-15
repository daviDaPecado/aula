public class Monstro : Entidade
{
    public string Tipo;

    public Monstro(string nome, int pontosDeVida, int ataque) : base(nome, pontosDeVida, ataque)
    {
    }

    public Monstro(string nome, string tipo, int pontosDeVida, int ataque)
        : base(nome, pontosDeVida, ataque)
    {
        Tipo = tipo;
    }

    public override void ReceberDano(int dano)
    {
        base.ReceberDano(dano);
        Console.WriteLine($"O monstro {Nome} ruge de dor!");
    }
}
