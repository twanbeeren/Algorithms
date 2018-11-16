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
        
        private void AddAnimalToWagon(Wagon wagon, Animal animal)
        {
            animal.Placed = true;
            wagon.Points += (int)animal.Magnitude;
            wagon.Animals.Add(animal);
        }

        public List<Wagon> PlaceLargeCarnivores()
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon;
            foreach(Animal animal in Animals)
            {
                if(animal.Diet == Diet.carnivore && animal.Magnitude == Magnitude.large)
                {
                    wagon = new Wagon();
                    AddAnimalToWagon(wagon, animal);
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
                if (animal.Diet == Diet.carnivore)
                {
                    wagon = new Wagon();
                    AddAnimalToWagon(wagon, animal);
                    wagons.Add(wagon);
                }
            }
            return wagons;
        }

        public List<Wagon> PlaceHerbivores(List<Wagon> wagons)
        {
            foreach(Wagon wagon in wagons)
            {
                foreach (Animal animal in Animals)
                {
                    if (animal.Placed == false && wagon.Points < wagon.MaxPoints)
                    {
                        if (wagon.AnimalFits(animal) && !animal.GetsEatenByCarnivore(wagon))
                        {
                            AddAnimalToWagon(wagon, animal);
                        }
                    }
                }
            }
            return wagons;
        }
        
        public List<Wagon> FillWagons()
        {
            List<Wagon> wagons = new List<Wagon>();
            Wagon wagon = new Wagon();

            wagons.AddRange(PlaceLargeCarnivores());
            wagons.AddRange(PlaceHerbivores(PlaceCarnivores()));
            
            return wagons;
        }
        public Train FillTrain(Train train, IEnumerable<Wagon> wagons)
        {
            train.Wagons.AddRange(wagons);
            return train;
        }
    }
}
