namespace CircusPIJN
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal Red_Fox = new Animal("Red Fox", Size.Small, Diet.Carnivore);
            Animal Crocodile = new Animal("Crocodile", Size.Medium, Diet.Carnivore);
            Animal Siberian_Tiger = new Animal("Siberian Tiger", Size.Large, Diet.Carnivore);

            //Animal Monkey = new Animal("\r\n               ',\r\n            .-`-,\\__\r\n              .\"`   `,\r\n            .'_.  ._  `;.\r\n        __ / `      `  `.\\ .--.\r\n       /--,| 0)   0)     )`_.-,)\r\n      |    ;.-----.__ _-');   /\r\n       '--./         `.`/  `\"`\r\n          :   '`      |.      \r\n          | \\     /  //         \r\n           \\ '---'  /'        \r\n            `------' \\  \r\n             _/       `--... \r\n", Size.Small, Diet.Herbivore);
            //Animal Horse = new Animal("\r\n            .''\r\n  ._.-.___.' (`\\\r\n //(        ( `'\r\n'/ )\\ ).__. ) \r\n' <' `\\ ._/'\\\r\n   `   \\     \\ \r\n", Size.Medium, Diet.Herbivore);


            Animal Monkey = new Animal("Monkey", Size.Small, Diet.Herbivore);
            Animal Horse = new Animal("Horse", Size.Medium, Diet.Herbivore);
            Animal Elephant = new Animal("Elephant", Size.Large, Diet.Herbivore);

            List<Animal> test_case_empty = new() {  };
            List<Animal> test_case_0 = new() { Red_Fox, Elephant, Elephant, Elephant, Elephant, Elephant, Elephant };
            List<Animal> test_case_1 = new() { Elephant, Elephant, Horse, Horse, Horse, Red_Fox };
            List<Animal> test_case_2 = new() { Elephant, Horse, Horse, Monkey, Monkey, Monkey, Monkey, Monkey, Red_Fox };
            List<Animal> test_case_3 = new() { Elephant, Siberian_Tiger, Horse, Crocodile, Monkey, Red_Fox };
            List<Animal> test_case_4 = new() { Elephant, Siberian_Tiger, Horse, Horse, Horse, Horse, Horse, Crocodile, Monkey, Red_Fox, Red_Fox };
            List<Animal> test_case_5 = new() { Elephant, Elephant, Horse, Monkey, Red_Fox };
            List<Animal> test_case_6 = new() { Red_Fox, Horse, Horse, Elephant, Elephant, Elephant, Red_Fox, Red_Fox };
            List<Animal> test_case_7 = new() { Elephant, Elephant, Elephant, Elephant, Elephant, Elephant, Siberian_Tiger, Siberian_Tiger, Siberian_Tiger, Horse, Horse, Horse, Horse, Horse, Crocodile, Crocodile, Crocodile, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox, Red_Fox };
            
            Station station = new Station();
            AnimalSorter animalSorter = new AnimalSorter();

            Console.WriteLine("                 _-====-__-======-__-========-_____-============-__\r\n               _(                                                 _)\r\n            OO(         CircusPijn Choo Chooooo!!                   )_\r\n           0  (_                                                   _)\r\n         o0     (_                                                _)\r\n        o         '=-___-===-_____-========-___________-===-=-=-='\r\n      .o                                _________\r\n     . ______          ______________  |         |      _____\r\n   _()_||__|| ________ |            |  |_________|   __||___||__\r\n  (bruh 2121| |      | |            | __Y______00_| |_         _|\r\n /-OO----OO\"\"=\"OO--OO\"=\"OO--------OO\"=\"OO-------OO\"=\"OO-------OO\"=P\r\n#####################################################################");
            
            List<Animal> shuffledTestCase = animalSorter.RandomizeTestCase(test_case_6);

            List<Animal> sortedTestCase = animalSorter.SortTestCase(shuffledTestCase);
            station.StartTrain(sortedTestCase);



        }
    }
}