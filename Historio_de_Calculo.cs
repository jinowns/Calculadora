﻿using System;
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
        public Historio_de_Calculo(string novoRegistro)
        {
            InitializeComponent();
            txtHistorico.Text = novoRegistro;
        }
    }
}