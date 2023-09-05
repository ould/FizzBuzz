using FizzBuzz;
namespace TestFizzBuzz;

[TestClass]
public class UnitTestFizzBuzz
{
    [TestMethod]
    public void TestMethodIter1Donne3RenvoieFizz()
    {
        var FizzBuzzObject = new FizzBuzzIterations();
        string result = FizzBuzzObject.Iter1(3);
        Assert.AreEqual(result, "Fizz");

    }
}
