using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadoraCientifica {
    public partial class wfaCalculadora : Form {
        public wfaCalculadora() {
            InitializeComponent();
        }

        bool vaiMudar = false , fecharPar = false;

        private void historico(string num, string mem)
        {
            Panel pnHis = new Panel();
        }

        private void PnFoco()
        {

        }
        private void btn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;

            if(lblResultado.Text == "0" || vaiMudar) {
                lblResultado.Text = "";
                vaiMudar = false;
            }

            lblResultado.Text += btn.Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            string aux = lblResultado.Text;
            lblResultado.Text = calcular(lblConta.Text + lblResultado.Text).ToString();

            lblConta.Text += aux + " " + btn.Text + " ";
            vaiMudar = true; 
        }

        private double calcular(string expressao) {
            expressao = expressao.Replace(",", ".");
            expressao = expressao.Replace("÷", "/");
            expressao = expressao.Replace("×", "*");

            try {
                System.Data.DataTable tabela = new System.Data.DataTable();
                tabela.Columns.Add("expressao", String.Empty.GetType(), expressao);
                System.Data.DataRow linha = tabela.NewRow();
                tabela.Rows.Add(linha);

                return double.Parse((string)linha["expressao"]);
            }
            catch {
                return double.Parse("0");
            }

        }

        private string decimalToDegree(string dec) {
            double decimalDegree = double.Parse(dec);

            int cont = int.Parse(((decimalDegree - Math.Floor(decimalDegree)) / 0.6).ToString().Split(',')[0]);
            string degree = (cont + Math.Floor(decimalDegree)).ToString() + "," + ((decimalDegree - Math.Floor(decimalDegree)) / 0.6).ToString().Split(',')[1];
            return degree;
        }

        private string decimalToMinutes(string dec) {
            double decimalDegree = double.Parse(dec);
            int cont = int.Parse(((decimalDegree - Math.Floor(decimalDegree)) * 0.6).ToString().Split(',')[0]);
            string degree = (cont + Math.Floor(decimalDegree)).ToString() + "," + ((decimalDegree - Math.Floor(decimalDegree)) / 0.6).ToString().Split(',')[1];
            return degree;
        }

        private void btnVirgula_Click(object sender, EventArgs e) {
            if(!lblResultado.Text.Contains(",")) {
                lblResultado.Text += ",";
            }
        }

        private void btnCE_Click(object sender, EventArgs e) {
            lblResultado.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e) {
            lblConta.Text = "";
            lblResultado.Text = "0";
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if(lblResultado.Text != "") {
                lblResultado.Text = lblResultado.Text.Substring(0, lblResultado.Text.Length - 1);
            }
        }
         
        private void btnMiasOuMenos_Click(object sender, EventArgs e) {
            lblResultado.Text = (double.Parse(lblResultado.Text) * -1 ).ToString();
        }

        private void btnIgual_Click(object sender, EventArgs e) {
            string conta = lblConta.Text + lblResultado.Text;
            double resultado = calcular(conta);
            lblResultado.Text = resultado.ToString();
            lblConta.Text = "";
            vaiMudar = true;
        }

        private void btnXQuad_Click(object sender, EventArgs e) {
            lblResultado.Text = (Math.Pow(double.Parse(lblResultado.Text),2)).ToString();
            vaiMudar = true;
        }

        private void btnXCubico_Click(object sender, EventArgs e) {
            lblResultado.Text = (Math.Pow(double.Parse(lblResultado.Text), 3)).ToString();
            vaiMudar = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e) {
            lblResultado.Text = (Math.Sqrt(double.Parse(lblResultado.Text))).ToString();
            vaiMudar = true;
        }

        private void btnXElevY_Click(object sender, EventArgs e) {
            lblResultado.Text = (Math.Pow(double.Parse(lblResultado.Text), 3)).ToString();
            vaiMudar = true;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.Sin(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.Cos(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.Tan(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnDezElevX_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.Pow(10, double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.Log(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            string result = lblResultado.Text;
            if (result.Contains(","))
                lblResultado.Text = result + "E+";
            else
                lblResultado.Text = result + ",E+";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            string aux = lblResultado.Text;
            lblResultado.Text = calcular(lblConta.Text + lblResultado.Text).ToString();

            lblConta.Text += aux + " Mod ";
            vaiMudar = true;
        }

        private void btnUmSobreX_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (1 / double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnEElevX_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Math.Pow(Math.E, double.Parse(lblResultado.Text))).ToString();
            vaiMudar = true;
        }

        private void btnIn_Click(object sender, EventArgs e) {
            lblResultado.Text = (Math.Log(Math.E, double.Parse(lblResultado.Text)) / (Math.Log(Math.E))).ToString();
            vaiMudar = true;
        }

        private void btnDms_Click(object sender, EventArgs e) {
            lblResultado.Text = decimalToMinutes(lblResultado.Text);
            vaiMudar = true;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Math.PI.ToString();
            vaiMudar = true;
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            double num = double.Parse(lblResultado.Text);
            double aux = Math.Abs(double.Parse(lblResultado.Text));
            

            if (aux == 0)
            {
                lblResultado.Text = "1";
            } else
            {
                double fat = 1;

                for( double i = aux; i > 0; i-- )
                {
                    fat *= i;
                }

                if( num > 0)
                {
                    lblResultado.Text = fat.ToString();
                } else
                {
                    lblResultado.Text = (fat * -1).ToString();
                }
            }

            vaiMudar = true;
        }

        private void btnParentDir_Click(object sender, EventArgs e) {
            string aux = lblResultado.Text;
            lblResultado.Text = calcular(lblConta.Text + lblResultado.Text).ToString();

            lblConta.Text += aux + " ) ";
            vaiMudar = true;
            fecharPar = true;

        }

        private void btnParentEsq_Click(object sender, EventArgs e) {
            string aux = lblResultado.Text;
            lblResultado.Text = calcular(lblConta.Text + lblResultado.Text).ToString();

            lblConta.Text += aux + " ( ";
            vaiMudar = true;
        }

        private void btnDeg_Click(object sender, EventArgs e) {
            lblResultado.Text = decimalToDegree(lblResultado.Text);
            vaiMudar = true;
        }

        private void btnAsin_Click(object sender, EventArgs e) {
            lblResultado.Text = Math.Asin(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        private void btnAcos_Click(object sender, EventArgs e){
            lblResultado.Text = Math.Acos(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }

        

        private void btnATang_Click(object sender, EventArgs e){
            lblResultado.Text = Math.Atan(double.Parse(lblResultado.Text)).ToString();
            vaiMudar = true;
        }
    }
}
