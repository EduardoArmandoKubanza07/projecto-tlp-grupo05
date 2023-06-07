using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class cronometro : Form 
    {
        private Stopwatch stopWatch;
        public cronometro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch= new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbltempo.Text = string.Format("{0:mm\\:ss\\:ff}",stopWatch.Elapsed); 
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            circuloprogressivo.Animated = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            circuloprogressivo.Animated = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            circuloprogressivo.Animated = false;

        }
   
        }
}
