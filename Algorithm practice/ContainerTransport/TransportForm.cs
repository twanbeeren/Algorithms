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
        Service services = new Service();
        public TransportForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            makeShip();
            addCooledContainers();
            addValuableContainers();
            addNormalContainers();

        }

        private void makeShip()
        {
            Ship ship = new Ship((int)numericUpDownMax_weight.Value);
        }

        private void addCooledContainers()
        {
            int counter = 0;
            while(counter < numericUpDownCooled.Value)
            {
                Container CooledContainer = new Container(ContainerType.Cooled);
                services.totalcontainers.Add(CooledContainer);
            }
        }
        private void addValuableContainers()
        {
            int counter = 0;
            while (counter < numericUpDownCooled.Value)
            {
                Container NormalContainer = new Container(ContainerType.Valuable);
                services.totalcontainers.Add(NormalContainer);
            }
        }
        private void addNormalContainers()
        {
            int counter = 0;
            while (counter < numericUpDownCooled.Value)
            {
                Container ValuebaleContainer = new Container(ContainerType.Normal);
                services.totalcontainers.Add(ValuebaleContainer);
            }
        }
    }
}
