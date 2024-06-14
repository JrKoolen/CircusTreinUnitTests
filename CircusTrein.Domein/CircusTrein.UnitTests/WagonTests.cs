using CircusTrein.Domein;
using NUnit.Framework;

namespace CircusTrein.UnitTests
{
    [TestFixture]
    public class WagonTests
    {
        [Test]
        public void GetCurrentWagonSize_EmptyWagon_ReturnsZero()
        {
            //Arrange
            Wagon wagon = new Wagon();

            //Act
            int currentSize = wagon.GetCurrentWagonSize();

            //Assert
            Assert.AreEqual(0, currentSize);
        }

        [Test]
        public void GetCurrentWagonSize_WagonWithAnimals_ReturnsCorrectSize()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Herbivore(3));
            wagon.AddAnimalToWagon(new Herbivore(1));

            //Act
            int currentSize = wagon.GetCurrentWagonSize();

            //Assert
            Assert.AreEqual(4, currentSize);
        }

        [Test]
        public void DoesTheAnimalFit_AnimalFits_ReturnsTrue()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Herbivore(3));
            Animal newAnimal = new Herbivore(5);

            //Act
            bool doesFit = wagon.DoesTheAnimalFit(newAnimal);

            //Assert
            Assert.IsTrue(doesFit);
        }

        [Test]
        public void DoesTheAnimalFit_AnimalDoesNotFit_ReturnsFalse()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Herbivore(5));
            Herbivore newAnimal = new Herbivore(5);

            //Act
            bool doesNotFit = wagon.DoesTheAnimalFit(newAnimal);

            //Assert
            Assert.IsFalse(doesNotFit);
        }

        [Test]
        public void Compatible_NoCarnivores_ReturnsTrue()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Herbivore(3));
            Herbivore newAnimal = new Herbivore(1);

            //Act
            bool isCompatible = wagon.Compatible(newAnimal);

            //Assert
            Assert.IsTrue(isCompatible);
        }

        [Test]
        public void Compatible_CarnivoreInWagon_ReturnsFalse()
        {
            //Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(new Carnivore(5));
            Herbivore newAnimal = new Herbivore(3);

            //Act
            bool isCompatible = wagon.Compatible(newAnimal);

            //Assert
            Assert.IsFalse(isCompatible);
        }

        [Test]
        public void AddAnimalToWagon_AnimalAdded_WagonContainsAnimal()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Herbivore newAnimal = new Herbivore(3);

            //Act
            wagon.AddAnimalToWagon(newAnimal);

            //Assert
            Assert.AreEqual(1, wagon.AmountOfAnimalsInWagon());
            Assert.IsTrue(wagon.GetCurrentWagonSize() == 3);
        }
    }
}
