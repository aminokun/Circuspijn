using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class Animal
    {
        public Size AnimalSize { get; set; }

        public Diet AnimalDiet { get; set; }
        public bool CanEat(Animal otherAnimal)
        {
            if (AnimalDiet == Diet.Carnivore && otherAnimal.AnimalSize <= AnimalSize)
            {
                return true;
            }

            return false;
        }
        public Animal(Size size, Diet diet)
        {
            AnimalSize = size;
            AnimalDiet = diet;
        }
    }

    public enum Size
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }
    public enum Diet
    {
        Herbivore,
        Carnivore
    }

}
