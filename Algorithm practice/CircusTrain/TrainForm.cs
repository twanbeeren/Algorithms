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
        Creator creator;
        public TrainForm()
        {
            InitializeComponent();
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            train = new Train();
            services = new Services();
            creator = new Creator();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (comboBoxDiet.Text != String.Empty && comboBoxSize.Text != String.Empty)
            {
                Diet diet = (Diet)Enum.Parse(typeof(Diet), comboBoxDiet.Text);
                Magnitude magnitude = (Magnitude)Enum.Parse(typeof(Magnitude), comboBoxSize.Text);
                Animal animal = creator.MakeAnimal(diet, magnitude);
                services.Animals.Add(animal);

                listBoxAnimals.Items.Clear();
                foreach (Animal _animal in services.Animals)
                {
                    listBoxAnimals.Items.Add(_animal);
                }
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            services.Animals = creator.MakeRandomAnimals();
            listBoxAnimals.Items.Clear();
            foreach (Animal animal in services.Animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            services.Animals.Clear();
            train.Wagons.Clear();
            listBoxAnimals.Items.Clear();
            flpWagons.Controls.Clear();
        }
        private void CreateListBox(Wagon wagon)
        {
            ListBox listBox = new ListBox();
            listBox.Left = 350;
            listBox.Top = 100;
            listBox.Height = 150;
            listBox.Width = 100;
            flpWagons.Controls.Add(listBox);
            foreach (Animal animal in wagon.Animals)
            {
                listBox.Items.Add(animal.ToString());
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            List<Wagon> wagons = new List<Wagon>();

            wagons.AddRange(services.FillWagons());
            services.FillTrain(train, wagons);

            foreach(Wagon _wagon in train.Wagons)
            {
                CreateListBox(_wagon);
            }
        }
        
    }
}
