using Employees.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly HourlyCalculator hourlyCalculator;
        public UnitTest1()
        {
            hourlyCalculator = new HourlyCalculator(800000);
        }
        [TestMethod]
        public void Test1()
        {
            var result = hourlyCalculator.CalculateSalary();
            Assert.AreEqual("1152000000", "Calculo Correcto");
        }

        [TestMethod]
        public void Test2()
        {
            var result = hourlyCalculator.CalculateSalary();
            Assert.AreNotEqual("1152000000", "Calculo Incorrecto");
        }
    }
}
