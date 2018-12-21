    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerTransport
{
    public partial class TransportForm : Form
    {
        List<Container> containers = new List<Container>();
        List<Stack> stacks = new List<Stack>();
        List<Row> rows = new List<Row>();
        public TransportForm()
        {
            InitializeComponent();
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int shipWeight = (int)numericUpDownMax_weight.Value;
            int cooledCount = (int)numericUpDownCooled.Value;
            int normalCount = (int)numericUpDownNormal.Value;
            int valuableCount = (int)numericUpDownValuable.Value;


            Ship ship = Factory.CreateShip(shipWeight);
            containers = Factory.CreateContainers(cooledCount, normalCount, valuableCount);

            CheckWeight(ship);

            stacks = StackService.FillStacks(containers);

            foreach(Stack stack in stacks)
            {
                CreateStacks(stack);
            }
            
            RowService rowService = new RowService(stacks);
            rowService.DetermineRows();
            rowService.FillRows();

            Placer placer = new Placer(rows);
            placer.PlaceRows();

            textBoxWeightLeft.Text = Convert.ToString(placer.WeightLeft);
            textBoxWeightRight.Text = Convert.ToString(placer.WeightRight);
            labelDifference.Text = "Percentage: " + Math.Round(placer.Difference,2) + "%";
        }
        private void CreateStacks(Stack stack)
        {
            ListBox listBox = new ListBox
            {
                Left = 350,
                Top = 100,
                Height = 150,
                Width = 110
            };
            if (stack.Containers.Any(c => c.Sort == Type.Cooled))
            {
                listBox.BackColor = Color.AliceBlue;
            }
            else if(stack.Containers.All(c => c.Sort == Type.Valuable))
            {
                listBox.BackColor = Color.IndianRed;
            }
            flpStacks.Controls.Add(listBox);
            foreach (Container container in stack.Containers)
            {
                listBox.Items.Add(container.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            containers.Clear();

            //List<Control> listControls = flpStacks.Controls.ToList();
            //foreach (Control cntrl in listControls)
            //{
            //    flpStacks.Controls.Remove(cntrl);
            //}
        }

        private void CheckWeight(Ship ship)
        {
            if (containers.Sum(c => c.Weight) < ship.MinWeight)
            {
                MessageBox.Show("Het schip is te licht");
            }
        }
    }
}
