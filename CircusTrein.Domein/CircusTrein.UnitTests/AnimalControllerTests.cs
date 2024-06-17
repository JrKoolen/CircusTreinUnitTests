using CircusTrein.Domein;
using NUnit.Framework;
using System.Collections.Generic;

namespace CircusTrein.UnitTests
{
    //coverlet .\CircusTrein.UnitTests.dll --target "dotnet" --targetargs "test"
    public class Tests
    {
        private AnimalController _animalFactory;

        [SetUp]
        public void Setup()
        {
            _animalFactory = new AnimalController();
        }

        [Test]
        public void CreateAnimal_ShouldReturnCorrectNumberOfAnimals()
        {
            //arrange
            int amount = 10;

            //act
            List<Animal> animals = _animalFactory.CreateAnimal(amount);

            //assert
            Assert.AreEqual(amount, animals.Count);
        }

        [Test]
        public void CreateAnimal_ShouldCreateCarnivoresAndHerbivores()
        {

            int amount = 100;

            //act
            List<Animal> animals = _animalFactory.CreateAnimal(amount);

            //assert
            foreach (var animal in animals)
            {
                Assert.IsTrue(animal is Carnivore || animal is Herbivore);
            }
        }
    }
}