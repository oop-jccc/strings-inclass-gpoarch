using System.Text;

namespace greeting_builder_tests;

internal record Person
{
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
}

public class GreetingTests
{
    private const string ExpectedGreeting = "Hello, John Wayne";

    private readonly Person _person = new()
    {
        FirstName = "John",
        LastName = "Wayne"
    };

    [Test]
    public void PlusOverloadOperatorTest()
    {
        var actualGreeting = "Hello, " + _person.FirstName + " " + _person.LastName;
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void ConcatTest()
    {
        var actualGreeting = string.Concat("Hello, ", _person.FirstName, " ", _person.LastName);
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void FormatTest()
    {
        var actualGreeting = string.Format("Hello, {0} {1}", _person.FirstName, _person.LastName);
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void StringBuilderTest()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("Hello, ");
        stringBuilder.Append(_person.FirstName);
        stringBuilder.Append(" ");
        stringBuilder.Append(_person.LastName);
        var actualGreeting = stringBuilder.ToString();
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }

    [Test]
    public void InterpolationTest()
    {
        var actualGreeting = $"Hello, {_person.FirstName} {_person.LastName}";
        Assert.That(actualGreeting, Is.EqualTo(ExpectedGreeting));
    }
}