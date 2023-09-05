using System;
using FizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzzIter3
    {
        [TestMethod]
        public void TestMethodIter3Donne13RenvoieFizz()
        {
            string result = FizzBuzzIterations.Iter3(13);
            Assert.AreEqual("Fizz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne17RenvoieBuzz()
        {
            string result = FizzBuzzIterations.Iter3(17);
            Assert.AreEqual("Buzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne19RenvoieFuzz()
        {
            string result = FizzBuzzIterations.Iter3(19);
            Assert.AreEqual("Fuzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne23RenvoieBizz()
        {
            string result = FizzBuzzIterations.Iter3(23);
            Assert.AreEqual("Bizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne221RenvoieFizzBuzz()
        {
            // 17*13 = 221
            string result = FizzBuzzIterations.Iter3(221);
            Assert.AreEqual("FizzBuzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne247RenvoieFizzFuzz()
        {
            // 13*19 = 247
            string result = FizzBuzzIterations.Iter3(247);
            Assert.AreEqual("FizzFuzz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne391RenvoieBuzzBizz()
        {
            // 17*23 = 391
            string result = FizzBuzzIterations.Iter3(391);
            Assert.AreEqual("BuzzBizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne437RenvoieFuzzBizz()
        {
            // 19*23 = 437
            string result = FizzBuzzIterations.Iter3(437);
            Assert.AreEqual("FuzzBizz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne5681RenvoieFizzFuzzBizz()
        {
            // 13*19*23 = 5681
            string result = FizzBuzzIterations.Iter3(5681);
            Assert.AreEqual("FizzFuzzBizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne1Renvoie1()
        {
            string result = FizzBuzzIterations.Iter3(1);
            Assert.AreEqual("1", result);

        }





    }
}

