using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal static class AnimalFactory
    {
        public static Animal MakeAnimal(Diet diet, Magnitude magnitude)
        {
            Animal animal = new Animal(diet, magnitude);
            return animal;
        }

        public static List<Animal> MakeRandomAnimals()
        {
            List<Animal> animals = new List<Animal>();
            List<Diet> diets = new List<Diet>();
            List<Magnitude> magnitudes = new List<Magnitude>();

            foreach (Diet diet in Enum.GetValues(typeof(Diet)))
            {
                diets.Add(diet);
            }

            foreach (Magnitude magnitude in Enum.GetValues(typeof(Magnitude)))
            {
                magnitudes.Add(magnitude);
            }

            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(10, 100); i++)
            {
                Animal animal = MakeAnimal(diets[rnd.Next(diets.Count)], magnitudes[rnd.Next(magnitudes.Count)]);
                animals.Add(animal);
            }

            return animals;
        }
    }
}
