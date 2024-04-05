using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{
    internal class Game
    {
        public enum resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image imgPC {  get;  private set; }
        public Image imgJogador { get; private set; }

        public resultado Jogada(int jogador)
        {
            int Pc = JogadaPC();

            imgJogador = imagens[jogador];
            imgPC = imagens[Pc];

            if (jogador == Pc)
            {
                return resultado.Empatar;
            }
            else if ((jogador == 0 && Pc == 1) || jogador == 1 && Pc == 2 || (jogador == 2 && Pc == 0))
            {
                return resultado.Ganhar;
            }
            else
            {
                return resultado.Perder;
            }

            
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;
            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {  
                return 1;
            }
            else
            { 
                return 2;
            }
        }
    }
}
