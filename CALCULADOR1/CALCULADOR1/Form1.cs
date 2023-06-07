using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADOR1
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool ressultado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(textBox1.Text);

            txtOperacao.Text += "x";

            textBox1.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

            txtOperacao.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

            txtOperacao.Text += "2";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

            txtOperacao.Text += "3";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

            txtOperacao.Text += "4";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

            txtOperacao.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

            txtOperacao.Text += "6";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

            txtOperacao.Text += "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

            txtOperacao.Text += "9";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

            txtOperacao.Text += "8";


        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

            txtOperacao.Text += "0";


        }

        private void Operacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(textBox1.Text);

            txtOperacao.Text += "+";

            textBox1.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;



        }

        private void button12_Click(object sender, EventArgs e)
        {
            ressultado = true;

            txtOperacao.Text += "=";
            //OPERAÇÃO DE CALCULO PARA ADIÇÃO
            if (adicao == true)

            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) + calculo);

                txtOperacao.Text += textBox1.Text;
            }
            //OPERAÇÃO DE CALCULO PARA SUBTRAÇÃO 
            if (subtracao == true)

            {
                textBox1.Text = Convert.ToString(calculo - Convert.ToDecimal(textBox1.Text));

                txtOperacao.Text += textBox1.Text;

            }
            //OPERAÇÃO DE CALCULO PARA MULTIPLICAÇÃO
            if (multiplicacao == true)

            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) * calculo);

                txtOperacao.Text += textBox1.Text;
            }
            //OPERAÇÃO DE CALCULO PARA DIVISÃO
            if (divisao == true)

            {
                textBox1.Text = Convert.ToString(calculo / Convert.ToDecimal(textBox1.Text));

                txtOperacao.Text += textBox1.Text;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {

                string Apagar = textBox1.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);

                textBox1.Text = Apagar;

                txtOperacao.Text = Apagar;

            }
            catch (Exception)
            {

            }

        }


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtOperacao.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(textBox1.Text);

            txtOperacao.Text += "-";

            textBox1.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;



        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(textBox1.Text);

            txtOperacao.Text += "/";

            textBox1.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;


        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.Text += ",";

            txtOperacao.Text += ",";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;

                textBox1.Text = Convert.ToString(valor1 - (percentual * valor1));

                txtOperacao.Text += "% =";
                txtOperacao.Text += textBox1.Text;
            }

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }
    }
}


