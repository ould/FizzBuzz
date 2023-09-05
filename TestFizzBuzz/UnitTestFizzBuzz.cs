using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnitTestFizzBuzz
{
    [TestMethod]
    public void TestMethodIter1Donne3RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter1(3);
        Assert.AreEqual(result, "Fizz");

    }

    [TestMethod]
    public void TestMethodIter1Donne6RenvoieFizz()
    {
        string result = FizzBuzzIterations.Iter1(6);
        Assert.AreEqual(result, "Fizz");

    }


    [TestMethod]
    public void TestMethodIter1Donne5RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter1(5);
        Assert.AreEqual(result, "Buzz");

    }


    [TestMethod]
    public void TestMethodIter1Donne10RenvoieBuzz()
    {
        string result = FizzBuzzIterations.Iter1(10);
        Assert.AreEqual(result, "Buzz");

    }

    [TestMethod]
    public void TestMethodIter1Donne15RenvoieFizzBuzz()
    {
        string result = FizzBuzzIterations.Iter1(15);
        Assert.AreEqual(result, "FizzBuzz");

    }
}
