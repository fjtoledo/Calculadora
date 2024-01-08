using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{ 
    public partial class Form1 : Form
    {
        public decimal Valor 
        {  
            get; 
            set; 
        }

        public decimal Valor1
        {
            get;
            set;
        }

        public string Mostrar
        {
            get;
            set;
        }

        public decimal Resultado 
        { 
            get; 
            set; 
        }

        private Operacao Selecaodeoperacao 
        { 
            get; 
            set; 
        }

        private enum Operacao 
        {
            mais,
            menos,
            vezes,
            dividir

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "1";
            
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "2";

        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "3";

        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "4";

        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "5";

        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "6";

        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "7";

        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "8";

        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "9";

        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            tbx_display.Text += ",";

        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            tbx_display.Text += "0";

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {

            Valor1 = Convert.ToDecimal(tbx_display.Text);

            switch (Selecaodeoperacao)
            {
                case Operacao.mais:
                    Mostrar = Convert.ToString(Valor) + " " + "+" + " " + Convert.ToString(Valor1) + " " + "=" + " ";
                    Resultado = Valor + Valor1;
                    break;
                case Operacao.menos:
                    Mostrar = Convert.ToString(Valor) + " " + "-" + " " + Convert.ToString(Valor1) + " " + "=" + " ";
                    Resultado = Valor - Valor1;
                    break;
                case Operacao.vezes:
                    Mostrar = Convert.ToString(Valor) + " " + "*" + " " + Convert.ToString(Valor1) + " " + "=" + " ";
                    Resultado = Valor * Valor1;
                    break;
                case Operacao.dividir:
                    Mostrar = Convert.ToString(Valor) + " " + " " + "/" + " " + Convert.ToString(Valor1) + " " + "=" + " ";
                    Resultado = Valor / Valor1;
                    break;
            }

            tbx_display.Text = Mostrar + Resultado.ToString();
            
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            Selecaodeoperacao = Operacao.mais;
            Valor = Convert.ToDecimal(tbx_display.Text);
            tbx_display.Text = "";
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            Selecaodeoperacao = Operacao.menos;
            Valor = Convert.ToDecimal(tbx_display.Text);
            tbx_display.Text = "";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            Selecaodeoperacao = Operacao.vezes;
            Valor = Convert.ToDecimal(tbx_display.Text);
            tbx_display.Text = "";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {

            Selecaodeoperacao = Operacao.dividir;
            Valor = Convert.ToDecimal(tbx_display.Text);
            tbx_display.Text = "";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tbx_display.Text = "";
        }


    }
}
