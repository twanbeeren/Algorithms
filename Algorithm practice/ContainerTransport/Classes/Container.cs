using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Container
    {
        int weight;
        int loadWeight = 0;
        int loadCapacity = 120000;
        int maxCargoWeight = 26000;
        int standardWeight = 4000;
        Type sort;
        bool placed = false;
        static Random rnd = new Random();


        public Container(Type type)
        {
            Weight = StandardWeight + RandomWeight();
            sort = type;
        }

        public int LoadCapacity { get => loadCapacity; private set => loadCapacity = value; }
        public Type Sort { get => sort; private set => sort = value; }
        public bool Placed { get => placed; set => placed = value; }
        public int Weight { get => weight; set => weight = value; }
        public int MaxCargoWeight { get => maxCargoWeight; private set => maxCargoWeight = value; }
        public int StandardWeight { get => standardWeight; private set => standardWeight = value; }
        public int LoadWeight { get => loadWeight; set => loadWeight = value; }

        private int RandomWeight()
        {
            return rnd.Next(StandardWeight, MaxCargoWeight);
        }

        public override string ToString()
        {
            return "Weight: " + this.weight;
        }
    }
}
