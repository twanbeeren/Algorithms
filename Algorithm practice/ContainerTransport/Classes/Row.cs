using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    internal class Row
    {
        List<Stack> Stacks = new List<Stack>();
        public int Weight { get; set; }

        public void Fill(List<Stack> stacks)
        {
            foreach(Stack stack in stacks)
            {
                if (!ValuableContainerBlocked(stack))
                {
                    PlaceStack(stack);
                }
            }
        }

        public void PlaceStack(Stack stack)
        {
            Stacks.Add(stack);
            Weight += stack.Weight;
            stack.Placed = true;
        }

        private bool ValuableContainerBlocked(Stack newstack)
        {
            bool blocked = false;
            List<int> indexes = new List<int>();
            foreach(Stack stack in Stacks)
            {
                int maxindex1 = stack.Containers.Count;
                int maxindex2 = newstack.Containers.Count;

                if (!Stacks.Any(c => maxindex1 <= maxindex2 && c.Containers[maxindex1].Sort == ContainerType.Valuable))
                {
                    blocked = true;
                }
                
            }
            return blocked;
        }
    }
}
