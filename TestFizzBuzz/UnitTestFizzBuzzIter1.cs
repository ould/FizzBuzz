using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnitTestFizzBuzzIter1
{
    [TestMethod]
    public void TestMethodIter1Donne3RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter1(3);
        Assert.AreEqual("Fizz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne6RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter1(6);
        Assert.AreEqual("Fizz", result);

    }


    [TestMethod]
    public void TestMethodIter1Donne5RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter1(5);
        Assert.AreEqual("Buzz", result);

    }


    [TestMethod]
    public void TestMethodIter1Donne10RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter1(10);
        Assert.AreEqual("Buzz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne15RenvoieFizzBuzz()
    {
        string result = FizzBuzzIterations.Iter1(15);
        Assert.AreEqual("FizzBuzz", result);

    }

    [TestMethod]
    public void TestMethodIter1Donne1Renvoie1()
    {
        string result = FizzBuzzIterations.Iter1(1);
        Assert.AreEqual("1", result);

    }
}
