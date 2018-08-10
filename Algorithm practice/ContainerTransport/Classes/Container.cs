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
        int carryweight = 120000;
        int maxweight = 30000;
        int standardweight = 4000;
        int cargoweight;
        ContainerType sort;
        

        public Container(ContainerType type)
        {
            cargoweight = randomWeight();
            sort = type;
        }

        public int randomWeight()
        {
            Random rnd = new Random();
            return rnd.Next(standardweight, maxweight);
        }

        public override string ToString()
        {
            return "Container: " + id;
        }
    }
}
