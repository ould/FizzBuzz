using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnitTestFizzBuzz
{
    private FizzBuzzIterations _fizzBuzzObject;

    public UnitTestFizzBuzz()
    {
        _fizzBuzzObject = new FizzBuzzIterations();
    }

    [TestMethod]
    public void TestMethodIter1Donne3RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter1(3);
        Assert.AreEqual(result, "Fizz");

    }

    [TestMethod]
    public void TestMethodIter1Donne6RenvoieFizz()
    {
        string result = _fizzBuzzObject.Iter1(6);
        Assert.AreEqual(result, "Fizz");

    }


    [TestMethod]
    public void TestMethodIter1Donne5RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter1(5);
        Assert.AreEqual(result, "Buzz");

    }


    [TestMethod]
    public void TestMethodIter1Donne10RenvoieBuzz()
    {
        string result = _fizzBuzzObject.Iter1(10);
        Assert.AreEqual(result, "Buzz");

    }
}
