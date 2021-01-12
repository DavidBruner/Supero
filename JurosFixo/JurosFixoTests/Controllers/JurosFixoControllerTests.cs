using Microsoft.VisualStudio.TestTools.UnitTesting;
using JurosFixo.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace JurosFixo.Controllers.Tests
{
    [TestClass]
    public class JurosFixoControllerTests
    {
        [TestMethod()]
        public void TaxaJurosGetTest()
        {
            JurosFixoController controller = new JurosFixoController();

            string result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual("0,01", result);
        }
    }
}