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
    public partial class Main_Calculadora : Form
    {
        public Main_Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "1";
            else
                lbNumero.Text = "1";
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "2";
            else
                lbNumero.Text = "2";
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "3";
            else
                lbNumero.Text = "3";
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "4";
            else
                lbNumero.Text = "4";
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "5";
            else
                lbNumero.Text = "5";
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "6";
            else
                lbNumero.Text = "6";
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "7";
            else
                lbNumero.Text = "7";
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "8";
            else
                lbNumero.Text = "8";
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "9";
            else
                lbNumero.Text = "9";
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            
            lbNumero.Text = "0";
        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            if (lbNumero.Text != "0")
                lbNumero.Text += "0";
            else
                lbNumero.Text = "0";
        }

        private void bntMais_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "+";//mostrar operação
            if(lbResultado.Text == "")
                lbResultado.Text = "0";
            
            double n1 = double.Parse(lbNumero.Text);
            double n2 = double.Parse(lbResultado.Text);
            double resultado = n1 + n2;
            lbResultado.Text = resultado.ToString();
            
            txtHistorico.Text += lbResultado.Text + lbOperacao.Text + "\n";//gravar Historico

        }

        private void bntMenos_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "-";
            lbResultado.Text = lbNumero.Text;
        }

        private void bntVezes_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "*";
            lbResultado.Text = lbNumero.Text;
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            lbOperacao.Text = "/";
            lbResultado.Text = lbNumero.Text;
        }

        private void bntHistorico_Click(object sender, EventArgs e)
        {
            Historio_de_Calculo historio_De_Calculo = new Historio_de_Calculo(txtHistorico.Text);
            historio_De_Calculo.ShowDialog();
        }

        private void bntApaga_Click(object sender, EventArgs e)
        {
            lbNumero.Text = lbNumero.Text.Substring(0, lbNumero.Text.Length - 1);
            if(lbNumero.Text == "")
            {
                lbNumero.Text = "0";
            }            
        }

        private void Main_Calculadora_KeyDown(object sender, KeyEventArgs tecla)
        {
            if(tecla.KeyValue == 49 || tecla.KeyValue == 97)//pressionar a tecla 1
            {
                bnt1.PerformClick();//button1_Click(null, null); poderia ser assim para achar o metodo direto do Click
            }

            if (tecla.KeyValue == 50 || tecla.KeyValue == 98)//pressionar a tecla 2
            {
                bnt2.PerformClick();
            }

            if (tecla.KeyValue == 51 || tecla.KeyValue == 99)//pressionar a tecla 3
            {
                bnt3.PerformClick();
            }

            if (tecla.KeyValue == 52 || tecla.KeyValue == 100)//pressionar a tecla 4
            {
                bnt4.PerformClick();
            }

            if (tecla.KeyValue == 53 || tecla.KeyValue == 101)//pressionar a tecla 5
            {
                bnt5.PerformClick();
            }

            if (tecla.KeyValue == 54 || tecla.KeyValue == 102)//pressionar a tecla 6
            {
                bnt6.PerformClick();
            }

            if (tecla.KeyValue == 55 || tecla.KeyValue == 103)//pressionar a tecla 7
            {
                bnt7.PerformClick();
            }

            if (tecla.KeyValue == 56 || tecla.KeyValue == 104)//pressionar a tecla 8
            {
                bnt8.PerformClick();
            }

            if (tecla.KeyValue == 57 || tecla.KeyValue == 105)//pressionar a tecla 9
            {
                bnt9.PerformClick();
            }

            if (tecla.KeyValue == 96 || tecla.KeyValue == 48)//pressionar a tecla 0
            {
                bnt0.PerformClick();
            }
        }
    }
}
