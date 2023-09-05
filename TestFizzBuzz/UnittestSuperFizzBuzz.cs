using System;
using FizzBuzz;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnittestSuperFizzBuzz
	{
        private FizzBuzzIterations _fizzBuzzObject;

        public UnittestSuperFizzBuzz()
        {
            _fizzBuzzObject = new FizzBuzzIterations();
        }


        [TestMethod]
        public void TestMethodSuperDonne2RenvoieFizz()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(2);
            Assert.AreEqual("Fizz", result);

        }

        [TestMethod]
        public void TestMethodSuperDonne6Renvoie6()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(6);
            Assert.AreEqual("6", result);

        }

        [TestMethod]
        public void TestMethodSuperDonne3RenvoieBuzz()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(3);
            Assert.AreEqual("Buzz", result);

        }

        [TestMethod]
        public void TestMethodSuperDonne4RenvoieFizzFuzz()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(4);
            Assert.AreEqual("FizzFuzz", result);

        }

        [TestMethod]
        public void TestMethodSuperDonne9RenvoieBuzzFuzz()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(9);
            Assert.AreEqual("BuzzFuzz", result);

        }

        [TestMethod]
        public void TestMethodSuperDonne900RenvoieFuzz()
        {
            string result = _fizzBuzzObject.SuperFizzBuzz(900);
            Assert.AreEqual("Fuzz", result);

        }
    }
}

