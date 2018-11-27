using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Services
    {
        public List<Animal> Animals = new List<Animal>();
        
        public List<Wagon> PlaceLargeCarnivores()
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon;
            foreach(Animal animal in Animals)
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

        public List<Wagon> PlaceCarnivores()
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon;
            foreach (Animal animal in Animals)
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

        public List<Wagon> PlaceHerbivores(List<Wagon> wagons)
        {
            bool cont = true;
            do {
                foreach (Wagon wagon in wagons)
                {
                    foreach (Animal animal in Animals)
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

                cont = Animals.Any(item => item.Placed == false);
                if (cont)
                {
                    Wagon newwagon = new Wagon();
                    wagons.Add(newwagon);
                }
            } while (cont);

            return wagons;
        }
        
        public Train FillTrain(Train train)
        {
            train.Wagons.AddRange(PlaceLargeCarnivores());
            List<Wagon> carnivoreWagons = PlaceCarnivores();

            train.Wagons.AddRange(PlaceHerbivores(carnivoreWagons));
            return train;
        }
    }
}
