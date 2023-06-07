using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Despertador : Form
    {
        public Despertador()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer_hora.Enabled = true;
            pnAlarme.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnAlarme.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            HH.Clear();
            MM.Clear();
        }

        private void HH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void MM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnAlarme.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HH.Text == "" && MM.Text == "")
            {
                MessageBox.Show("Nenhum campo pode permanecer vázio", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HH.Clear();
                MM.Clear();

            }
            else if (HH.Text == "" || MM.Text == "")
            {
                MessageBox.Show("Nenhum campo pode permanecer vázio", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HH.Clear();
                MM.Clear();
            }

            else
            {
                varHH = int.Parse(HH.Text);
                varMM = int.Parse(MM.Text);
                MessageBox.Show("Alarme salvo", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HH.Clear();
                MM.Clear();
                pnAlarme.Enabled = false;
                btnCancelar.Enabled = false;
                btnNovo.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (varHH == System.DateTime.Now.Hour && varMM == System.DateTime.Now.Minute)
            {
                timer_alarme.Enabled = false;
                Alarme_tocando _alarme_tocando = new Alarme_tocando();
                _alarme_tocando.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
