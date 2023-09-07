using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class Station
    {
        private readonly Train train;
        private readonly AnimalPlacer animalPlacer;

        public Station()
        {
            train = new Train();
            animalPlacer = new AnimalPlacer(train);
        }

        public void StartTrain(List<Animal> animals)
        {
            if (animals.Count != 0)
            {
                foreach (Animal animal in animals)
                {
                    animalPlacer.PlaceAnimalInWagon(animal);
                }
            train.PrintWagons();
            }
            else
            {
                Console.WriteLine("Train couldn't chooo chooo, no passengers!");
            }
        }
    }
}
