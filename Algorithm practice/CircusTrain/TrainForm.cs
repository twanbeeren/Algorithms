using CircusTrain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrain
{
    public partial class TrainForm : Form
    {
        Train train;
        Services services;
        public TrainForm()
        {
            InitializeComponent();
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            train = new Train();
            services = new Services();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (comboBoxDiet.Text != String.Empty && comboBoxSize.Text != String.Empty)
            {
                Diet diet = (Diet)Enum.Parse(typeof(Diet), comboBoxDiet.Text);
                Magnitude magnitude = (Magnitude)Enum.Parse(typeof(Magnitude), comboBoxSize.Text);
                Animal animal = services.MakeAnimal(diet, magnitude);
                train.Animals.Add(animal);

                listBoxAnimals.Items.Clear();
                foreach (Animal _animal in train.Animals)
                {
                    listBoxAnimals.Items.Add(_animal);
                }
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            train.Animals = services.MakeRandomAnimals();

            listBoxAnimals.Items.Clear();
            foreach (Animal animal in train.Animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            train.Animals.Clear();
            listBoxAnimals.Items.Clear();

        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

        
    }
}
