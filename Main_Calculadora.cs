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
        private string[,] historico = new string[9999,9999];
        private static int contColuna = 0;
        private static int contLinha = 0;
        double n1 = 0;
        double n2 = 0;
        double resultado = 0;

        public string[,] getHistorico()
        {
            return historico; 
        }
        public void setHistorico(string historico)
        {
            this.historico[contColuna,contLinha] = historico;
            contColuna++;
        }
        public int getCont()
        {
            return contColuna;
        }

        public Main_Calculadora()
        {
            InitializeComponent();
        }

        private void limparNulo ()
        {
            if (lbNumero.Text == "")
            {
                lbNumero.Text = "0";
            }
        }
        private void calcular()
        {
            n1 = double.Parse(lbResultado.Text);
            n2 = double.Parse(lbNumero.Text);

            switch (lbOperacao.Text)
            {
                case "+":
                    resultado = n1 + n2;
                    lbResultado.Text = resultado.ToString();
                    lbNumero.Text = "0";
                    break;

                case "-":
                    resultado = n1 - n2;
                    lbResultado.Text = resultado.ToString();
                    lbNumero.Text = "0";
                    break;

                case "*":
                    resultado = n1 * n2;
                    lbResultado.Text = resultado.ToString();
                    lbNumero.Text = "0";
                    break;

                case "/":
                    resultado = n1 / n2;
                    lbResultado.Text = resultado.ToString();
                    lbNumero.Text = "0";
                    break;
            }
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
            lbResultado.Text = "";
            lbNumero.Text = "0";
            lbOperacao.Text = "";
            n1 = 0;
            n2 = 0;
            resultado = 0;
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
            if(lbOperacao.Text == "")//se a operação estiver vazia vai ser o primeiro calculo
            {
                lbResultado.Text = lbNumero.Text;
                lbNumero.Text = "0";
            }
            else
            {
                calcular();
            }

            lbOperacao.Text = "+";
        }

        private void bntMenos_Click(object sender, EventArgs e)
        {
            if (lbOperacao.Text == "")//se a operação estiver vazia vai ser o primeiro calculo
            {
                lbResultado.Text = lbNumero.Text;
                lbNumero.Text = "0";
            }
            else
            {
                calcular();
            }

            lbOperacao.Text = "-";
        }

        private void bntVezes_Click(object sender, EventArgs e)
        {
            if (lbOperacao.Text == "")//se a operação estiver vazia vai ser o primeiro calculo
            {
                lbResultado.Text = lbNumero.Text;
                lbNumero.Text = "0";
            }
            else
            {
                calcular();
            }

            lbOperacao.Text = "*";
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            if (lbOperacao.Text == "")//se a operação estiver vazia vai ser o primeiro calculo
            {
                lbResultado.Text = lbNumero.Text;
                lbNumero.Text = "0";
            }
            else
            {
                calcular();
            }

            lbOperacao.Text = "/";
        }

        private void bntHistorico_Click(object sender, EventArgs e)
        {
            Historio_de_Calculo historio_De_Calculo = new Historio_de_Calculo(txtHistorico.Text);
            historio_De_Calculo.ShowDialog();
        }

        private void bntApaga_Click(object sender, EventArgs e)
        {
            lbNumero.Text = lbNumero.Text.Substring(0, lbNumero.Text.Length - 1);
            limparNulo();        
        }

        private void bntIgual_Click(object sender, EventArgs e)
        {
            calcular();
            historico[contColuna] = n1.ToString()+ lbOperacao.Text + n2.ToString() + "=" + resultado.ToString();

            MessageBox.Show(historico[contColuna]);
            
            txtHistorico.Text = historico[contColuna] + Environment.NewLine;
            contColuna++;

            //txtHistorico.Text += (lbResultado.Text + lbResultado.Text + lbNumero.Text + Environment.NewLine);
        }

        private void bntVirgula_Click(object sender, EventArgs e)
        {
            //lbNumero.Text += ".";
        }

        private void bntPorcentagem_Click(object sender, EventArgs e)
        {
            String numeroFormatado = string.Format(lbNumero.Text);

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

            if (tecla.KeyValue == 107)//pressionar a tecla +
            {
                bntMais.PerformClick();
            }
            
            if (tecla.KeyValue == 109)//pressionar a tecla -
            {
                bntMenos.PerformClick();
            }
            
            if (tecla.KeyValue == 106)//pressionar a tecla *
            {
                bntVezes.PerformClick();
            }
            
            if (tecla.KeyValue == 111)//pressionar a tecla /
            {
                bntDivisao.PerformClick();
            }

            if (tecla.KeyValue == 13)//pressionar a tecla enter
            {
                bntIgual.PerformClick();
            }

            if (tecla.KeyValue == 8)//pressionar a tecla backspace
            {
                bntApaga.PerformClick();
            }
        }//configuração para presionar as teclas do teclado
    }
}
