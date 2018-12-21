using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    internal static class StackService
    {
       
        internal static List<Stack> FillStacks(List<Container> containers)
        {
            List<Stack> stacks = new List<Stack>();
            stacks.AddRange(FillCooledStacks(stacks, containers));
            stacks.AddRange(FillValuableStacks(FillNormalStacks(containers), stacks, containers));
            return stacks;
        }
        private static List<Stack> FillCooledStacks(List<Stack> stacks, List<Container> containers)
        {
            List<Container> CooledContainers = containers.Where(c => c.Sort == Type.Cooled).ToList();
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
            stacks.AddRange(CooledStacks);
            return CooledStacks;
        }

        private static List<Stack> FillNormalStacks(List<Container> containers)
        {
            List<Container> NormalContainers = containers.Where(c => c.Sort == Type.Normal).ToList();
            List<Stack> NormalStacks = new List<Stack>();
            Stack NewStack = new Stack();
            NormalStacks.Add(NewStack);
            bool NormalFilled = true;
            do
            {
                foreach (Stack stack in NormalStacks)
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
        private static List<Stack> FillValuableStacks(List<Stack> normalStacks, List<Stack> stacks, List<Container> containers)
        {
            bool ValFilled = true;
            List<Container> ValContainers = containers.Where(c => c.Sort == Type.Valuable).ToList();
            do
            {
                foreach (Stack stack in normalStacks)
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

            stacks.AddRange(stacks);
            return stacks;
        }

        
    }
}
