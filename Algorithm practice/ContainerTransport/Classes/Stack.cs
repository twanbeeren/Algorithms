using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    internal class Stack
    {
        List<Container> containers = new List<Container>();
        int weight = 0;
        bool placed = false;

        public bool Placed { get => placed; set => placed = value; }
        public int Weight { get => weight; set => weight = value; }
        public List<Container> Containers { get => containers; set => containers = value; }
        

        public bool CheckWeight(Container container)
        {
            
            if(weight + container.Weight < container.LoadCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValuableContainer()
        {
            var item = Containers[Containers.Count - 1];
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
