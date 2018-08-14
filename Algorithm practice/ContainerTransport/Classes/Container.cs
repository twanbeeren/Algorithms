using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Container
    {
        int id;
        int loadCapacity = 120000;
        int maxWeight = 30000;
        int standardWeight = 4000;
        int cargoWeight;
        ContainerType sort;
        bool placed = false;
        

        public Container(ContainerType type)
        {
            CargoWeight = randomWeight();
            sort = type;
        }

        public int LoadCapacity { get => loadCapacity; set => loadCapacity = value; }
        public int CargoWeight { get => cargoWeight; set => cargoWeight = value; }
        public ContainerType Sort { get => sort; set => sort = value; }
        public bool Placed { get => placed; set => placed = value; }

        public int randomWeight()
        {
            Random rnd = new Random();
            return rnd.Next(standardWeight, maxWeight);
        }

        public override string ToString()
        {
            return "Container: " + id;
        }
    }
}
