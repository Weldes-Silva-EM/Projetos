using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ExemploFinancas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploFinancas.Testes
{
    [Binding]
    public sealed class CalcFinanceiroSteps
    {
        private double _valorEmprestimo;
        private double _taxa;
        private int _meses;
        private double _valorFinalPeriodo;

        [Given("que o valor do empréstimo foi R$ (.*)")]
        public void CarregarValorEmprestimo(double valorEmprestimo)
        {
            this._valorEmprestimo = valorEmprestimo;
        }

        [Given("foi definida uma taxa de (.*) mensais")]
        public void CarregarTaxa(double taxa)
        {
            this._taxa = taxa;
        }

        [Given("em um período de (.*) meses")]
        public void CarregarNumMeses(int meses)
        {
            this._meses = meses;
        }

        [When("eu solicitar o valor ao final do período")]
        public void ProcessarCalculo()
        {
            this._valorFinalPeriodo =
                   CalculoFinanceiro.CalcularValorComJurosCompostos(
                       this._valorEmprestimo,
                       this._meses,
                       this._taxa);
        }

        [Then("o valor total a ser pago será (*.)")]
        public void VerificarResultado(double valorFinalPeriodo)
        {
            Assert.AreEqual(valorFinalPeriodo, this._valorFinalPeriodo);
        }
    }
}
