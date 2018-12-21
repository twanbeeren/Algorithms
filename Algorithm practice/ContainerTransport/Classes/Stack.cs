using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Stack
    {
        List<Container> containers = new List<Container>();
        int weight = 0;
        int height = 0;
        bool placed = false;
        bool cooled = false;

        public List<Container> Containers { get => containers; set => containers = value; }
        public bool Placed { get => placed; set => placed = value; }
        public int Weight { get => weight; set => weight = value; }
        public bool Cooled { get => cooled; set => cooled = value; }

        public void Fill(Container container)
        {
            foreach(Container _container in containers)
            {
                _container.LoadWeight += container.Weight;
            }
            container.Placed = true;
            containers.Add(container);
            weight += container.Weight;
            height = containers.Count();
            if(container.Sort == Type.Cooled)
            {
                Cooled = true;
            }
        }

        public bool CheckWeight(Container container)
        {
            var loadWeight = 0;
            if (containers.Any())
            {
                loadWeight = containers.First().LoadWeight;
            }

            if(loadWeight + container.Weight < container.LoadCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsValuableContainer()
        {
            if(containers.Any(c => c.Sort == Type.Valuable))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RoomForValuableContainer(Container container)
        {
            if((weight + (container.StandardWeight + container.MaxCargoWeight)) < container.LoadCapacity )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Aantal Containers: " + Containers.Count + ", Gewicht: " + Weight;
        }


    }
}
