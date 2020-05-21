using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ExemploBDD
{
    [Binding]
    public sealed class ConvTemperaturaStepDefinition
    {
        public double _temperaturaFahrenheit;
        public double _temperaturaCelsius;
        public double _temperaturaKelvin;

        [Given("que o valor da temperatura é de (.*) graus Fahrenhei")]
            public void CarregarTemperaturaFahrenheit(double temperatura)
            {
            this._temperaturaFahrenheit = temperatura;
            }
        [When("eu solicitar a conversão desta temperatura")]
        public void ProcessarConversaoTemperatura()
        {
            this._temperaturaCelsius = ConversorTemperatura.FahrenheitParaCelsius
                (this._temperaturaFahrenheit);
            this._temperaturaKelvin = ConversorTemperatura.FahrenheitParaKelvin
                (this._temperaturaFahrenheit);
        }

        [Then("o resultado da conversão para Celsius será de (.*) graus")]
        public void VerificarTemperaturaCelsius(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaCelsius);
        }

        [Then("o resultado da conversão para Kelvin será de (.*) graus")]
        public void VerificarTemperaturaKelvin(double temperatura)
        {
            Assert.AreEqual(temperatura, this._temperaturaKelvin);
        }

        private readonly ScenarioContext context;

        public ConvTemperaturaStepDefinition(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            context.Pending();
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            context.Pending();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            context.Pending();

            
        }
    }
}
