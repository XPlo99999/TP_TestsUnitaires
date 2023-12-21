using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UniteTests
{
    [TestClass]
    public class CustomStackTest
    {
        private CustomStack _customStack;

        [TestInitialize]
        public void Init()
        {
            _customStack = new CustomStack();
        }

        [TestMethod]
        public void Count_Empty_Zero()
        {
            int result = _customStack.Count();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Count_One_One()
        {
            _customStack.Push(20);

            int result = _customStack.Count();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Push_Add()
        {
            _customStack.Push(20);

            Assert.AreEqual(1, _customStack.Count());
        }

        [TestMethod]
        public void Pop_Remove_And_Show_LastItem()
        {
            _customStack.Push(20);
            _customStack.Push(50);

            int result = _customStack.Pop();

            Assert.AreEqual(50, result);
            Assert.AreEqual(1, _customStack.Count());
        }
    }
}
