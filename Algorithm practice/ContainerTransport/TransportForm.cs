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
        Factory creator;
        public TransportForm()
        {
            InitializeComponent();
        }
        private void TransportForm_Load(object sender, EventArgs e)
        {
            services = new Service();
            creator = new Factory();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            creator.CreateShip((int)numericUpDownMax_weight.Value);
            creator.AddCooledContainers((int)numericUpDownCooled.Value);
            creator.AddNormalContainers((int)numericUpDownNormal.Value);
            creator.AddValuableContainers((int)numericUpDownValuable.Value);
        }
        
    }
}
