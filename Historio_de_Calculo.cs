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
    public partial class Historio_de_Calculo : Form
    {
        Main_Calculadora calculadora = new Main_Calculadora();
        private string[] exibirHistorioco = new string[9999];
        public Historio_de_Calculo(string novoRegistro)
        {
            InitializeComponent();
            //exibirHistorioco = calculadora.getHistorico;
            //MessageBox.Show(calculadora.getHistorico);
            for (int i = 0; i <= calculadora.getCont(); i++)
            {
                //exibirHistorioco[i] = calculadora.getHistorico[i];
                //boxHistorico.Items.Add(calculadora.getHistorico[i]);
                i++;
            }
        }
    }
}
