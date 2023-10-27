namespace CircusPIJN
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal Red_Fox = new Animal("Red Fox", Size.Small, Diet.Carnivore);
            Animal Crocodile = new Animal("Crocodile", Size.Medium, Diet.Carnivore);
            Animal Siberian_Tiger = new Animal("Siberian Tiger", Size.Large, Diet.Carnivore);

            Animal Monkey = new Animal("Monkey", Size.Small, Diet.Herbivore);
            Animal Horse = new Animal("Horse", Size.Medium, Diet.Herbivore);
            Animal Elephant = new Animal("Elephant", Size.Large, Diet.Herbivore);

            List<Animal> test_case_empty = new() {  };
            List<Animal> test_case = new() { Elephant, Horse, Horse, Monkey, Monkey, Monkey, Monkey, Monkey, Red_Fox, Siberian_Tiger, Horse, Crocodile };

            List<Animal> test_case_1 = new() { Elephant, Elephant, Horse, Horse, Horse, Red_Fox };
            List<Animal> test_case_2 = new() { Elephant, Horse, Horse, Monkey, Monkey, Monkey, Monkey, Monkey, Red_Fox };
            List<Animal> test_case_3 = new() { Elephant, Siberian_Tiger, Horse, Crocodile, Monkey, Red_Fox };
            List<Animal> test_case_4 = new() { Elephant, Siberian_Tiger, Horse, Horse, Horse, Horse, Horse, Crocodile, Monkey, Red_Fox, Red_Fox };
            List<Animal> test_case_5 = new() { Elephant, Elephant, Horse, Monkey, Red_Fox };
            List<Animal> test_case_6 = new() { Horse, Horse, Elephant, Elephant, Elephant, Red_Fox, Red_Fox, Red_Fox };
            List<Animal> test_case_7 = new() { Elephant, Elephant, Elephant, Elephant, Elephant, Elephant, Siberian_Tiger, Siberian_Tiger, Siberian_Tiger, Horse, Horse, Horse, Horse, Horse, Crocodile, Crocodile, Crocodile, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox };
            
            Station station = new Station();
            AnimalSorter animalSorter = new AnimalSorter();

            Console.WriteLine("                 _-====-__-======-__-========-_____-============-__\r\n               _(                                                 _)\r\n            OO(         CircusPijn Choo Chooooo!!                   )_\r\n           0  (_                                                   _)\r\n         o0     (_                                                _)\r\n        o         '=-___-===-_____-========-___________-===-=-=-='\r\n      .o                                _________\r\n     . ______          ______________  |         |      _____\r\n   _()_||__|| ________ |            |  |_________|   __||___||__\r\n  (bruh 2121| |      | |            | __Y______00_| |_         _|\r\n /-OO----OO\"\"=\"OO--OO\"=\"OO--------OO\"=\"OO-------OO\"=\"OO-------OO\"=P\r\n#####################################################################");
            
            
            
            List<Animal> shuffledTestCase = animalSorter.RandomizeTestCase(test_case_1);

            List<Animal> sortedLargeToSmallTestCase = animalSorter.SortTestCaseLargeToSmall(shuffledTestCase);
            List<Animal> sortedSmallToLargeTestCase = animalSorter.SortTestCaseSmallToLarge(shuffledTestCase);


            if (station.CalculateTrain(sortedSmallToLargeTestCase) < station.CalculateTrain(sortedLargeToSmallTestCase))
            {
                station.StartTrain(sortedSmallToLargeTestCase);
            }
            else
            {
                station.StartTrain(sortedLargeToSmallTestCase);
            }

        }
    }
}