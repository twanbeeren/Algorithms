using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTransport
{
    public class RowService
    {
        public List<Stack> Stacks;
        public List<Row> Rows = new List<Row>();

        public RowService(List<Stack> stacks)
        {
            this.Stacks = stacks;
        }
        
        public List<Row> DetermineRows()
        {
            List<Stack> CooledStacks = Stacks.Where(s => s.Cooled == true).ToList();
            Row newrow = new Row();
            Rows.Add(newrow);
            bool StacksFilled = true;
            do
            {
                foreach(Row row in Rows)
                {
                    foreach (Stack stack in CooledStacks)
                    {
                        if (!row.ContainsCooledStack() && stack.Placed == false)
                        {
                            row.Fill(stack);
                        }
                    }
                }

                StacksFilled = CooledStacks.Any(s => s.Placed == false);
                if (StacksFilled)
                {
                    Row newRow = new Row();
                    Rows.Add(newRow);
                }
            } while (StacksFilled);
            
            return Rows;
        }

        public List<Row> FillRows()
        {
            do
            {
                Row minRow = Rows.OrderBy(r => r.Weight).First();
                minRow.LowestWeight = true;
                foreach (Row row in Rows)
                {
                    bool flag = false;
                    List<Stack> unPlacedStacks = Stacks.Where(s => s.Placed == false).ToList();

                    foreach (Stack stack in unPlacedStacks)
                    {
                        if (!stack.Placed && row.LowestWeight)
                        {
                            row.Fill(stack);
                            if (!CheckLightestRow(row))
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (flag) continue;
                }


            } while (Stacks.Any(s => s.Placed == false));

            Rows.OrderBy(r => r.Weight);
            return Rows;
        }

        
        private bool CheckLightestRow(Row row)
        {
            int minWeight = Rows.Min(r => r.Weight);
            if(minWeight == row.Weight)
            {
                Rows.All(r => r.LowestWeight = false);
                row.LowestWeight = true;
                return true;
            }
            else
            {
                row.LowestWeight = false;
                return false;
            }
        }
        
        
    }
}
