using CodeWars5kyu;

namespace UdemyTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
            class Test
            {
                [Test]
                public void PrimesInNumbersTest()
                {
                    Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", PrimesInNumbersTask.Factors(7775460));
                }

                [Test]
                public void TakeTheDerivativeTest()
                {
                    Assert.AreEqual("grfg", Rot13Task.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Rot13Task.Rot13("test")));
                    Assert.AreEqual("Grfg", Rot13Task.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13Task.Rot13("Test")));


                }
            }
        }
    }
}