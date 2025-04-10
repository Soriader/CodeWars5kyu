using CodeWars5kyu;

namespace CodeWars5kyuTest;

public class SortOneThreeTwo
{
    [Test]
    public void SortOneThreeTwoTest()
    {
        Assert.That(SortOneThreeTwoTask.Sort(new [] { 8, 8, 9, 9, 10, 10 }), Is.EqualTo(new [] { 8, 8, 9, 9, 10, 10 }));
        Assert.That(SortOneThreeTwoTask.Sort(new [] { 1, 2, 3, 4 }), Is.EqualTo(new [] { 4, 1, 3, 2 }));
        Assert.That(SortOneThreeTwoTask.Sort(new [] { 9, 99, 999 }), Is.EqualTo(new [] { 9, 999, 99 }));
    }
}