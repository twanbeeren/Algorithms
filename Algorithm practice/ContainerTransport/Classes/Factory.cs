using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public static class Factory
    {
        
        public static Ship CreateShip(int maxWeight)
        {
            Ship ship = new Ship(maxWeight);
            return ship;
        }
        public static List<Container> CreateContainers(int cooledCount, int normalCount, int valuableCount)
        {
            List<Container> containers = new List<Container>();
            containers.AddRange(CreateCooledContainers(cooledCount));
            containers.AddRange(CreateNormalContainers(normalCount));
            containers.AddRange(CreateValuableContainers(valuableCount));
            return containers;
        }

        private static List<Container> CreateCooledContainers(int cooledCount)
        {
            List<Container> containers = new List<Container>();
            int counter = 0;
            while (counter < cooledCount)
            {
                Container CooledContainer = new Container(Type.Cooled);
                containers.Add(CooledContainer);
                counter++;
            }
            return containers;
        }

        private static List<Container> CreateNormalContainers(int normalCount)
        {
            List<Container> containers = new List<Container>();
            int counter = 0;
            while (counter < normalCount)
            {
                Container NormalContainer = new Container(Type.Normal);
                containers.Add(NormalContainer);
                counter++;
            }
            return containers;
        }

        private static List<Container> CreateValuableContainers(int valuableCount)
        {
            List<Container> containers = new List<Container>();
            int counter = 0;
            while (counter < valuableCount)
            {
                Container ValuableContainer = new Container(Type.Valuable);
                containers.Add(ValuableContainer);
                counter++;
            }
            return containers;
        }
        
    }
}
