using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Animal
    {
        public bool Placed { get; set; }
        public Diet Diet { get; private set; }

        public Magnitude Magnitude { get; private set; }

        public Animal(Diet diet, Magnitude magnitude)
        {
            Placed = false;
            Diet = diet;
            Magnitude = magnitude;
        }
        public override string ToString()
        {
            return Diet + "," + Magnitude;
        }
        
        public bool GetsEatenByCarnivore(Wagon wagon)
        {
            foreach (Animal animal in wagon.Animals)
            {
                if (animal.Diet == Diet.Carnivore && this.Magnitude <= animal.Magnitude)
                {
                    return true;
                }
            }
            return false;
        }

    }
}