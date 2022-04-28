using NUnit.Framework;
using HelloWorld;

namespace HelloWorld.Tests;

public class Tests
{
    [Test]
    public void TestHelloWorld()
    {
        string greeting = Greeter.Greet("World");
        Assert.AreEqual(greeting, "Hello, World!");
    }
}