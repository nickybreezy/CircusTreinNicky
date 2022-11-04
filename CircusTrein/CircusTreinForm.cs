using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CircusTrein.AnimalType;
using CircusTrein.Properties;

namespace CircusTrein
{
    public partial class CircusTrein : Form
    {
        // Animal dier;
        Wagon wagon;
        Trein trein;
        List<Animal> animals;
        public CircusTrein()
        {
            InitializeComponent();
            animals = new List<Animal>();
            wagon = new Wagon();
            trein = new Trein();
            pbTrein.Image = Resources.train_journey;
            updateAnimalUI();
        }

        private void btnVoegWagon_Click(object sender, EventArgs e)
        {
            bool Carnivoor;
            if (cbED.Checked)
            {
                Carnivoor = true;
            }
            else
                Carnivoor = false;
            AnimalType selectedAnimalType = AnimalType.groot; 
            if (rbKlein.Checked)
            {
                selectedAnimalType = AnimalType.klein;
            }
            else if (rbMG.Checked)
            {
                selectedAnimalType = AnimalType.middelgroot;
            }

            else if (rbGroot.Checked)
            {
                selectedAnimalType = AnimalType.groot;
            }
            else
            {
                MessageBox.Show("aub selecteer");
            }

         // wagon.AddDier(new Animal(Carnivoor, AnimalType.klein));
            animals.Add(new Animal(Carnivoor, selectedAnimalType));
            updateAnimalUI();
        }

        private void updateAnimalUI()
        {
            lbWagon.Items.Clear();
            foreach (Animal animal in animals)
            {
                lbWagon.Items.Add(animal.GetInfo());
            }

        }
        private void updateWagonUI()
        {
            lbCircus.Items.Clear();
            foreach (var wagon in trein.GetWagons())
            {
                lbCircus.Items.Add("wagon bezit " + wagon.GetPoints() + " punten");

            }
            tbWagon.Text = trein.ToString();
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            trein.SorteerEnToevoegenAanWagons(animals);
            animals.Clear();
            updateWagonUI();
            updateAnimalUI();
        }

        private void CircusTrein_Load(object sender, EventArgs e)
        {
            /*animals.Add(new Animal(false, groot));
            animals.Add(new Animal(true, klein));

            animals.Add(new Animal(true, middelgroot));
            animals.Add(new Animal(false, middelgroot));
            animals.Add(new Animal(true, groot));*/
            animals.Add(new Animal(false, middelgroot));
            animals.Add(new Animal(false, middelgroot));
            animals.Add(new Animal(false, middelgroot));
            animals.Add(new Animal(true, klein));
            animals.Add(new Animal(true, middelgroot));
            animals.Add(new Animal(true, klein));

            updateAnimalUI();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            lbCircus.Visible = true;
        }
    }
}
