using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using Calculator;


namespace CalculatorTest
{
    [TestFixture]
    class MyCalculatorTest
    {
        MyCalculator c1;
        static void Main(string[] args)
        {
        }
        [SetUp]

        public void Init()
        {
            c1 = new MyCalculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(c1.add(5, 6), Is.EqualTo(11));
        }
    }
}
