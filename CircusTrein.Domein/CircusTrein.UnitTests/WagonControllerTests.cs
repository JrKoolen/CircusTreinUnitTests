using CircusTrein.Domein;
using NUnit.Framework;
using System.Collections.Generic;

namespace CircusTrein.UnitTests
{
    [TestFixture]
    public class WagonControllerTests
    {
        private WagonController _wagonController = new WagonController();
        List<Animal> case1 = new()
        {
            new Animal(1, true),
            new Animal(3, false),
            new Animal(3, false),
            new Animal(3, false),
        };

        List<Animal> case2 = new()
        {
            new Animal(5, true),
            new Animal(3, false),
            new Animal(3, false),
            new Animal(3, false),
        };

        List<Animal> case3 = new()
        {
            new Animal(5, true),
            new Animal(5, true),
            new Animal(5, true),
            new Animal(3, false),
        };

        List<Animal> case4 = new()
        {
            new Animal(5, false),
            new Animal(5, false),
        };


        [Test]
        public void GivenAnimals_CreateCorrectOfWagons_Case1()
        {
            //arrange
            List<Wagon> wagonList = _wagonController.DistributeAnimals(case1);

            //Assert
            Assert.That(wagonList.Count, Is.EqualTo(1));
            Assert.That(wagonList.First().CurrentSize, Is.EqualTo(10));
        }

        [Test]
        public void GivenAnimals_CreateCorrectOfWagons_Case2()
        {
            //arrange
            List<Wagon> wagonList = _wagonController.DistributeAnimals(case2);

            //Assert
            Assert.That(wagonList.Count, Is.EqualTo(2));
            Assert.That(wagonList.First().CurrentSize, Is.EqualTo(5));
        }
        [Test]
        public void GivenAnimals_CreateCorrectOfWagons_Case3()
        {
            //arrange
            List<Wagon> wagonList = _wagonController.DistributeAnimals(case3);

            //Assert
            Assert.That(wagonList.Count, Is.EqualTo(4));
            Assert.That(wagonList.First().CurrentSize, Is.EqualTo(5));
        }

        [Test]
        public void GivenAnimals_CreateCorrectOfWagonsWhenOnlyHerbivores()
        {
            //arrange
            List<Wagon> wagonList = _wagonController.DistributeAnimals(case4);

            //Assert
            Assert.That(wagonList.Count, Is.EqualTo(1));
            Assert.That(wagonList.First().CurrentSize, Is.EqualTo(10));
        }

        [Test]
        public void GivenAnimals_CreateMultiplefWagonsWhenOnlyHerbivores()
        {
            //act
            case4.Add(new Animal(1, false));
            //arrange
            List<Wagon> wagonList = _wagonController.DistributeAnimals(case4);
            

            //Assert
            Assert.That(wagonList.Count, Is.EqualTo(1));
            Assert.That(wagonList.First().CurrentSize, Is.EqualTo(10));
        }
    }
}
