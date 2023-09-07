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
            List<Animal> sortedTestCase = shuffledTestCase
                .OrderByDescending(diet => diet.AnimalDiet)
                .ThenByDescending(size => size.AnimalSize).ToList();


            return sortedTestCase;
        }
    }
}
