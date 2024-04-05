using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            InicioGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            InicioGame(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            InicioGame(1);
        }

        private void InicioGame(int opcao)
        {
            labResultado.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogada(opcao))
            {
                case Game.resultado.Ganhar:
                    resultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.resultado.Perder:
                    resultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.resultado.Empatar:
                    resultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = jogo.imgJogador;
                    pictureBox2.Image = jogo.imgPC;
                    break;
            }
        }
    }
}
