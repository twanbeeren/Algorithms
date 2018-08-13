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
        int LoadCapacity = 120000;
        int MaxWeight = 30000;
        int StandardWeight = 4000;
        int CargoWeight;
        ContainerType Sort;
        

        public Container(ContainerType type)
        {
            CargoWeight = randomWeight();
            Sort = type;
        }

        public int loadCapacity { get => LoadCapacity; set => LoadCapacity = value; }
        public int cargoWeight { get => CargoWeight; set => CargoWeight = value; }
        public ContainerType sort { get => Sort; set => Sort = value; }

        public int randomWeight()
        {
            Random rnd = new Random();
            return rnd.Next(StandardWeight, MaxWeight);
        }

        public override string ToString()
        {
            return "Container: " + id;
        }
    }
}
