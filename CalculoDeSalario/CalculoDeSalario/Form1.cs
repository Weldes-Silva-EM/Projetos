using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = gbxTurno.Controls.OfType
            <RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.
            OfType<RadioButton>().SingleOrDefault
            (r => r.Checked);
            RealizarProcessamento(rbnTurno, rbnCategoria,
            Convert.ToDouble(textBox_HorasTrabalhadas.Text),
            Convert.ToDouble(txtSalarioMinimo.Text));
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double valorCoeficiente = 0; switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(textBox_SalarioMinimo.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(textBox_SalarioMinimo.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(textBox_SalarioMinimo.Text) * 0.03;
                    break;
            }
            return valorCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;
            return valorGratificacao;
        }

        private static double GetImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.02;
                    break;
                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }
            return valorImposto;
        }

        private double GetAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao =
            (valorSalarioBruto / 3) / 2;
            if (rbnCategoria.Text.Equals("Calouro") &&
               (valorSalarioBruto <
               (valorSalarioMinimo / 2)))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            return valorAuxilioAlimentacao;
        }

        private void ApresentarResultados(double valorCoeficiente,
        double valorSalarioBruto, double valorImposto,
        double valorGratificacao, double
        valorAuxilioAlimentacao, double
        valorSalarioLiquido)
        {
            txtSituacaoEstagiario.Text = GetSituacaoEstagiario(valorSalarioLiquido);
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Valor do coeficiente:", valorCoeficiente));
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Salário bruto:", valorSalarioBruto));
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Valor do imposto :", valorImposto));
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Valor da gratificação :", valorGratificacao));
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Valor auxilio alimentação :",valorAuxilioAlimentacao));
            IbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}","Salário líquido:", valorSalarioLiquido));
        }

        private string GetSituacaoEstagiario(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";
        }

        private void RealizarProcessamento(RadioButton rbnTurno, RadioButton rbnCategoria, double textBox_HorasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, textBox_HorasTrabalhadas);
            double valorSalarioBruto = textBox_HorasTrabalhadas * valorCoeficiente;
            double valorImposto = GetValorImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;
            ApresentarResultados(valorCoeficiente,valorSalarioBruto, valorImposto,valorGratificacao, valorAuxilioAlimentacao,valorSalarioLiquido);

        }

        private double GetValorAuxilioAlimentacao(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            throw new NotImplementedException();
        }

        private double GetValorImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            throw new NotImplementedException();
        }
    }

}



