using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeSorter
{
    public class Pancake
    {
        public int Size { get; private set; }
        public Pancake()
        {
            Size = RandomSize();
        }
        
        private int RandomSize()
        {
            Random random = new Random();
            return random.Next(1, 11);
        }

        public override string ToString()
        {
            return "Size: " + size;
        }
    }
}
