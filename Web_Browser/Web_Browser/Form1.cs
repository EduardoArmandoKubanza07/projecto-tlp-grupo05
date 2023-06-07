using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        string proximo, anterior;
        
        private void Nav()
        {
            webBrowser1.Navigate(txtURL.Text);
         
           
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            historico();
            Nav();
            pictureBox1.Visible = false;

            txtURL.Text = webBrowser1.Url.ToString();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
           
            webBrowser1.GoForward();
          
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            
            webBrowser1.GoBack();
           
           
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            //txtURL.Text = "google.com";
            webBrowser1.Navigate(urlString: "google.com");
            pictureBox1.Visible = false;
            lbHistorico.Items.Add(txtURL.Text);

        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            //txtURL.Text = "youtube.com";
            webBrowser1.Navigate(urlString: "youtube.com");
            pictureBox1.Visible = false;
            lbHistorico.Items.Add(txtURL.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            pictureBox1.Visible = true;
        }

        private void tbURL_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox1.Visible = false;
            Nav();
        }

       
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            splitHistorico.Visible = true;
           
        }

        private void btnFecharHistorico_Click(object sender, EventArgs e)
        {
            splitHistorico.Visible = false;
        }

        private void historico() { 
            Label lbl = new Label();

            lbl.Text = txtURL.Text;

            lbHistorico.Items.Add(lbl.Text);

        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            lbHistorico.Items.Clear();
        }
    }
}
