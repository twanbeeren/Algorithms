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
        public Diet Diet { get; private set; }

        public Magnitude Magnitude { get; private set; }

        public Animal(Diet diet, Magnitude magnitude)
        {
            Diet = diet;
            Magnitude = magnitude;
        }

        public override string ToString()
        {
            return Diet + "," + Magnitude;
        }
    }
}
