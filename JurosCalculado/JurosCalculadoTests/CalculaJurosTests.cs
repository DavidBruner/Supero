using Microsoft.VisualStudio.TestTools.UnitTesting;
using JurosCalculado;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosCalculado.Tests
{
    [TestClass()]
    public class CalculaJurosTests
    {
        [TestMethod()]
        public void CalculaTest()
        {

            CalculaJuros controller = new CalculaJuros();

            var result = controller.Calcula(100, 5, 0.01);

            Assert.IsNotNull(result);
            Assert.AreEqual("105,10", result);
        }

        [TestMethod()]
        public void RealizaCalculoTest()
        {
            CalculaJuros controller = new CalculaJuros();

            var result = controller.RealizaCalculo(100, 5);

            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void GetJurosTest()
        {
            //necessário ainda ter fixo 0,01 no projeto JurosFixo
            CalculaJuros controller = new CalculaJuros();

            var result = controller.GetJuros();

            Assert.IsTrue(result != 0);
        }
    }
}