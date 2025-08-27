using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); 
        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!!!");
        Console.WriteLine("Acerte o numero entre 1 a 100 para ganhar.");

        while (palpite != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            string entrada = Console.ReadLine();

          
            if (!int.TryParse(entrada, out palpite))
            {
                Console.WriteLine("Coloque numero(s),não letra.");
                continue;
            }

            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("Tente um número MAIOR.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Tente um número MENOR.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
            }
        }
    }
}