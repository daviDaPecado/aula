class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Bem-vindo a batalha! ");

        Console.Write("Digite o nome do seu herói: ");
        string nomeHeroi = Console.ReadLine();

        Console.Write("Digite o nome do vilão (monstro): ");
        string nomeMonstro = Console.ReadLine();

        var heroi = new Personagem(nomeHeroi, "Guerreiro", 100, 25);
        var monstro = new Monstro(nomeMonstro, "Orc", 80, 20);

        var batalha = new Batalha();
        batalha.IniciarBatalha(heroi, monstro);
    }
}