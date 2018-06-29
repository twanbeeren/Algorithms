using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeSorter
{
    public class Pancake
    {
        private int size;

        public Pancake()
        {
            size = RandomSize();
        }

        public int Size { get => size;}

        private int RandomSize()
        {
            Random random = new Random();
            return random.Next(11);
        }

        public override string ToString()
        {
            return "Size: " + size;
        }
    }
}
