using CircusTrein;
using System.Drawing;

namespace CircusTrein.Tests
{
  
    public class CircusTreinTests
    {
        [Fact]
        public void Dier_Is_Groter_En_Eet_Dieren()
        {
            List<Animal> animals = new List<Animal>();
            //Arrange
            Trein trein = new Trein();
            Animal GrootDierEtendDier = new Animal(Eetdieren: true, AnimalType.groot);
            Animal KleinDierNietEtendDier = new Animal(Eetdieren: false, AnimalType.klein);
            animals.Add(GrootDierEtendDier);
            animals.Add(KleinDierNietEtendDier);


            //Act
            trein.SorteerEnToevoegenAanWagons(animals);


            //Assert
            Assert.Equal(2, trein.GetWagons().Count);
        }

        [Fact]
        public void Is_Wagon_Maat_Goed()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddDier(new Animal(Eetdieren: true, AnimalType.groot));
            wagon.AddDier(new Animal(Eetdieren: true, AnimalType.groot));
            Animal grootPlantDier = new Animal(Eetdieren: false, AnimalType.groot);

            //Act
            var check = wagon.KanDierToegevoegdWorden(grootPlantDier);

            //Assert
            Assert.True(check);
        }

        [Fact]
        public void Test_10PointsInWagon()
        {
            Wagon wagon = new Wagon();
            wagon.AddDier(new Animal(Eetdieren: false, AnimalType.middelgroot));
            wagon.AddDier(new Animal(Eetdieren: false, AnimalType.middelgroot));
            wagon.AddDier(new Animal(Eetdieren: false, AnimalType.middelgroot));
            wagon.AddDier(new Animal(Eetdieren: true, AnimalType.klein));
            
            int punten = wagon.GetPoints();

            Assert.Equal(10, punten);
        }

        [Fact]
        public void Wagon_Mag_Niet_Over_Limiet()
        {
            Wagon wagon = new Wagon();
            wagon.AddDier(new Animal(Eetdieren: false, AnimalType.groot));
            wagon.AddDier(new Animal(Eetdieren: false, AnimalType.groot));
            bool resultaat = wagon.KanDierToegevoegdWorden(new Animal(Eetdieren: true, animalType: AnimalType.groot));

            Assert.False(resultaat);
        }

        [Fact]
        public void ThrowsException_Als_Dier_Niet_Past()
        {
            Wagon wagon = new Wagon();
            wagon.AddDier(new Animal(Eetdieren: true, AnimalType.groot));
            bool vangen = false;
            try
            {
                wagon.AddDier(new Animal(Eetdieren: false, AnimalType.klein));
            }
            catch (Exception e)
            {
                vangen = true;
            }
            Assert.False(vangen);
        }



    }
}