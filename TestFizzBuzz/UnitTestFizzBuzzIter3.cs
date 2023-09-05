using System;
using FizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzzIter3
    {
        private FizzBuzzIterations _fizzBuzzObject;

        public UnitTestFizzBuzzIter3()
        {
            _fizzBuzzObject = new FizzBuzzIterations();
        }


        [TestMethod]
        public void TestMethodIter3Donne13RenvoieFizz()
        {
            string result = _fizzBuzzObject.Iter3(13);
            Assert.AreEqual("Fizz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne17RenvoieBuzz()
        {
            string result = _fizzBuzzObject.Iter3(17);
            Assert.AreEqual("Buzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne19RenvoieFuzz()
        {
            string result = _fizzBuzzObject.Iter3(19);
            Assert.AreEqual("Fuzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne23RenvoieBizz()
        {
            string result = _fizzBuzzObject.Iter3(23);
            Assert.AreEqual("Bizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne221RenvoieFizzBuzz()
        {
            // 17*13 = 221
            string result = _fizzBuzzObject.Iter3(221);
            Assert.AreEqual("FizzBuzz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne247RenvoieFizzFuzz()
        {
            // 13*19 = 247
            string result = _fizzBuzzObject.Iter3(247);
            Assert.AreEqual("FizzFuzz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne391RenvoieBuzzBizz()
        {
            // 17*23 = 391
            string result = _fizzBuzzObject.Iter3(391);
            Assert.AreEqual("BuzzBizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne437RenvoieFuzzBizz()
        {
            // 19*23 = 437
            string result = _fizzBuzzObject.Iter3(437);
            Assert.AreEqual("FuzzBizz", result);

        }

        [TestMethod]
        public void TestMethodIter3Donne5681RenvoieFizzFuzzBizz()
        {
            // 13*19*23 = 5681
            string result = _fizzBuzzObject.Iter3(5681);
            Assert.AreEqual("FizzFuzzBizz", result);

        }


        [TestMethod]
        public void TestMethodIter3Donne1Renvoie1()
        {
            string result = _fizzBuzzObject.Iter3(1);
            Assert.AreEqual("1", result);

        }





    }
}

