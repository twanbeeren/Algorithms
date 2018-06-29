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
    public partial class Form1 : Form
    {
        List<Pancake> pancakelist = new List<Pancake>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSortPancakes_Click(object sender, EventArgs e)
        {
            pancakelist.Clear();
            listBoxpancakes.Items.Clear();
            MakePancakes();
            OrderPancakes();

            //following foreach loop could get an own method, but for this time chose otherwise because it is a short method
            foreach (Pancake pancake in pancakelist)
            {
                listBoxpancakes.Items.Add(pancake.ToString());
            }
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
