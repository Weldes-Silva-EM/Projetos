using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Test
{
    [TestClass]
    public class CarroTest
    {
        [TestMethod]
        public void DevePossuirMotor()
        {
            Carro carro = new Carro();
            Assert.IsNotNull(carro.Motor);
        }

        //Valida se carro possui 4 rodas
        [TestMethod]
        public void DevePossuirQuatroRodas()
        {
            Carro carro = new Carro();
            List<Roda> rodas = carro.Rodas;

            Assert.AreEqual(4, rodas.Count);
        }

        // Valida se carro possui 2 portas
        [TestMethod]
        public void DevePossuirDuasPortas()
        {
            Carro carro = new Carro();
            List<Porta> portas = carro.Portas;

            Assert.AreEqual(2, portas.Count);
        }

    }
}
