public class Batalha
{
    private Personagem heroi;
    private Monstro monstro;

    public void IniciarBatalha(Personagem heroi, Monstro monstro)
    {
        this.heroi = heroi;
        this.monstro = monstro;

        Console.WriteLine(" A batalha começou!");
        Console.WriteLine($"{heroi.Nome} vs {monstro.Nome}");

        while (heroi.EstaVivo && monstro.EstaVivo)
        {
            Console.WriteLine("\nTurno do Herói:");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Recuperar Vida");
            Console.Write("Escolha sua ação: ");
            string escolha = Console.ReadLine();

            if (escolha == "1")
                heroi.Atacar(monstro);
            else if (escolha == "2")
                heroi.Curar();
            else
                Console.WriteLine("Ação inválida. Perdeu o turno!");

            if (!monstro.EstaVivo || !heroi.EstaVivo) break;

            Console.WriteLine("\nTurno do Monstro:");
            monstro.Atacar(heroi);
        }

        Console.WriteLine("\n Fim da batalha!");
        if (heroi.EstaVivo)
            Console.WriteLine($" {heroi.Nome} venceu!");
        else
            Console.WriteLine($" {monstro.Nome} venceu!");
    }
}
