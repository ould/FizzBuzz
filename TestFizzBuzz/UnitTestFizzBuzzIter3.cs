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
            Assert.AreEqual(result, "Fizz");

        }

        [TestMethod]
        public void TestMethodIter3Donne17RenvoieBuzz()
        {
            string result = FizzBuzzIterations.Iter3(17);
            Assert.AreEqual(result, "Buzz");

        }

        [TestMethod]
        public void TestMethodIter3Donne19RenvoieFuzz()
        {
            string result = FizzBuzzIterations.Iter3(19);
            Assert.AreEqual(result, "Fuzz");

        }

        [TestMethod]
        public void TestMethodIter3Donne23RenvoieBizz()
        {
            string result = FizzBuzzIterations.Iter3(23);
            Assert.AreEqual(result, "Bizz");

        }


        [TestMethod]
        public void TestMethodIter3Donne221RenvoieFizzBuzz()
        {
            // 17*13 = 221
            string result = FizzBuzzIterations.Iter3(221);
            Assert.AreEqual(result, "FizzBuzz");

        }

        [TestMethod]
        public void TestMethodIter3Donne247RenvoieFizzFuzz()
        {
            // 13*19 = 247
            string result = FizzBuzzIterations.Iter3(247);
            Assert.AreEqual(result, "FizzFuzz");

        }


        [TestMethod]
        public void TestMethodIter3Donne391RenvoieBuzzBizz()
        {
            // 17*23 = 391
            string result = FizzBuzzIterations.Iter3(391);
            Assert.AreEqual(result, "BuzzBizz");

        }


        [TestMethod]
        public void TestMethodIter3Donne437RenvoieFuzzBizz()
        {
            // 19*23 = 437
            string result = FizzBuzzIterations.Iter3(437);
            Assert.AreEqual(result, "FuzzBizz");

        }




    }
}

