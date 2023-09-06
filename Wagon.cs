using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class Wagon
    {
        private readonly int maxSize = 10;

        List<Animal> animals = new List<Animal>();

        public bool CheckWeight(Animal otherAnimal)
        {
            int CurrentWeight = 0;
            foreach (var animal in animals)
            {
                CurrentWeight += (int)animal.AnimalSize;
            }

            if (CurrentWeight + (int)otherAnimal.AnimalSize <= maxSize)
            {
                return true;
            }
            return false;
        }
    }
}
