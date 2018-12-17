using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Factory
    {
        public List<Container> containers = new List<Container>();
        
        public Ship CreateShip(int maxWeight)
        {
            Ship ship = new Ship(maxWeight);
            return ship;
        }

        public void AddCooledContainers(int cooledCount)
        {
            int counter = 0;
            while (counter < cooledCount)
            {
                Container CooledContainer = new Container(Type.Cooled);
                containers.Add(CooledContainer);
                counter++;
            }
        }

        public void AddNormalContainers(int normalCount)
        {
            int counter = 0;
            while (counter < normalCount)
            {
                Container NormalContainer = new Container(Type.Normal);
                containers.Add(NormalContainer);
                counter++;
            }
        }

        public void AddValuableContainers(int valuableCount)
        {
            int counter = 0;
            while (counter < valuableCount)
            {
                Container ValuableContainer = new Container(Type.Valuable);
                containers.Add(ValuableContainer);
                counter++;
            }
        }

        public List<Container> OrderContainers()
        {
            return containers.OrderBy(c => c.Weight).ToList();
        }
    }
}
