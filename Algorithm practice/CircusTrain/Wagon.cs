using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Wagon
    {
        public List<Animal> Animals { get; set; }
        public int Points { get; set; }
        public int MaxPoints { get; private set; }

        public Wagon()
        {
            Points = 0;
            MaxPoints = 10;
        }
        
        public bool HasBigCarnivore()
        {
            if(Animals.Any(item => item.Magnitude == Enums.Magnitude.large && item.Diet == Enums.Diet.carnivore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AnimalFits(Animal animal)
        {
            if ((Points + (int)animal.Magnitude) <= MaxPoints)
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
