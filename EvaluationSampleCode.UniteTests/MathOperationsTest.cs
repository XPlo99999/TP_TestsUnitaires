using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UniteTests
{
    [TestClass]
    public class MathOperationsTest
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(30, 2, 32)]
        [DataRow(-5, 15, 10)]
        [DataRow(0, 0, 0)]
        public void Addition(int numberOne, int numberTwo, int expectedResult)
        {
            int result = _mathOperations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(20, 2, 10)]
        [DataRow(10, 2, 5)]
        public void Division(int numberOne, int numberTwo, double expectedResult)
        {
            float result = _mathOperations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void GetOddNumbers_ThrowsArgumentException(int limit)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetOddNumbers(limit));
        }

    }
}
