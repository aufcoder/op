using NUnit.Framework;
using Main;
[TestFixture]
public class MyTestClass
{
    [Test]
    public void MyTestMethod()
    {
        Assert.IsTrue(Main.bar.Palindrome("racecar"));
        Assert.IsFalse(Main.bar.Palindrome("Hello"));
    }
}
