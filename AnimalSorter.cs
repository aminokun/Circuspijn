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

        public List<Animal> SortTestCaseLargeToSmall(List<Animal> shuffledTestCase)
        {
            List<Animal> sortedLargeToSmallTestCase = shuffledTestCase
                .OrderByDescending(diet => diet.AnimalDiet)
                .ThenByDescending(size => size.AnimalSize).ToList();


            return sortedLargeToSmallTestCase;
        }
        public List<Animal> SortTestCaseSmallToLarge(List<Animal> shuffledTestCase)
        {
            List<Animal> sortedSmallToLargeTestCase = shuffledTestCase
                .OrderByDescending(diet => diet.AnimalDiet)
                .ThenBy(size => size.AnimalSize).ToList();


            return sortedSmallToLargeTestCase;
        }
    }
}
