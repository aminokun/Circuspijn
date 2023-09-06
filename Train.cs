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
        public int WagonCount()
        {
            return wagons.Count;
        }

        public void CreateWagon()
        {
            Wagon wagon = new Wagon();
        }
    }
}
