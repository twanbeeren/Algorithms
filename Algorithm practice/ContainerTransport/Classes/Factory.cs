using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport.Classes
{
    internal class Factory
    {
        Service Service;
        public Factory(Service services)
        {
            Service = services;
        }
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
                Container CooledContainer = new Container(ContainerType.Cooled);
                Service.totalcontainers.Add(CooledContainer);
                counter++;
            }
        }

        public void AddNormalContainers(int normalCount)
        {
            int counter = 0;
            while (counter < normalCount)
            {
                Container NormalContainer = new Container(ContainerType.Normal);
                Service.totalcontainers.Add(NormalContainer);
                counter++;
            }
        }

        public void AddValuableContainers(int valuableCount)
        {
            int counter = 0;
            while (counter < valuableCount)
            {
                Container ValuableContainer = new Container(ContainerType.Valuable);
                Service.totalcontainers.Add(ValuableContainer);
                counter++;
            }
        }
    }
}
