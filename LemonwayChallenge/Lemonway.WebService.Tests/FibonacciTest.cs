using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lemonway.WebService.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        [FibonacciAttribute]
        public void FibonacciTestMethod(int n, int expected)
        {
            FibonacciWebService ws = new FibonacciWebService();
            int actual = ws.Fibonacci(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
