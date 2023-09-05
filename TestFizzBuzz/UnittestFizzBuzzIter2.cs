using FizzBuzz;
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
}


