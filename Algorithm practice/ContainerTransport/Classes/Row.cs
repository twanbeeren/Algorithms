using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Row
    {
        public List<Stack> Stacks = new List<Stack>();
        public int Weight { get; set; }
        public bool LowestWeight = true;
        public Place Place = Place.UnAssigned;
        
        public void Fill(Stack stack)
        {
            Stacks.Add(stack);
            Weight += stack.Weight;
            stack.Placed = true;
        }

        public void Set(Place place)
        {
            this.Place = place;
        }

        public bool ContainsCooledStack()
        {
            if(Stacks.Any(s => s.Cooled == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValuableContainerBlocked(Stack newstack)
        {
            bool blocked = false;
            List<int> indexes = new List<int>();
            foreach (Stack stack in Stacks)
            {
                int maxindex1 = stack.Containers.Count;
                int maxindex2 = newstack.Containers.Count;

                if (!Stacks.Any(c => (maxindex1 - 1) <= (maxindex2 - 1) && c.Containers[maxindex1 - 1].Sort == Type.Valuable))
                {
                    blocked = true;
                }
            }
            return blocked;
        }

    }
}
