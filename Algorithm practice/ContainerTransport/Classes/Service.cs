using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    internal class Service
    {
        public List<Container> totalcontainers = new List<Container>();
        private List<Stack> stacks = new List<Stack>();

        private void AddContainerToStack(Stack stack, Container container)
        {
            container.Placed = true;
            stack.Containers.Add(container);
            stack.Weight += container.Weight;
        }

        public List<Stack> FillCooledStacks()
        {
            List<Container> CooledContainers = totalcontainers.Where(c => c.Sort == ContainerType.Cooled).ToList();

            List<Stack> CooledStacks = new List<Stack>();
            Stack cooledStack = new Stack();
            foreach(Container container in CooledContainers)
            {
                if (cooledStack.CheckWeight(container))
                {
                    AddContainerToStack(cooledStack, container);
                }
                else
                {
                    CooledStacks.Add(cooledStack);
                    cooledStack = new Stack();
                }
            }
            stacks.AddRange(CooledStacks);
            return CooledStacks;
        }
    }
}
