using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MyUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Maths
    {
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }
    }

    [TestFixture]
    public class TestLogging
    {
        [Test]
        public void Add()
        {
            Maths add = new Maths();
            int expectedResult = add.Add(1, 2);
            NUnit.Framework.Assert.That(expectedResult, Is.EqualTo(5));
        }
    }

}
