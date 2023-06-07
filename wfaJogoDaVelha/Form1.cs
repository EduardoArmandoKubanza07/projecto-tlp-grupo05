using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaJogoDaVelha {
    public partial class wfaJogoDaVelha : Form {
        bool turno = true ,  jogoFinal = false;
        int xPontos = 0, oPontos = 0, empates = 0 , rodadas = 0 ;
        string[] texto = new string[9];
    
        public wfaJogoDaVelha() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
           

            if(btn.Text == "" && jogoFinal == false) {
                if(turno) {
                    btn.Text = "x";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(1);
                    lblInfor.Text = "Vez do jogador: O";

                } else {
                    btn.Text = "o";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(2);
                    lblInfor.Text = "Vez do jogador: X ";
                }
            } 
        }
        
        // Checagem de quem venceu
        private void vencedor(int jogadorVencedor) {
            jogoFinal = true;

            if(jogadorVencedor == 1) {
                xPontos++;
                lblXPontos.Text = xPontos.ToString();
                MessageBox.Show("Jodador X venceu");
              
            } else {
                oPontos++;
                lblOPontos.Text = oPontos.ToString();
                MessageBox.Show("Jodador O venceu");

            }
        }

        // Checagem das jogadas
        private void checagem(int jogadorChecado) {
            string suporte = (jogadorChecado == 1 ? "x" : "o");
            
            // Checagem horizontal
            for(int horizontal = 0; horizontal < 8; horizontal += 3) {
                if( suporte == texto[horizontal]) {
                    if ((texto[horizontal] == texto[horizontal + 1]) && (texto[horizontal] == texto[horizontal + 2])) {
                        vencedor(jogadorChecado);
                        return;
                    }
                }
            }

            //Checagem vertical
            for (int vertical = 0; vertical < 3; vertical++) {
                if (suporte == texto[vertical]) {
                    if ((texto[vertical] == texto[vertical + 3]) && (texto[vertical] == texto[vertical + 6])) {
                        vencedor(jogadorChecado);
                        return;
                    }
                }
            }

            //Checagem da diagonal principal
            if(texto[0] == suporte) {
                if ((texto[0] == texto[4]) && (texto[0] == texto[8])) {
                    vencedor(jogadorChecado);
                    return;
                }
            }

            //Checagem da diagonal secundária
            if (texto[2] == suporte) {
                if ((texto[2] == texto[4]) && (texto[2] == texto[6])) {
                    vencedor(jogadorChecado);
                    return;
                }
            }

            // Checagem de empate
            if((rodadas == 9) && (jogoFinal == false)) {
                MessageBox.Show("Houve um empate");
                jogoFinal = true;
                empates++;
                lblEmpatePontos.Text = empates.ToString();
                return;
            }
        }

        //Reiniciar o jogo
        private void btnReiniciar_Click(object sender, EventArgs e) {
            btnUm.Text = "";
            btnDois.Text = "";
            btnTres.Text = "";
            btnQuatro.Text = "";
            btnCinco.Text = "";
            btnSeis.Text = "";
            btnSete.Text = "";
            btnOito.Text = "";
            btnNove.Text = "";

            rodadas = 0;
            jogoFinal = false;
            for(int i = 0; i < 9; i++) {
                texto[i] = "";
            }
        }
    }
}
