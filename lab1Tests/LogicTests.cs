using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ConverterTestNotZero()
        {
            var valueRub = 230;
            var valueKop = 56;
            var message = Logic.Converter(valueRub, valueKop);
            Assert.AreEqual("Стоимость = 230 рублей 56 копеек", message);
        }
        [TestMethod()]
        public void ConverterTestZero()
        {
            var valueRub = 0;
            var valueKop = 0;
            var message = Logic.Converter(valueRub, valueKop);
            Assert.AreEqual("Стоимость = 0 ровно", message);
        }
    }
}