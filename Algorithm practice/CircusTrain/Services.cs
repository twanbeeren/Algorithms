using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    static class Services
    {
        public static Train FillTrain(Train train, List<Animal> animals)
        {
            animals = animals.OrderByDescending(a => (int)a.Magnitude).ToList();

            train.Wagons.AddRange(PlaceLargeCarnivores(animals));
            List<Wagon> carnivoreWagons = PlaceCarnivores(animals);
            train.Wagons.AddRange(PlaceHerbivores(carnivoreWagons, animals));
            return train;
        }
        private static List<Wagon> PlaceLargeCarnivores(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon;
            foreach(Animal animal in animals)
            {
                if( animal.Diet == Diet.Carnivore && animal.Magnitude == Magnitude.Large)
                {
                    wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    wagons.Add(wagon);
                }
            }
            return wagons;
        }

        private static List<Wagon> PlaceCarnivores(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon;
            foreach (Animal animal in animals)
            {
                if (animal.Placed == false && animal.Diet == Diet.Carnivore)
                {
                    wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    wagons.Add(wagon);
                }
            }
            return wagons;
        }

        private static List<Wagon> PlaceHerbivores(List<Wagon> wagons, List<Animal> animals)
        {
            bool cont = true;
            do {
                foreach (Wagon wagon in wagons)
                {
                    foreach (Animal animal in animals)
                    {
                        if (animal.Placed == false && wagon.Points < wagon.MaxPoints)
                        {
                            if (wagon.AnimalFits(animal) && !animal.GetsEatenByCarnivore(wagon))
                            {
                                wagon.AddAnimal(animal);
                            }
                        }
                    }
                }

                cont = animals.Any(item => item.Placed == false);
                if (cont)
                {
                    Wagon newwagon = new Wagon();
                    wagons.Add(newwagon);
                }
            } while (cont);

            return wagons;
        }
        
        
    }
}
