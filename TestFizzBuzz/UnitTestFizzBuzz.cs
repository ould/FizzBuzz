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
}
