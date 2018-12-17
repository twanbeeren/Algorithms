using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Ship
    {
        public int MinWeight { get; private set; }
        public Ship(int maxWeight)
        {
            MinWeight = maxWeight / 2;
        }
    }
}
