using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class Row
    {
        List<Stack> RowContainers = new List<Stack>();
        
        public void fillRow(IEnumerable<Stack> stacks)
        {
            foreach(Stack stack in stacks)
            {
                if (!stack.Placed)
                {
                    RowContainers.Add(stack);
                    stack.Placed = true;
                }
            }
        }
        
        
    }
}
