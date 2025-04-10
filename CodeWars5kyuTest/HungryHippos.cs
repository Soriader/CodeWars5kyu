namespace CodeWars5kyuTest;

using CodeWars5kyu;

public class HungryHippos
{
    [TestCase, Order(1)]
    public void BasicTest1()
    {
        int[,] board = { { 1, 1, 0, 0, 0 },
            { 1, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1 },
            { 0, 0, 0, 1, 1 } };
        HungryHipposTask game = new HungryHipposTask(board);
        Assert.That(game.Play(), Is.EqualTo(2), "Should return '2'");
    }

    [TestCase, Order(2)]
    public void BasicTest2()
    {
        int[,] board = { { 1, 0, 1, 0, 1 },
            { 1, 0, 1, 0, 1 },
            { 1, 1, 1, 0, 0 },
            { 0, 0, 0, 1, 1 },
            { 0, 0, 0, 1, 1 } };
        HungryHipposTask game = new HungryHipposTask(board);
        Assert.That(game.Play(), Is.EqualTo(3), "Should return '3'");
    }

    [TestCase, Order(3)]
    public void BasicTest3()
    {
        int[,] board = { { 1, 0, 1, 0, 1 },
            { 0, 1, 0, 1, 0 },
            { 1, 0, 1, 0, 1 },
            { 0, 1, 0, 1, 0 },
            { 1, 0, 1, 0, 1 } };
        HungryHipposTask game = new HungryHipposTask(board);
        Assert.That(game.Play(), Is.EqualTo(13), "Should return '13'");
    }

    [TestCase, Order(4)]
    public void BasicTest4()
    {
        int[,] board = { { 1, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0 },
            { 1, 0, 1, 0, 1 },
            { 1, 1, 1, 1, 0 },
            { 1, 1, 1, 0, 1 } };
        HungryHipposTask game = new HungryHipposTask(board);
        Assert.That(game.Play(), Is.EqualTo(4), "Should return '4'");
    }
}