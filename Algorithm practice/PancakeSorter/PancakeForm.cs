using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PancakeSorter
{
    public partial class PancakeForm : Form
    {
        List<Pancake> pancakelist = new List<Pancake>();
        public PancakeForm()
        {
            InitializeComponent();
        }

        private void buttonSortPancakes_Click(object sender, EventArgs e)
        {
            pancakelist.Clear();
            listBoxpancakes.Items.Clear();
            MakePancakes();
            OrderPancakes();

            listBoxpancakes.Items.AddRange(pancakelist.ToArray());
            
        }

        private void MakePancakes()
        {
            int count = 0;
            while(count < numericUpDownCntPancakes.Value)
            {
                Pancake pancake = new Pancake();
                if (CheckPancakeSize(pancake))
                {
                    pancakelist.Add(pancake);
                    count++;
                }
            }
        }

        private void OrderPancakes()
        {
            pancakelist = pancakelist.OrderBy(x => x.Size).ToList();
        }

        private bool CheckPancakeSize(Pancake pancake)
        {
            List<Pancake> matches = pancakelist.Where(p => p.Size == pancake.Size).ToList();
            if(matches.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
