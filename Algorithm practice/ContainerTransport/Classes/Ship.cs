using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Ship
    {
        int min_weight;
        public Ship(int max_weight)
        {
            min_weight = max_weight / 2;
        }
    }
}
