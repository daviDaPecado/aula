using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Tabuleiro
    {
  
        private char[] casas;

     
        public Tabuleiro()
        {
            casas = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

    
        public void Desenhar()
        {
            Console.Clear();
            Console.WriteLine(@$"{casas[0]} | {casas[1]} | {casas[2]}
---+---+---
{casas[3]} | {casas[4]} | {casas[5]}
---+---+---
{casas[6]} | {casas[7]} | {casas[8]}");
        }

      
        public bool MarcarJogada(int posicao, char simbolo)
        {
           
            if (posicao >= 1 && posicao <= 9)
            {
                if (casas[posicao - 1] != 'X' && casas[posicao - 1] != 'O')
                {
                   
                    casas[posicao - 1] = simbolo;
                    return true;
                }
            }
            return false;
        }

        public bool VerificarVencedor(char simbolo)
        {

            if (casas[0] == simbolo && casas[1] == simbolo && casas[2] == simbolo) { return true; }
            if (casas[3] == simbolo && casas[4] == simbolo && casas[5] == simbolo) { return true; }
            if (casas[6] == simbolo && casas[7] == simbolo && casas[8] == simbolo) { return true; }

            if (casas[0] == simbolo && casas[3] == simbolo && casas[6] == simbolo) { return true; }
            if (casas[1] == simbolo && casas[4] == simbolo && casas[7] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[5] == simbolo && casas[8] == simbolo) { return true; }

            
            if (casas[0] == simbolo && casas[4] == simbolo && casas[8] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[4] == simbolo && casas[6] == simbolo) { return true; }

            return false;
        }

        public bool VerificarEmpate()
        {
            foreach (var casa in casas)
            {
            
                if (casa != 'X' && casa != 'O')
                {
                    return false;
                }
            }

            return true;
        }
    }
}