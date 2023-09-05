using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnitTestFizzBuzzIter1
{
    private FizzBuzzIterations _fizzBuzzObject;

    public UnitTestFizzBuzzIter1()
    {
        _fizzBuzzObject = new FizzBuzzIterations();
    }

    [TestMethod]
    public void TestMethodIter1Donne3RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter1(3);
        Assert.AreEqual("Fizz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne6RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter1(6);
        Assert.AreEqual("Fizz", result);

    }


    [TestMethod]
    public void TestMethodIter1Donne5RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter1(5);
        Assert.AreEqual("Buzz", result);

    }


    [TestMethod]
    public void TestMethodIter1Donne10RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter1(10);
        Assert.AreEqual("Buzz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne15RenvoieFizzBuzz()
    {
        string result = _fizzBuzzObject.Iter1(15);
        Assert.AreEqual("FizzBuzz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne1Renvoie1()
    {
        string result = _fizzBuzzObject.Iter1(1);
        Assert.AreEqual("1", result);

    }
}
