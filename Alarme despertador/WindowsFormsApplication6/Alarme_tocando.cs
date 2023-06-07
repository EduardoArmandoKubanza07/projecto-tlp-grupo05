using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication6
{
    public partial class Alarme_tocando : Form
    {
        public Alarme_tocando()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer _player = new WMPLib.WindowsMediaPlayer();

        private void Alarme_tocando_Load(object sender, EventArgs e)
        {
            _player.URL = @"C:\Users\Fernando\Music\Melodias";
            _player.controls.play();
        }

        private void btnDesligar_alarm_Click(object sender, EventArgs e)
        {
            _player.controls.stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbtime_now.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
