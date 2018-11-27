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
        public int Points { get; private set; }
        public int MaxPoints { get; private set; }

        public Wagon()
        {
            Animals = new List<Animal>();
            Points = 0;
            MaxPoints = 10;
        }

        public void AddAnimal(Animal animal)
        {
            animal.Placed = true;
            Points += (int)animal.Magnitude;
            Animals.Add(animal);
        }

        public bool HasBigCarnivore()
        {
            if(Animals.Any(item => item.Magnitude == Enums.Magnitude.Large && item.Diet == Enums.Diet.Carnivore))
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
