using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace StringAverage
{
    [TestClass()]
    public class ValuesControllerTests
    {
        [TestMethod()]
        public void StringNumberAverageTest_1()
        {
            var inputString = "zero nine five two";
            var expected = "four";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_2()
        {
            var inputString = "four six two three";
            var expected = "three";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_3()
        {
            var inputString = "one two three four five";
            var expected = "three";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_4()
        {
            var inputString = "five four";
            var expected = "four";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_5()
        {
            var inputString = "zero zero zero zero zero";
            var expected = "zero";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_6()
        {
            var inputString = "one one eight one";
            var expected = "two";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StringNumberAverageTest_7()
        {
            var inputString = "";
            var expected = "n/a";
            var kata = new Kata();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
    //[TestFixture]
    //public class KataUnitTest
    //{
    //    [TestCase("four", "zero nine five two")]
    //    [TestCase("three", "four six two three")]
    //    [TestCase("three", "one two three four five")]
    //    [TestCase("four", "five four")]
    //    [TestCase("zero", "zero zero zero zero zero")]
    //    [TestCase("two", "one one eight one")]
    //    [TestCase("n/a", "")]
    //    public void StringNumberAverageTest(string expected, string inputString)
    //    {
    //        var kata = new Kata();
    //        var actual = kata.AverageString(inputString);
    //        Assert.AreEqual(expected, actual);
    //    }

    //}
}
