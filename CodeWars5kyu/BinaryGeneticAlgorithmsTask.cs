using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class BinaryGeneticAlgorithmsTask
	{
		private Random random = new Random();

		public string Generate(int length)
		{
			char[] chromosome = new char[length];
			for (int i = 0; i < length; i++)
			{
				chromosome[i] = random.Next(2) == 0 ? '0' : '1';
			}
			return new string(chromosome);
		}

		public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses, double sum = 0)
		{

			if (sum == 0)
			{
				sum = fitnesses.Sum();
			}

			double randomValue = random.NextDouble() * sum;
			double cumulativeSum = 0;

			using (var popEnum = population.GetEnumerator())
			using (var fitEnum = fitnesses.GetEnumerator())
			{
				while (popEnum.MoveNext() && fitEnum.MoveNext())
				{
					cumulativeSum += fitEnum.Current;
					if (cumulativeSum >= randomValue)
					{
						return popEnum.Current;
					}
				}
			}

			return population.Last();

		}

		public string Mutate(string chromosome, double probability)
		{
			char[] mutated = chromosome.ToCharArray();
			for (int i = 0; i < mutated.Length; i++)
			{
				if (random.NextDouble() < probability)
				{
					mutated[i] = mutated[i] == '0' ? '1' : '0';
				}
			}
			return new string(mutated);
		}

		public IEnumerable<string> Crossover(string chromosome1, string chromosome2)
		{
			int length = chromosome1.Length;
			int crossoverPoint = random.Next(1, length - 1);

			string offspring1 = chromosome1.Substring(0, crossoverPoint) + chromosome2.Substring(crossoverPoint);
			string offspring2 = chromosome2.Substring(0, crossoverPoint) + chromosome1.Substring(crossoverPoint);

			return new string[] { offspring1, offspring2 };
		}

		public string Run(Func<string, double> fitness, int length, double p_c, double p_m, int iterations = 100)
		{
			int populationSize = 100;
			List<string> population = new List<string>();
			List<double> fitnessScores = new List<double>();

			for (int i = 0; i < populationSize; i++)
			{
				string chromosome = Generate(length);
				population.Add(chromosome);
				fitnessScores.Add(fitness(chromosome));
			}

			for (int iter = 0; iter < iterations; iter++)
			{
				List<string> newPopulation = new List<string>();

				while (newPopulation.Count < populationSize)
				{
					string parent1 = Select(population, fitnessScores);
					string parent2 = Select(population, fitnessScores);

					IEnumerable<string> offspring;
					if (random.NextDouble() < p_c)
					{
						offspring = Crossover(parent1, parent2);
					}
					else
					{
						offspring = new string[] { parent1, parent2 };
					}

					foreach (string child in offspring)
					{
						string mutatedChild = Mutate(child, p_m);
						newPopulation.Add(mutatedChild);

						if (newPopulation.Count >= populationSize)
						{
							break;
						}
					}
				}

				population = newPopulation;
				fitnessScores = population.Select(fitness).ToList();
			}

			return population.OrderByDescending(chromosome => fitness(chromosome)).First();
		}
	}
}
//https://www.codewars.com/kata/526f35b9c103314662000007/train/csharp