using CodeWars5kyu;

namespace UdemyTest;

public class SunkDamagedOrNotTouched
{
    [TestCase]
    public void BasicTest1()
    {
        var kata = new SunkDamagedOrNotTouchedTask();
        int[,] board = { { 0, 0, 1, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 1, 0 } };
        int[,] attacks = { { 3, 1 }, { 3, 2 }, { 3, 3 } };
        var result = SunkDamagedOrNotTouchedTask.DamagedOrSunk(board, attacks);
        Console.WriteLine("Test 1 - sunk = 1, damaged = 0, notTouched = 0, points = 1");
        Assert.That(result["sunk"], Is.EqualTo(1));
        Assert.That(result["damaged"], Is.EqualTo(0));
        Assert.That(result["notTouched"], Is.EqualTo(0));
        Assert.That(result["points"], Is.EqualTo(1));
    }

    [TestCase]
    public void BasicTest2()
    {
        var kata = new SunkDamagedOrNotTouchedTask();
        int[,] board = { { 3, 0, 1 },
            { 3, 0, 1 },
            { 0, 2, 1 },
            { 0, 2, 0 } };
        int[,] attacks = { { 2, 1 }, { 2, 2 }, { 3, 2 }, { 3, 3 } };
        var result = SunkDamagedOrNotTouchedTask.DamagedOrSunk(board, attacks);
        Console.WriteLine("Test 2 - sunk = 1, damaged = 1, notTouched = 1, points = 0.5");
        Assert.That(result["sunk"], Is.EqualTo(1));
        Assert.That(result["damaged"], Is.EqualTo(1));
        Assert.That(result["notTouched"], Is.EqualTo(1));
        Assert.That(result["points"], Is.EqualTo(0.5));
    }
}
