using CodeWars5kyu;
using NUnit.Framework.Internal;
using System.Text;

namespace CodeWars5kyuTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
            class Test
            {
                [Test]
                public void BasicNicoVariationTest()
                {
                    Assert.That(BasicNicoVariationTask.Nico("crazy", "secretinformation"), Is.EqualTo("cseerntiofarmit on  "));
                    Assert.That(BasicNicoVariationTask.Nico("abc", "abcd"), Is.EqualTo("abcd  "));
                    Assert.That(BasicNicoVariationTask.Nico("ba", "1234567890"), Is.EqualTo("2143658709"));
                    Assert.That(BasicNicoVariationTask.Nico("a", "message"), Is.EqualTo("message"));
                    Assert.That(BasicNicoVariationTask.Nico("key", "key"), Is.EqualTo("eky"));
                }

                [Test]
                public void BestMatchEgyptTeamTest()
                {
                    var kata = new BestMatchEgyptTeamTask();

                    //Assert.AreEqual(1, kata.BestMatch(new int[] { 6, 4 }, new int[] { 1, 2 }));

                    Assert.AreEqual(0, kata.BestMatch(new int[] { 1 }, new int[] { 0 }));

                    Assert.AreEqual(4, kata.BestMatch(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4 }));

                    Assert.AreEqual(2, kata.BestMatch(new int[] { 3, 4, 3 }, new int[] { 1, 1, 2 }));

                    Assert.AreEqual(1, kata.BestMatch(new int[] { 4, 3, 4 }, new int[] { 1, 1, 1 }));

                }

                [Test]
				public void PokerCardsTest()
				{
					Assert.AreEqual(new[] { 7, 22, 51 }, PokerCardsTask.Encode(new[] { "Td", "8c", "Ks" }));
					Assert.AreEqual(new[] { 13, 30, 37 }, PokerCardsTask.Encode(new[] { "Qh", "5h", "Ad" }));
					Assert.AreEqual(new[] { 7, 22, 51 }, PokerCardsTask.Encode(new[] { "8c", "Ks", "Td" }));
					Assert.AreEqual(new[] { 13, 30, 37 }, PokerCardsTask.Encode(new[] { "Qh", "Ad", "5h" }));
					Assert.AreEqual(new[] { "8c", "Td", "Ks" }, PokerCardsTask.Decode(new[] { 7, 22, 51 }));
					Assert.AreEqual(new[] { "Ad", "5h", "Qh" }, PokerCardsTask.Decode(new[] { 13, 30, 37 }));
					Assert.AreEqual(new[] { "8c", "Td", "Ks" }, PokerCardsTask.Decode(new[] { 7, 51, 22 }));
					Assert.AreEqual(new[] { "Ad", "5h", "Qh" }, PokerCardsTask.Decode(new[] { 13, 37, 30 }));
				}

				[Test]
				public static void MatchingAndSubstitutingTest()
				{
					static void dotest(string s, string prog, string version, string exp)
					{
						Console.Write("s:\n" + s + "\n");
						Console.Write("prog: " + prog + "\n");
						Console.Write("version: " + version + "\n");
						string ans = MatchingAndSubstitutingTask.Change(s, prog, version);
						Console.Write("ACTUAL:\n" + ans + "\n");
						Console.Write("EXPECT:\n" + exp + "\n");
						Console.Write("{0:D}\n", exp == ans);
						Assert.AreEqual(exp, ans);
						Console.WriteLine("-");
					}

					String s1 = "Program title: Primes\nAuthor: Kern\nCorporation: Gold\nPhone: +1-503-555-0091\nDate: Tues April 9, 2005\nVersion: 6.7\nLevel: Alpha";
					dotest(s1, "Ladder", "1.1", "Program: Ladder Author: g964 Phone: +1-503-555-0090 Date: 2019-01-01 Version: 1.1");
					String s12 = "Program title: Primes\nAuthor: Kern\nCorporation: Gold\nPhone: +1-503-555-009\nDate: Tues April 9, 2005\nVersion: 6.7\nLevel: Alpha";
					dotest(s12, "Ladder", "1.1", "ERROR: VERSION or PHONE");
					String s13 = "Program title: Primes\nAuthor: Kern\nCorporation: Gold\nPhone: +1-503-555-0090\nDate: Tues April 9, 2005\nVersion: 67\nLevel: Alpha";
					dotest(s13, "Ladder", "1.1", "ERROR: VERSION or PHONE");

				}


				[Test]
				public void SecondVariationOnCaesarCipherTest()
				{
					string u = "I should have known that you would have a perfect answer for me!!!";
					Assert.AreEqual(u, SecondVariationOnCaesarCipherTask.decode(SecondVariationOnCaesarCipherTask.encodeStr(u, 1)));

					string x = "O CAPTAIN! my Captain! our fearful trip is done;";
					List<string> v = new List<string> { "opP DBQUBJ", "O! nz Dbqu", "bjo! pvs g", "fbsgvm usj", "q jt epof;" };
					Assert.AreEqual(x, SecondVariationOnCaesarCipherTask.decode(v));


				}

				[Test]
				public void WololooooooPriestsJoinTheWarTest()
				{
					Assert.AreEqual("Right side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("z"));
					Assert.AreEqual("Left side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("tz"));
					Assert.AreEqual("Right side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("jz"));
					Assert.AreEqual("Left side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("zt"));
					Assert.AreEqual("Right side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("tzj"));
					Assert.AreEqual("Let's fight again!", WololooooooPriestsJoinTheWarTask.AlphabetWar("zdqmwpbs"));
					Assert.AreEqual("Left side wins!", WololooooooPriestsJoinTheWarTask.AlphabetWar("ztztztzs"));
				}

				[Test]
				public void BasicDeNicoTest()
				{
					Assert.AreEqual("secretinformation", BasicDeNicoTask.DeNico("crazy", "cseerntiofarmit on  "));
					Assert.AreEqual("secretinformation", BasicDeNicoTask.DeNico("crazy", "cseerntiofarmit on"));
					Assert.AreEqual("abcd", BasicDeNicoTask.DeNico("abc", "abcd"));
					Assert.AreEqual("1234567890", BasicDeNicoTask.DeNico("ba", "2143658709"));
					Assert.AreEqual("message", BasicDeNicoTask.DeNico("a", "message"));
					Assert.AreEqual("key", BasicDeNicoTask.DeNico("key", "eky"));
				}

				[Test]
				public void FirstVariationOnCaesarCipherTest()
				{
					string u = "I should have known that you would have a perfect answer for me!!!";
					Assert.AreEqual(u, FirstVariationOnCaesarCipherTask.DemovingShift(FirstVariationOnCaesarCipherTask.MovingShift(u, 1), 1));
				}


				[Test]
				public void BasicTest()
				{
					void DoTest(string battlefield, string expected)
					{
						string actual = AlphabetWarsNuclearStrikeTask.AlphabetWar(battlefield);
						Assert.AreEqual(expected, actual, $"For Battlefield: \"{battlefield}\"");
					}

					DoTest("#[a]#[b]#", "");
					DoTest("[a]##[b]", "");
					DoTest("[a]a[b]", "aab");
					DoTest("abde[fgh]ijk", "abdefghijk");
					DoTest("ab#de[fgh]ijk", "fgh");
					DoTest("ab#de[fgh]ij#k", "");
					DoTest("##abde[fgh]ijk", "");
					DoTest("##abde[fgh]", "");
					DoTest("abde[fgh]", "abdefgh");
					DoTest("##abde[fgh]ijk[mn]op", "mn");
					DoTest("#abde[fgh]i#jk[mn]op", "mn");
					DoTest("[ab]adfd[dd]##[abe]dedf[ijk]d#d[h]#", "abijk");
				}


				[Test]
				public void BirdMountainTest()
				{
					char[][] mountain =
					{
			"^^^^^^        ".ToCharArray(),
			" ^^^^^^^^     ".ToCharArray(),
			"  ^^^^^^^     ".ToCharArray(),
			"  ^^^^^       ".ToCharArray(),
			"  ^^^^^^^^^^^ ".ToCharArray(),
			"  ^^^^^^      ".ToCharArray(),
			"  ^^^^        ".ToCharArray()
		};
					Assert.AreEqual(3, BirdMountainTask.PeakHeight(mountain));
				}

				[Test]
				public void BestTravelTest()
				{
					List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
					int? n = BestTravelTask.ChooseBestSum(163, 3, ts);
					Assert.AreEqual(163, n);

					ts = new List<int> { 50 };
					n = BestTravelTask.ChooseBestSum(163, 3, ts);
					Assert.AreEqual(null, n);

					ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
					n = BestTravelTask.ChooseBestSum(230, 3, ts);
					Assert.AreEqual(228, n);
				}

				[Test]
				public static void BuddyPairsTest()
				{
					static void testing(long start, long limit, string expected)
					{
						Console.WriteLine("start: {0}, limit: {1}, expected: {2}", start, limit, expected);
						Assert.AreEqual(expected, BuddyPairsTask.Buddy(start, limit));
					}

					testing(1071625, 1103735, "(1081184 1331967)");
					testing(2382, 3679, "Nothing");
					testing(8983, 13355, "(9504 20735)");
				}

				[Test]
				public void PlayWithTwoStringsTest()
				{
					Assert.AreEqual("abcDEfgDEFGg", new PlayWithTwoStringsTask().WorkOnStrings("abcdeFg", "defgG"));
					Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", new PlayWithTwoStringsTask().WorkOnStrings("abcdeFgtrzw", "defgGgfhjkwqe"));
					Assert.AreEqual("ABABbababa", new PlayWithTwoStringsTask().WorkOnStrings("abab", "bababa"));
					Assert.AreEqual("abCCde", new PlayWithTwoStringsTask().WorkOnStrings("abc", "cde"));
				}

				[Test]
				public void DirectionsReductionTest()
				{
					string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
					string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
					Assert.AreEqual(b, DirectionsReductionTask.DirReduc(a));
				}

			    [Test]
				public void ClosestAndSmallestTest()
				{
					CollectionAssert.AreEqual(
						new int[][] { new int[] { 8, 5, 134 }, new int[] { 8, 7, 62 } },
						ClosestAndSmallestTask.Closest("239382 162 254765 182 485944 134 468751 62 49780 108 54")
					);

					CollectionAssert.AreEqual(
						new int[][] { },
						ClosestAndSmallestTask.Closest("")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 13, 9, 85 }, new int[] { 14, 3, 176 } },
						ClosestAndSmallestTask.Closest("456899 50 11992 176 272293 163 389128 96 290193 85 52")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 10, 1, 154 }, new int[] { 10, 9, 37 } },
						ClosestAndSmallestTask.Closest("241259 154 155206 194 180502 147 300751 200 406683 37 57")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 13, 3, 175 }, new int[] { 14, 9, 167 } },
						ClosestAndSmallestTask.Closest("89998 187 126159 175 338292 89 39962 145 394230 167 1")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 13, 1, 148 }, new int[] { 13, 5, 139 } },
						ClosestAndSmallestTask.Closest("462835 148 467467 128 183193 139 220167 116 263183 41 52")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 11, 5, 119 }, new int[] { 11, 9, 128 } },
						ClosestAndSmallestTask.Closest("403749 18 278325 97 304194 119 58359 165 144403 128 38")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 6, 9, 60 }, new int[] { 6, 10, 24 } },
						ClosestAndSmallestTask.Closest("28706 196 419018 130 49183 124 421208 174 404307 60 24")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 8, 7, 53 }, new int[] { 9, 9, 27 } },
						ClosestAndSmallestTask.Closest("189437 110 263080 175 55764 13 257647 53 486111 27 66")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 11, 3, 146 }, new int[] { 11, 9, 155 } },
						ClosestAndSmallestTask.Closest("79257 160 44641 146 386224 147 313622 117 259947 155 58")
					);

					CollectionAssert.AreEqual(
						new int[][] { new int[] { 15, 0, 315411 }, new int[] { 15, 3, 87 } },
						ClosestAndSmallestTask.Closest("315411 165 53195 87 318638 107 416122 121 375312 193 59")
					);
				}

				[Test]
				public static void KPrimesTest()
				{
					Testing(Array2String(KPrimesTask.CountKprimes(2, 0, 100)),
							Array2String(new long[]
							{4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51,
				 55, 57, 58, 62, 65, 69, 74, 77, 82, 85, 86, 87, 91, 93, 94, 95}));
					Testing(Array2String(KPrimesTask.CountKprimes(3, 0, 100)),
							Array2String(new long[]
							{8, 12, 18, 20, 27, 28, 30, 42, 44, 45, 50, 52, 63, 66, 68, 70, 75, 76,
				 78, 92, 98, 99}));
					Testing(Array2String(KPrimesTask.CountKprimes(5, 1000, 1100)),
							Array2String(new long[]
							{1020, 1026, 1032, 1044, 1050, 1053, 1064, 1072, 1092, 1100}));
					Testing(Array2String(KPrimesTask.CountKprimes(5, 500, 600)),
							Array2String(new long[]
							{500, 520, 552, 567, 588, 592, 594}));

					static string Array2String(long[] list)
					{
						return "[" + string.Join(", ", list) + "]";
					}
					static void Testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

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

        [TestFixture]
        class SnakesAndLaddersTestClass
        {
            private SnakesAndLaddersTask test = new SnakesAndLaddersTask();

            [TestCase]
            [Order(1)]
            public void BasicTest1()
            {
                string result = test.Play(1, 1);
                Assert.That(result, Is.EqualTo("Player 1 is on square 38"), "Should return: 'Player 1 is on square 38'");
            }

            [TestCase]
            [Order(2)]
            public void BasicTest2()
            {
                string result = test.Play(1, 5);
                Assert.That(result, Is.EqualTo("Player 1 is on square 44"), "Should return: 'Player 1 is on square 44'");
            }

            [TestCase]
            [Order(3)]
            public void BasicTest3()
            {
                string result = test.Play(6, 2);
                Assert.That(result, Is.EqualTo("Player 2 is on square 31"), "Should return: 'Player 2 is on square 31'");
            }

            [TestCase]
            [Order(4)]
            public void BasicTest4()
            {
                string result = test.Play(1, 1);
                Assert.That(result, Is.EqualTo("Player 1 is on square 25"), "Should return: 'Player 1 is on square 25'");
            }
        }
    }
}