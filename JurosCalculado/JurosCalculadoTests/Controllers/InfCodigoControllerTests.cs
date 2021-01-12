using Microsoft.VisualStudio.TestTools.UnitTesting;
using JurosCalculado.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosCalculado.Controllers.Tests
{
    [TestClass()]
    public class InfCodigoControllerTests
    {
        [TestMethod()]
        public void TaxaJurosGetTest()
        {
            InfCodigoController controller = new InfCodigoController();

            string result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual("https://github.com/DavidBruner/Supero", result);
        }
    }
}