using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class AnimalPlacer
    {
        private readonly Train train;

        public AnimalPlacer(Train train)
        {
            this.train = train;
        }
        public void PlaceAnimalInWagon(Animal currentAnimal)
        {
            bool animalIsPlaced = false;
            foreach (var wagon in train.GetWagons())
            {
                if (currentAnimal.AnimalDiet == Diet.Carnivore && wagon.CheckWeight(currentAnimal) && !wagon.ContainsCarnivore())
                {
                    wagon.AddAnimal(currentAnimal);
                    animalIsPlaced = true;
                    break;
                }

                if (currentAnimal.AnimalDiet == Diet.Herbivore && wagon.CheckWeight(currentAnimal))
                {
                    if (wagon.isHerbivoreLarger(currentAnimal))
                    {
                        wagon.AddAnimal(currentAnimal);
                        animalIsPlaced = true;
                        break;
                    }
                }
            }

            if (!animalIsPlaced)
            {
                train.CreateWagon();
                PlaceAnimalInWagon(currentAnimal);
            }
        }
    }
}
