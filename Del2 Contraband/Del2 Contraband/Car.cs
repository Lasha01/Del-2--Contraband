using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del2_Contraband
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random rng = new Random();


        public bool Examine()
        {
            alreadyChecked = true;
            if (contrabandAmount < 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
       
           
       
    }
}

