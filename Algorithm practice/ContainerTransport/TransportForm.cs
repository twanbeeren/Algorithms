using ContainerTransport.Classes;
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
        Service services;
        Factory factory;
        public TransportForm()
        {
            InitializeComponent();
        }
        private void TransportForm_Load(object sender, EventArgs e)
        {
            services = new Service();
            factory = new Factory(services);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            factory.CreateShip((int)numericUpDownMax_weight.Value);
            factory.AddCooledContainers((int)numericUpDownCooled.Value);
            factory.AddNormalContainers((int)numericUpDownNormal.Value);
            factory.AddValuableContainers((int)numericUpDownValuable.Value);

            services.FillCooledStacks();
            List<Stack> stacks = services.FillNormalStacks();
            services.FillValuableStacks(stacks);

            foreach(Stack stack in services.Stacks)
            {
                CreateListBox(stack);
            }
            
        }
        private void CreateListBox(Stack stack)
        {
            ListBox listBox = new ListBox();
            listBox.Left = 350;
            listBox.Top = 100;
            listBox.Height = 150;
            listBox.Width = 110;
            flpStacks.Controls.Add(listBox);
            foreach (Container container in stack.Containers)
            {
                listBox.Items.Add(container.ToString());
            }
        }

    }
}
