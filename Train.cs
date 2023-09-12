using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusPIJN
{
    public class Train
    {
        List<Wagon> wagons = new List<Wagon>();
        public void CreateWagon()
        {
            Wagon wagon = new Wagon();
            wagons.Add(wagon);
        }
        public int WagonCount()
        {
            return wagons.Count;
        }
        public List<Wagon> GetWagons()
        {
            return wagons;
        }

        public void ClearWagons()
        {
            wagons.Clear();
        }
        public void PrintWagons()
        {
            int wagonNumber = 1;
            foreach (var wagon in wagons)
            {
                Console.WriteLine($"Wagon {wagonNumber}:");
                Console.WriteLine($"Wagon weight {wagon.CurrentWeight}");

                wagon.PrintContents();
                wagonNumber++;
                Console.Write("\n");
            }
        }
    }
}
