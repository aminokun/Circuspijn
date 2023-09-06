using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class AnimalSorter
    {
        public List<Animal> RandomizeTestCase(List<Animal> testCase)
        {
            Random rand = new Random();
            List<Animal> shuffledTestCase = testCase.OrderBy(_ => rand.Next()).ToList();
            return shuffledTestCase;
        }

        public List<Animal> SortTestCase(List<Animal> shuffledTestCase)
        {
            List<Animal> sortedDiet = shuffledTestCase.OrderByDescending(diet => diet.AnimalDiet).ToList();

            List<Animal> sortedCarnivores = sortedDiet.Where(animal => animal.AnimalDiet == Diet.Carnivore).ToList();
            sortedCarnivores = sortedCarnivores.OrderByDescending(size => size.AnimalSize).ToList();

            List<Animal> sortedHerbivores = sortedDiet.Where(animal => animal.AnimalDiet == Diet.Herbivore).ToList();
            sortedHerbivores = sortedHerbivores.OrderByDescending(size => size.AnimalSize).ToList();

            List<Animal> sortedTestCase = new List<Animal>();

            sortedTestCase = sortedCarnivores;
            sortedTestCase.AddRange(sortedHerbivores);

            //foreach (var animal in sortedTestCase)
            //{
            //    Console.WriteLine("           " + animal.Name);
            //}

            return sortedTestCase;
        }
    }
}
