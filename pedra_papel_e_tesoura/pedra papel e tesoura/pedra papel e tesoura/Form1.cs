using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pedra_papel_e_tesoura
{
    public partial class wfpPedraPapelTesoura : Form
    {
        //isso são imagens que o computador vai usar
        Image[] imgcomputador = new Image[] {
            Properties.Resources.transferir1,
            Properties.Resources.transferir,
            Properties.Resources.transferir__2_
        };
        public wfpPedraPapelTesoura()
        {
            InitializeComponent();
        }
        //o sender armazena os dados do botão que foi clicado
        //()isso é um cast
        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            pictureJogador.Image = bt.BackgroundImage;
            jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));
            jogada jogadaComputador = RetornaJogadaDoComputador();
            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaComputador);

            if (resultado == Resultado.vitoriaComputador)
            {
                lblpontuacaocomputador.Text = (int.Parse(lblpontuacaocomputador.Text) + 1).ToString();
            }
            else if (resultado == Resultado.vitoriaJogador)
            {
                lblpontuacaojogador.Text = (int.Parse(lblpontuacaojogador.Text) + 1).ToString();
            }
        }


        private Resultado RetornaGanhador(jogada Jogador, jogada Computador)
        {
            if (Jogador == jogada.Pedra)
            {
                if (Computador == jogada.Papel)
                {
                    return Resultado.vitoriaComputador;
                }
                else if (Computador == jogada.Tesoura)
                {
                    return Resultado.vitoriaJogador;
                }
            }
            else if (Jogador == jogada.Papel)
            {
                if (Computador == jogada.Pedra)
                {
                    return Resultado.vitoriaJogador;
                }
                else if (Computador == jogada.Tesoura)
                {
                    return Resultado.vitoriaComputador;
                }
            }
            else
            {
                if (Computador == jogada.Pedra)
                {
                    return Resultado.vitoriaComputador;
                }
                else if (Computador == jogada.Papel)
                {
                    return Resultado.vitoriaJogador;
                }
            }

            return Resultado.Empate;

        }

        //aqui o jogador vai escolher a jogada
        private jogada RetornaJogadaDoJogador(int escolha)
        {
            return (jogada)escolha;
        }

        private jogada RetornaJogadaDoComputador()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            pictureComputador.Image = imgcomputador[escolha];
            return (jogada)escolha;
        }
    }

    //aqui armazena os numeros de jogadas possiveis
    //esses numeros encontra-se nas tags dos botões
     enum jogada {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }
    //aqui armazena a vitoria do jogo 
    enum Resultado {
        vitoriaJogador,
        vitoriaComputador,
        Empate
     }
 }
