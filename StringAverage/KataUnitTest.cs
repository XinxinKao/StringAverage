using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace StringAverage
{
    [TestFixture]
    public class KataUnitTest
    {
        [TestCase("four", "zero nine five two")]
        [TestCase("three", "four six two three")]
        [TestCase("three", "one two three four five")]
        [TestCase("four", "five four")]
        [TestCase("zero", "zero zero zero zero zero")]
        [TestCase("two", "one one eight one")]
        [TestCase("n/a", "")]
        public void StringNumberAverageTest(string expected, string inputString)
        {
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

    }
}
