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
        public List<Stack> Stacks = new List<Stack>();

        
        public List<Stack> FillCooledStacks()
        {
            List<Container> CooledContainers = totalcontainers.Where(c => c.Sort == ContainerType.Cooled).ToList();
            List<Stack> CooledStacks = new List<Stack>();
            Stack cooledStack = new Stack();
            CooledStacks.Add(cooledStack);

            bool cont = true;
            do
            {
                foreach (Stack stack in CooledStacks)
                {
                    foreach (Container container in CooledContainers)
                    {
                        if (cooledStack.CheckWeight(container) && container.Placed == false)
                        {
                            cooledStack.Fill(container);
                        }
                    }
                }
                cont = CooledContainers.Any(item => item.Placed == false);
                if (cont)
                {
                    cooledStack = new Stack();
                    CooledStacks.Add(cooledStack);
                }
            } while (cont);
            Stacks.AddRange(CooledStacks);
            return CooledStacks;
        }

        public List<Stack> FillNormalStacks()
        {
            List<Container> NormalContainers = totalcontainers.Where(c => c.Sort == ContainerType.Normal).ToList();
            List<Stack> NormalStacks = new List<Stack>();
            Stack NewStack = new Stack();
            NormalStacks.Add(NewStack);
            bool NormalFilled = true;
            do
            {
                foreach(Stack stack in NormalStacks)
                {
                    foreach (Container container in NormalContainers)
                    {
                        if (stack.CheckWeight(container) && stack.RoomForValuableContainer(container) && container.Placed == false)
                        {
                            stack.Fill(container);
                        }
                    }
                }
                NormalFilled = NormalContainers.Any(item => item.Placed == false);
                if (NormalFilled)
                {
                    NewStack = new Stack();
                    NormalStacks.Add(NewStack);
                }
            } while (NormalFilled);
                
            return NormalStacks;
        }
        public List<Stack> FillValuableStacks(List<Stack> stacks)
        {
            bool ValFilled = true;
            List<Container> ValContainers = totalcontainers.Where(c => c.Sort == ContainerType.Valuable).ToList();
            do
            {
                foreach (Stack stack in stacks)
                {
                    foreach (Container container in ValContainers)
                    {
                        if (stack.CheckWeight(container) && !stack.ContainsValuableContainer() && container.Placed == false)
                        {
                            stack.Fill(container);
                        }
                    }
                }

                ValFilled = ValContainers.Any(item => item.Placed == false);
                if (ValFilled)
                {
                    Stack NewStack = new Stack();
                    stacks.Add(NewStack);
                }
            } while (ValFilled);

            Stacks.AddRange(stacks);
            return stacks;
        }
    }
}
