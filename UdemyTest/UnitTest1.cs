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
				public void SimpleFractionToMixedNumberConverterTest()
				{
					Assert.AreEqual("4 2/3", SimpleFractionToMixedNumberConverterTask.MixedFraction("42/9"));
					Assert.AreEqual("2", SimpleFractionToMixedNumberConverterTask.MixedFraction("6/3"));
					Assert.AreEqual("1", SimpleFractionToMixedNumberConverterTask.MixedFraction("1/1"));
					Assert.AreEqual("1", SimpleFractionToMixedNumberConverterTask.MixedFraction("11/11"));
					Assert.AreEqual("2/3", SimpleFractionToMixedNumberConverterTask.MixedFraction("4/6"));
					Assert.AreEqual("0", SimpleFractionToMixedNumberConverterTask.MixedFraction("0/18891"));
					Assert.AreEqual("-1 3/7", SimpleFractionToMixedNumberConverterTask.MixedFraction("-10/7"));
					Assert.AreEqual("3 1/7", SimpleFractionToMixedNumberConverterTask.MixedFraction("-22/-7"));
					Assert.AreEqual("-195595/564071", SimpleFractionToMixedNumberConverterTask.MixedFraction("-195595/564071"));

					Assert.Throws(typeof(DivideByZeroException), delegate { SimpleFractionToMixedNumberConverterTask.MixedFraction("0/0"); });
					Assert.Throws(typeof(DivideByZeroException), delegate { SimpleFractionToMixedNumberConverterTask.MixedFraction("3/0"); });
				}

				[Test]
				public void TheHungerGamesZooDisasterTest()
				{
					string input = "fox,bug,chicken,grass,sheep";
					string[] expected = {
		  "fox,bug,chicken,grass,sheep",
		  "chicken eats bug",
		  "fox eats chicken",
		  "sheep eats grass",
		  "fox eats sheep",
		  "fox"
		};

					Assert.AreEqual(expected, TheHungerGamesZooDisasterTask.WhoEatsWho(input));
				}

				[Test]
				public void WriteOutNumbersTest()
				{

					Assert.AreEqual("zero", WriteOutNumbersTask.Number2Words(0));
					Assert.AreEqual("one", WriteOutNumbersTask.Number2Words(1));
					Assert.AreEqual("three", WriteOutNumbersTask.Number2Words(3));
					Assert.AreEqual("five", WriteOutNumbersTask.Number2Words(5));
					Assert.AreEqual("eight", WriteOutNumbersTask.Number2Words(8));
					Assert.AreEqual("three hundred one", WriteOutNumbersTask.Number2Words(301));
					Assert.AreEqual("seven hundred ninety-three", WriteOutNumbersTask.Number2Words(793));
					Assert.AreEqual("eight hundred", WriteOutNumbersTask.Number2Words(800));
					Assert.AreEqual("six hundred fifty", WriteOutNumbersTask.Number2Words(650));
					Assert.AreEqual("one thousand", WriteOutNumbersTask.Number2Words(1000));
					Assert.AreEqual("one thousand three", WriteOutNumbersTask.Number2Words(1003));
				}

				[Test]
				public static void GapInPrimesTest()
				{
					Assert.AreEqual(new long[] { 101, 103 }, GapInPrimesTask.Gap(2, 100, 110));
					Assert.AreEqual(new long[] { 103, 107 }, GapInPrimesTask.Gap(4, 100, 110));
					Assert.AreEqual(new long[] { 101, 103 }, GapInPrimesTask.Gap(2, 100, 103));
					Assert.AreEqual(null, GapInPrimesTask.Gap(6, 100, 110));
					Assert.AreEqual(new long[] { 359, 367 }, GapInPrimesTask.Gap(8, 300, 400));
					Assert.AreEqual(new long[] { 337, 347 }, GapInPrimesTask.Gap(10, 300, 400));
				}

				[Test]
				public void LandPerimeterTest()
				{
					Assert.AreEqual("Total land perimeter: 0", LandPerimeterTask.Calculate("".Split(' ')), "Sample test 1");
					Assert.AreEqual("Total land perimeter: 0", LandPerimeterTask.Calculate("O".Split(' ')), "Sample test 2");
					Assert.AreEqual("Total land perimeter: 4", LandPerimeterTask.Calculate("X".Split(' ')), "Sample test 3");
					Assert.AreEqual("Total land perimeter: 60", LandPerimeterTask.Calculate("OXOOOX OXOXOO XXOOOX OXXXOO OOXOOX OXOOOO OOXOOX OOXOOO OXOOOO OXOOXX".Split(' ')), "Sample test 4");
					Assert.AreEqual("Total land perimeter: 52", LandPerimeterTask.Calculate("OXOOO OOXXX OXXOO XOOOO XOOOO XXXOO XOXOO OOOXO OXOOX XOOOO OOOXO".Split(' ')), "Sample test 5");
					Assert.AreEqual("Total land perimeter: 40", LandPerimeterTask.Calculate("XXXXXOOO OOXOOOOO OOOOOOXO XXXOOOXO OXOXXOOX".Split(' ')), "Sample test 6");
					Assert.AreEqual("Total land perimeter: 54", LandPerimeterTask.Calculate("XOOOXOO OXOOOOO XOXOXOO OXOXXOO OOOOOXX OOOXOXX XXXXOXO".Split(' ')), "Sample test 7");
					Assert.AreEqual("Total land perimeter: 40", LandPerimeterTask.Calculate("OOOOXO XOXOOX XXOXOX XOXOOO OOOOOO OOOXOO OOXXOO".Split(' ')), "Sample test 8");

				}
				[Test]
				public static void PhoneDirectoryTest()
				{
					string dr = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010\n"
   + "+1-541-984-3012 <P Reed> /PO Box 530; Pollocksville, NC-28573\n :+1-321-512-2222 <Paul Dive> Sequoia Alley PQ-67209\n"
   + "+1-741-984-3090 <Peter Reedgrave> _Chicago\n :+1-921-333-2222 <Anna Stevens> Haramburu_Street AA-67209\n"
   + "+1-111-544-8973 <Peter Pan> LA\n +1-921-512-2222 <Wilfrid Stevens> Wild Street AA-67209\n"
   + "<Peter Gone> LA ?+1-121-544-8974 \n <R Steell> Quora Street AB-47209 +1-481-512-2222\n"
   + "<Arthur Clarke> San Antonio $+1-121-504-8974 TT-45120\n <Ray Chandler> Teliman Pk. !+1-681-512-2222! AB-47209,\n"
   + "<Sophia Loren> +1-421-674-8974 Bern TP-46017\n <Peter O'Brien> High Street +1-908-512-2222; CC-47209\n"
   + "<Anastasia> +48-421-674-8974 Via Quirinal Roma\n <P Salinger> Main Street, +1-098-512-2222, Denver\n"
   + "<C Powel> *+19-421-674-8974 Chateau des Fosses Strasbourg F-68000\n <Bernard Deltheil> +1-498-512-2222; Mount Av.  Eldorado\n"
   + "+1-099-500-8000 <Peter Crush> Labrador Bd.\n +1-931-512-4855 <William Saurin> Bison Street CQ-23071\n"
   + "<P Salinge> Main Street, +1-098-512-2222, Denve\n" + "<P Salinge> Main Street, +1-098-512-2222, Denve\n";

					static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}


					Console.WriteLine("Phone");
					testing(PhoneDirectoryTask.Phone(dr, "48-421-674-8974"), "Phone => 48-421-674-8974, Name => Anastasia, Address => Via Quirinal Roma");
					testing(PhoneDirectoryTask.Phone(dr, "1-921-512-2222"), "Phone => 1-921-512-2222, Name => Wilfrid Stevens, Address => Wild Street AA-67209");
					testing(PhoneDirectoryTask.Phone(dr, "1-908-512-2222"), "Phone => 1-908-512-2222, Name => Peter O'Brien, Address => High Street CC-47209");
					testing(PhoneDirectoryTask.Phone(dr, "1-541-754-3010"), "Phone => 1-541-754-3010, Name => J Steeve, Address => 156 Alphand St.");
					testing(PhoneDirectoryTask.Phone(dr, "1-121-504-8974"), "Phone => 1-121-504-8974, Name => Arthur Clarke, Address => San Antonio TT-45120");
					testing(PhoneDirectoryTask.Phone(dr, "1-498-512-2222"), "Phone => 1-498-512-2222, Name => Bernard Deltheil, Address => Mount Av. Eldorado");
					testing(PhoneDirectoryTask.Phone(dr, "1-098-512-2222"), "Error => Too many people: 1-098-512-2222");
					testing(PhoneDirectoryTask.Phone(dr, "5-555-555-5555"), "Error => Not found: 5-555-555-5555");

				}

				[Test]
				public static void FindTheSmallestTest()
				{
					testing(261235, "[126235, 2, 0]");
					testing(209917, "[29917, 0, 1]");
					testing(285365, "[238565, 3, 1]");
					testing(269045, "[26945, 3, 0]");
					testing(296837, "[239687, 4, 1]");

					static void testing(long n, string res)
					{
						Assert.AreEqual(res, Array2String(FindTheSmallestTask.Smallest(n)));
					}
					static string Array2String(long[] list)
					{
						return "[" + string.Join(", ", list) + "]";
					}
				}

				[Test]
				public void WhatIsAPerfectPowerAnywayTest()
				{
					Assert.IsNull(WhatIsAPerfectPowerAnywayTask.IsPerfectPower(5), "5 is not a perfect power");
					Assert.IsNull(WhatIsAPerfectPowerAnywayTask.IsPerfectPower(0), "0 is not a perfect number");
					Assert.IsNull(WhatIsAPerfectPowerAnywayTask.IsPerfectPower(1), "1 is not a perfect number");
					Assert.AreEqual((2, 2), WhatIsAPerfectPowerAnywayTask.IsPerfectPower(4), "4 = 2^2");
					Assert.AreEqual((2, 3), WhatIsAPerfectPowerAnywayTask.IsPerfectPower(8), "8 = 2^3");
					Assert.AreEqual((3, 2), WhatIsAPerfectPowerAnywayTask.IsPerfectPower(9), "9 = 3^2");

				}

				[Test]
                public void CommonDenominatorsTest()
                {

                    long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
                    Assert.AreEqual("(6,12)(4,12)(3,12)", CommonDenominatorsTask.ConvertFrac(lst));

                }

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