using System.Diagnostics.CodeAnalysis;

namespace email_validator_tests;

[TestFixture]
[SuppressMessage("Performance", "CA1847:Use char literal for a single character lookup")]
public class EmailValidatorTest
{
    [Test]
    public void IsValidEmailTest()
    {
        const string email = "example@example.com";
        var isValid = email.Contains("@") && email.EndsWith(".com");
        Assert.That(isValid, Is.True);
    }
}