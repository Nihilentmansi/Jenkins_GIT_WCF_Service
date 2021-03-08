using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_Service;

namespace NUnitTesting
{
    [TestFixture]
    public class MathOperationTest
    {
        [Test, TestCase(1, 2, 3)]
        public void TestMethodAdd(int i, int j, int result)
        {
            var testOpertaion = new Operation();
            var actual = testOpertaion.Add(1, 2);
            Assert.AreEqual(result, actual);
        }

        [Test, TestCase(5, 3, 2)]
        public void TestMethodSubtract(int i, int j, int result)
        {
            var testOpertaion = new Operation();
            var actual = testOpertaion.Sub(5, 3);
            Assert.AreEqual(result, actual);
        }
    }
}
