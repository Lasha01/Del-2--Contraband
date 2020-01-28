using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del2_Contraband
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = rng.Next(1, 5);
            contrabandAmount = rng.Next(1, 5);
        }

    }
}
