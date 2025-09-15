using System;

namespace jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bem-vindo à batalha! ");

            Console.Write("Digite o nome do seu herói: ");
            string nomeHeroi = Console.ReadLine();

            Console.Write("Digite o nome do vilão: ");
            string nomeMonstro = Console.ReadLine();

            Random rnd = new Random();

            int vidaHeroi = rnd.Next(40, 101);
            int danoHeroi = rnd.Next(40, 101);

            int vidaMonstro = rnd.Next(40, 101);
            int danoMonstro = rnd.Next(40, 101);

            var heroi = new Personagem(nomeHeroi, "Guerreiro", vidaHeroi, danoHeroi);
            var monstro = new Monstro(nomeMonstro, vidaMonstro, danoMonstro);

            var batalha = new Batalha();
            batalha.IniciarBatalha(heroi, monstro);
        }
    }
}