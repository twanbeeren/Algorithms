using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    internal class Container
    {
        int weight;
        int loadCapacity = 120000;
        int maxCargoWeight = 26000;
        int standardWeight = 4000;
        ContainerType sort;
        bool placed = false;
        

        public Container(ContainerType type)
        {
            Weight = standardWeight + RandomWeight();
            sort = type;
        }

        public int LoadCapacity { get => loadCapacity; set => loadCapacity = value; }
        public ContainerType Sort { get => sort; set => sort = value; }
        public bool Placed { get => placed; set => placed = value; }
        public int Weight { get => weight; set => weight = value; }

        private int RandomWeight()
        {
            Random rnd = new Random();
            return rnd.Next(standardWeight, maxCargoWeight);
        }
        
    }
}
