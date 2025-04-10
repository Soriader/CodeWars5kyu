namespace CodeWars5kyuTest;

using CodeWars5kyu;

public class HamsterMe
{
    [Test]
    public void HamsterMeTest()
    {
        Assert.That(HamsterMeTask.HamsterMe("hamster", "hamster"), Is.EqualTo("h1a1m1s1t1e1r1"));
        Assert.That(HamsterMeTask.HamsterMe("hamster", "helpme"), Is.EqualTo("h1e1h5m4m1e1"));
        Assert.That(HamsterMeTask.HamsterMe("hmster", "hamster"), Is.EqualTo("h1t8m1s1t1e1r1"));   
        Assert.That(HamsterMeTask.HamsterMe("hhhhammmstteree", "hamster"), Is.EqualTo("h1a1m1s1t1e1r1"));  
        Assert.That(HamsterMeTask.HamsterMe("hamster", "abcdefghijklmnopqrstuvwxyz"), Is.EqualTo("a1a2a3a4e1e2e3h1h2h3h4h5m1m2m3m4m5r1s1t1t2t3t4t5t6t7"));  
        Assert.That(HamsterMeTask.HamsterMe("f", "abcdefghijklmnopqrstuvwxyz"), Is.EqualTo("f22f23f24f25f26f1f2f3f4f5f6f7f8f9f10f11f12f13f14f15f16f17f18f19f20f21"));        
    }
}

