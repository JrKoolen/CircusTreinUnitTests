using CircusTrein.Domein;
using NUnit.Framework;
using System.Collections.Generic;

namespace CircusTrein.UnitTests
{
    [TestFixture]
    public class WagonControllerTests
    {
        private WagonController _wagonController;
        private List<Animal> _animals;

        [SetUp]
        public void Setup()
        {
            _wagonController = new WagonController();
            _animals = new List<Animal>
            {
                new Herbivore(3),
                new Herbivore(3),
                new Carnivore(5),
                new Herbivore(1),
                new Carnivore(5)
            };
        }

        [Test]
        public void SplitAnimalList_AnimalsSplitCorrectly()
        {
            // Act
            _wagonController.SplitAnimalList(_animals);

            // Assert
            List<Animal> carnivores = _wagonController.GetCarnivores();
            List<Animal> herbivores = _wagonController.GetHerbivores();


            Assert.AreEqual(3, herbivores.Count);
            Assert.AreEqual(2, carnivores.Count);
        }
    }
}
