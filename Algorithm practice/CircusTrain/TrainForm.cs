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
        List<Animal> animals = new List<Animal>();
        Train train;
        
        
        public TrainForm()
        {
            InitializeComponent();
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {
            train = new Train();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (comboBoxDiet.Text != String.Empty && comboBoxSize.Text != String.Empty)
            {
                Diet diet = (Diet)Enum.Parse(typeof(Diet), comboBoxDiet.Text);
                Magnitude magnitude = (Magnitude)Enum.Parse(typeof(Magnitude), comboBoxSize.Text);

                Animal animal = AnimalFactory.MakeAnimal(diet, magnitude);
                animals.Add(animal);
                animals.OrderBy(x => x.Magnitude == Magnitude.Large);

                listBoxAnimals.Items.Clear();
                foreach (Animal _animal in animals)
                {
                    listBoxAnimals.Items.Add(_animal);
                }
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            animals = AnimalFactory.MakeRandomAnimals();
            listBoxAnimals.Items.Clear();
            foreach (Animal animal in animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            animals.Clear();
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
            Services.FillTrain(train, animals);

            foreach(Wagon _wagon in train.Wagons)
            {
                CreateListBox(_wagon);
            }
        }
        
    }
}
