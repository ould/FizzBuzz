using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnittestFizzBuzzIter2
{
    private FizzBuzzIterations _fizzBuzzObject;

    public UnittestFizzBuzzIter2()
    {
        _fizzBuzzObject = new FizzBuzzIterations();
    }


    [TestMethod]
    public void TestMethodIter2Donne7RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter2(7);
        Assert.AreEqual("Fizz", result);

    }


    [TestMethod]
    public void TestMethodIter2Donne14RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter2(14);
        Assert.AreEqual( "Fizz", result);

    }


    [TestMethod]
    public void TestMethodIter2Donne11RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter2(11);
        Assert.AreEqual( "Buzz", result);

    }

    [TestMethod]
    public void TestMethodIter2Donne22RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter2(22);
        Assert.AreEqual( "Buzz", result);

    }


    [TestMethod]
    public void TestMethodIter2Donne77RenvoieFizzBuzz()
    {
        string result = _fizzBuzzObject.Iter2(77);
        Assert.AreEqual( "FizzBuzz", result);

    }

    [TestMethod]
    public void TestMethodIter2Donne1Renvoie1()
    {
        string result = _fizzBuzzObject.Iter2(1);
        Assert.AreEqual( "1", result);

    }

    [TestMethod]
    public void TestMethodIter2Donne3Renvoie3()
    {
        string result = _fizzBuzzObject.Iter2(3);
        Assert.AreEqual( "3", result);

    }

}


