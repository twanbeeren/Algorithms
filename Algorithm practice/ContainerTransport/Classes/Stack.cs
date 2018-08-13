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
        
        public List<Container> fillStack(Container container)
        {
            //Can only fill one container per stack atm. Need to give the parameter an IEnumerable<Container>.
            if (checkWeight(container) && checkValuableContainer())
            {
                StackContainers.Add(container);
            }
            return StackContainers;
        }

        public bool checkWeight(Container container)
        {
            int maxweight = StackContainers.Sum(x => x.cargoWeight);

            if(maxweight + container.cargoWeight < container.loadCapacity)
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
            if(item.sort != ContainerType.Valuable)
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
