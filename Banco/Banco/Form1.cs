﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("Weldes L. Silva");
            c.Titular = cliente;

            textoTitular.Text = c.Titular.Nome;

            textoNumero.Text = Convert.ToString(c.Numero);
            textoNumero.Text = Convert.ToString(c.Saldo);

            this.c = new Conta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Operação concluída com Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Operação concluída com Sucesso");
        }


    }
}

