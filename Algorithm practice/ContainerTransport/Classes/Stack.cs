using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Stack
    {
        List<Container> StackContainers = new List<Container>();
        bool placed = false;

        public bool Placed { get => placed; set => placed = value; }

        public List<Container> fillStack(IEnumerable<Container> containers)
        {
            foreach(Container container in containers)
            {
                if (checkWeight(container) && checkValuableContainer() && container.Placed)
                {
                    StackContainers.Add(container);
                }
            }
            return StackContainers;
        }

        public bool checkWeight(Container container)
        {
            int stackweight = StackContainers.Sum(x => x.CargoWeight);

            if(stackweight + container.CargoWeight < container.LoadCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkValuableContainer()
        {
            var item = StackContainers[StackContainers.Count - 1];
            if(item.Sort != ContainerType.Valuable)
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
