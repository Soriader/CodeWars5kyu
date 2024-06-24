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
                public static void FactorialDecompositionTest()
                {
                    Assert.AreEqual("2^15 * 3^6 * 5^3 * 7^2 * 11 * 13 * 17", FactorialDecompositionTask.Decomp(17));
                    Assert.AreEqual("2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19", FactorialDecompositionTask.Decomp(22));
                    Assert.AreEqual("2^11 * 3^5 * 5^2 * 7^2 * 11 * 13", FactorialDecompositionTask.Decomp(14));

                }

                [Test]
                public void IntegersRecreationOneTest()
                {
                    Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", IntegersRecreationOneTask.ListSquared(1, 250));
                    Assert.AreEqual("[[287, 84100]]", IntegersRecreationOneTask.ListSquared(250, 500));
                    Assert.AreEqual("[[42, 2500], [246, 84100]]", IntegersRecreationOneTask.ListSquared(42, 250));


                }

                [Test]
                public void MaximumSubarraySumTest()
                {
                    Assert.AreEqual(0, MaximumSubarraySumTask.MaxSequence(new int[0]));
                    Assert.AreEqual(6, MaximumSubarraySumTask.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

                }

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