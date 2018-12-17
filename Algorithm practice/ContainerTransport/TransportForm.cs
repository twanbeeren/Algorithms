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
        Factory factory;
        public TransportForm()
        {
            InitializeComponent();
        }
        private void TransportForm_Load(object sender, EventArgs e)
        {
            factory = new Factory();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Ship ship = factory.CreateShip((int)numericUpDownMax_weight.Value);
            factory.AddCooledContainers((int)numericUpDownCooled.Value);
            factory.AddNormalContainers((int)numericUpDownNormal.Value);
            factory.AddValuableContainers((int)numericUpDownValuable.Value);
            factory.OrderContainers();

            CheckWeight(ship);


            StackService stackService = new StackService(factory.containers);

            stackService.FillCooledStacks();
            List<Stack> stacks = stackService.FillNormalStacks();
            stackService.FillValuableStacks(stacks);

            foreach(Stack stack in stackService.Stacks)
            {
                CreateStacks(stack);
            }

            RowService rowService = new RowService(stackService.Stacks);
            rowService.DetermineRows();
            rowService.FillRows();

            Placer placer = new Placer(rowService.Rows);
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
            factory.containers.Clear();

            //List<Control> listControls = flpStacks.Controls.ToList();
            //foreach (Control cntrl in listControls)
            //{
            //    flpStacks.Controls.Remove(cntrl);
            //}
        }

        private void CheckWeight(Ship ship)
        {
            if (factory.containers.Sum(c => c.Weight) < ship.MinWeight)
            {
                MessageBox.Show("Het schip is te licht");
            }
        }
    }
}
