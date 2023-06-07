using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Leitor_de_video_e_audeo
{
    public partial class leitor2 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        bool verificador = false;
        string[] colecao;

        public leitor2()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl_comeco.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                lbl_fim.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                trackBar_currentTime.Minimum = 0;
                trackBar_currentTime.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                trackBar_currentTime.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            }



        }

        private void leitor2_Load(object sender, EventArgs e)
        {
            trackBar_currentTime.BackColor = Color.LightGray;
            trackBar_volume.BackColor = Color.LightGray;

        }

        private void trackBar1_tempo_Scroll(object sender, EventArgs e)
        {

         
        }

        

        private void btn_parar_Click(object sender, EventArgs e)
        {
            timer_currentTime.Stop();
            btn_playlist_off.Visible = false;
            btn_playlist_on.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            trackBar_currentTime.Value = 0;
            btn_pause.Visible = false;
            btn_parar.Enabled = false;
            btn_play.Visible = true;
            btn_play.Enabled = false;
            btn_next.Enabled = false;
            btn_previous.Enabled = false;
            btn_rep_off.Visible = true;
            btn_rep_off.Enabled = false;
            btn_rep_on.Visible = false;
            btn_expandir.Enabled = false;

        }

        private void btn_limpar_tudo_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_playlist_on_Click(object sender, EventArgs e)
        {
            btn_playlist_on.Visible = false;
            btn_playlist_off.Visible = true;
            axWindowsMediaPlayer1.Visible = false;
            pnl_play_list.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            trackBar_currentTime.BackColor = Color.LightGray;
            trackBar_volume.BackColor = Color.LightGray;
        }

        private void btn_playlist_off_Click(object sender, EventArgs e)
        {
            btn_playlist_on.Visible =true;
            btn_playlist_off.Visible = false;
            axWindowsMediaPlayer1.Visible = true;
            pnl_play_list.Visible =false;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            int i = 0;
            abrir_arquivo.Filter = ("mp4 | *.mp4| mp3 | *.mp3|*.*|*.*");
            if (abrir_arquivo.ShowDialog() == DialogResult.OK)
            {
                foreach (var arquivo in abrir_arquivo.FileNames)
                {
                    colecao = new string[arquivo.Length];

                    lst_playlist.Items.Add(arquivo);
                    colecao[i] = arquivo; i++;
                    axWindowsMediaPlayer1.URL = arquivo;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    lbl_nome_arquivo.Text = axWindowsMediaPlayer1.currentMedia.name;
                }
            }
                pnl_play_list.Visible = false;
                axWindowsMediaPlayer1.Visible = true;
                btn_play.Visible = false;
                btn_play.Enabled = true;
                btn_pause.Visible = true;
                btn_rep_off.Enabled = true;
                btn_previous.Enabled = true;
                btn_next.Enabled = true;
                btn_parar.Enabled = true;
                btn_expandir.Enabled = true;
                btn_expandir.Enabled = true;
            btn_playlist_off.Visible = false ;
            btn_playlist_on.Visible = true;
            timer_currentTime.Start();
;            
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar_volume.Value;
            lbl_volume.Text = trackBar_volume.Value.ToString() + "%";

            if (trackBar_volume.Value <= 0)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                btn_com_som.Visible = false;
                btn_sem_som.Visible = true;
            }
            else
            {

                axWindowsMediaPlayer1.settings.mute = false;
                btn_com_som.Visible = true;
                btn_sem_som.Visible = false;
            }
        }

        private void btn_com_som_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;
            btn_com_som.Visible = false;
            btn_sem_som.Visible = true;
        }

        private void btn_sem_som_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = false;
            btn_com_som.Visible = true;
            btn_sem_som.Visible = false;
         
        }

        private void abrir_arquivo_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_limpar_tudo_Click_1(object sender, EventArgs e)
        {
            lst_playlist.Items.Clear();
        }

        private void btn_limpar_selecionado_Click(object sender, EventArgs e)
        {
            if (lst_playlist.SelectedIndex >= 0)
            {
                lst_playlist.Items.RemoveAt(lst_playlist.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para ser eliminado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBar_currentTime_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar_currentTime.Value;
        }

        private void btn_rep_off_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("Loop", true);
            btn_rep_on.Visible = true;
            btn_rep_off.Visible = false;
        }

        private void btn_rep_on_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("Loop", false);
            btn_rep_on.Visible = false;
            btn_rep_off.Visible = true;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btn_play.Visible = false;
            btn_pause.Visible = true;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btn_play.Visible = true;
            btn_pause.Visible = false;
        }
      
        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_max.Visible = false;
            btn_normal.Visible = true;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_max.Visible = true;
            btn_normal.Visible = false;
        }

        private void btn_expandir_Click(object sender, EventArgs e)
        {
            verificador = true;
            this.WindowState = FormWindowState.Maximized;
            pnl_controles.Visible = false;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            btn_comprimir.Visible = true;
            pnl_cima.Visible = false;
            btn_expandir.Visible = false;
            lst_playlist.Visible = true;

            axWindowsMediaPlayer1.Anchor = AnchorStyles.Left;
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Top;
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Right;
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Bottom;
        }

        private void btn_comprimir_Click(object sender, EventArgs e)
        {
            verificador = false;
            this.WindowState = FormWindowState.Normal;
            pnl_controles.Visible = true;
            axWindowsMediaPlayer1.Dock = DockStyle.None;
            btn_comprimir.Visible = false;
            pnl_cima.Visible = true;
            btn_expandir.Visible = true;
        }

        private void axWindowsMediaPlayer1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {

        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (verificador == true)
            {
                if (pnl_controles.Visible == true)
                {
                    pnl_controles.Visible = false;
                }
                else
                {
                    pnl_controles.Visible = true;
                }
            }
            else
            {

            }

        }

        private void lst_playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = lst_playlist.SelectedItem.ToString();
            pnl_play_list.Visible = false;
            axWindowsMediaPlayer1.Visible = true;
            btn_play.Visible = false;
            btn_play.Enabled = true;
            btn_pause.Visible = true;
            btn_rep_off.Enabled = true;
            btn_previous.Enabled = true;
            btn_next.Enabled = true;
            btn_parar.Enabled = true;
            btn_expandir.Enabled = true;
            btn_expandir.Enabled = true;
            timer_currentTime.Start();
            btn_playlist_off.Visible = false;
            btn_playlist_on.Visible = true;
            lbl_nome_arquivo.Text = axWindowsMediaPlayer1.currentMedia.name;

        }

        private void leitor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                trackBar_volume.Value += 1;
            }
            if (e.KeyCode == Keys.Down)
            {
                trackBar_volume.Value -= 1;

            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int c = 0;
           
            axWindowsMediaPlayer1.URL = colecao[c] ;
            timer_currentTime.Start();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lbl_nome_arquivo.Text = axWindowsMediaPlayer1.currentMedia.name;
            c++;
        }

        private void pnl_cima_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            int c = 0;

            axWindowsMediaPlayer1.URL = colecao[c];
            timer_currentTime.Start();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lbl_nome_arquivo.Text = axWindowsMediaPlayer1.currentMedia.name;
            c--; 
        }
    }
}