﻿using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnittestFizzBuzzIter2
{
    [TestMethod]
    public void TestMethodIter2Donne7RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter2(7);
        Assert.AreEqual(result, "Fizz");

    }


    [TestMethod]
    public void TestMethodIter2Donne14RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter2(14);
        Assert.AreEqual(result, "Fizz");

    }


    [TestMethod]
    public void TestMethodIter2Donne11RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter2(11);
        Assert.AreEqual(result, "Buzz");

    }

    [TestMethod]
    public void TestMethodIter2Donne22RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter2(22);
        Assert.AreEqual(result, "Buzz");

    }


    [TestMethod]
    public void TestMethodIter2Donne77RenvoieFizzBuzz()
    {
        string result = FizzBuzzIterations.Iter2(77);
        Assert.AreEqual(result, "FizzBuzz");

    }

    [TestMethod]
    public void TestMethodIter2Donne1Renvoie1()
    {
        string result = FizzBuzzIterations.Iter2(1);
        Assert.AreEqual(result, "1");

    }

    [TestMethod]
    public void TestMethodIter2Donne3Renvoie3()
    {
        string result = FizzBuzzIterations.Iter2(3);
        Assert.AreEqual(result, "3");

    }

}

