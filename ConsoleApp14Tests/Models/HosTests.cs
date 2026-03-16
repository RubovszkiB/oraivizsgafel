using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp14.Models;

namespace ConsoleApp14.Models.Tests
{
    [TestClass]
    public class HosTests
    {
        [DataTestMethod]
        [DataRow(1, 50.0)]
        [DataRow(5, 70.0)]
        [DataRow(10, 95.0)]
        [DataRow(18, 135.0)]
        public void ADlevelTest(int level, double expected)
        {
            // Arrange: base AD = 50, AD per level = 5
            var hos = new Hos("TestHero;TestTitle;TestCategory;TestTag;1000;50;5");

            // Act
            var actual = hos.ADlevel(level);

            // Assert (allow tiny floating-point tolerance)
            Assert.AreEqual(expected, actual, 1e-6, $"ADlevel({level}) returned unexpected value.");
        }
    }
}