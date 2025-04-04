namespace UdemyTest;

using CodeWars5kyu;

public class DomainNameValidator
{
    [Test]
    public void DomainTests()
    {
        Assert.That(DomainNameValidatorTask.Validate("codewars"), Is.False);
        Assert.That(DomainNameValidatorTask.Validate("g.co"), Is.True);
        Assert.That(DomainNameValidatorTask.Validate("codewars.com"), Is.True);
        Assert.That(DomainNameValidatorTask.Validate("CODEWARS.COM"), Is.True);
        Assert.That(DomainNameValidatorTask.Validate("sub.codewars.com"), Is.True);
        Assert.That(DomainNameValidatorTask.Validate("codewars.com-"), Is.False);
        Assert.That(DomainNameValidatorTask.Validate(".codewars.com"), Is.False);
        Assert.That(DomainNameValidatorTask.Validate("example@codewars.com"), Is.False);
        Assert.That(DomainNameValidatorTask.Validate("127.0.0.1"), Is.False);
    }
}