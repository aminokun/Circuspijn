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

        List<Animal> animalsInWagon = new List<Animal>();
        public int CurrentWeight { get; set; }

        public bool CheckWeight(Animal otherAnimal)
        {
            CurrentWeight = 0;
            foreach (var animal in animalsInWagon)
            {
                CurrentWeight += (int)animal.AnimalSize;
            }

            if (CurrentWeight + (int)otherAnimal.AnimalSize <= maxSize)
            {
                CurrentWeight += (int)otherAnimal.AnimalSize;
                return true;
            }
            return false;
        }

        public bool ContainsCarnivore()
        {
            foreach(var animal in animalsInWagon)
            {
                if(animal.AnimalDiet == Diet.Carnivore)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isHerbivoreLarger(Animal potentialPassenger)
        {
            foreach (var animal in animalsInWagon)
            {
                if (animal.AnimalDiet == Diet.Carnivore)
                {
                    if (potentialPassenger.AnimalSize <= animal.AnimalSize)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void AddAnimal(Animal currentAnimal)
        {
            animalsInWagon.Add(currentAnimal);
        }

        public void PrintContents()
        {
            foreach (var animal in animalsInWagon)
            {
                Console.WriteLine($"    |{animal.Name.PadRight(15)}|{animal.AnimalSize.ToString().PadRight(8)}|{animal.AnimalDiet} |");
            }
        }
    }
}
