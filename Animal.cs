using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class Animal
    {
        public string Name { get; set; }
        public Size AnimalSize { get; set; }

        public Diet AnimalDiet { get; set; }
        public Animal(string _name, Size size, Diet diet)
        {
            Name = _name;
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
