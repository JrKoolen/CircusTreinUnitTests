using CircusTrein.Domein;
using NUnit.Framework;

namespace CircusTrein.UnitTests
{
    [TestFixture]
    public class TrainTests
    {

        [Test]
        public void GetNewWagon_NoCarnivoreInCurrentWagon_ReturnsSameWagon()
        {
            //Arrange
            Train train = new Train();
            Wagon currentWagon = new Wagon();
            train.CurrentWagon = currentWagon;

            //Act
            Wagon result = train.GetNewWagon(currentWagon);

            //Assert
            Assert.AreEqual(currentWagon, result);
        }

        //[Test]
        //public void GetNewWagon_CarnivoreInCurrentWagon_AddsNewWagon()
        //{
        //    //Arrange
        //    Train train = new Train();
        //    Wagon currentWagon = new Wagon();
        //    currentWagon.AddAnimalToWagon(new Carnivore(5));
        //    train.CurrentWagon = currentWagon;

        //    //Act
        //    Wagon result = train.GetNewWagon(currentWagon);

        //    //Assert
        //    Assert.AreNotEqual(currentWagon, result);
        //    Assert.AreEqual(1, train.GetAllWagons().Count);
        //}

        [Test]
        public void ForceGetNewWagon_AddsNewWagon()
        {
            //Arrange
            Train train = new Train();
            Wagon currentWagon = new Wagon();
            train.CurrentWagon = currentWagon;

            //Act
            train.ForceGetNewWagon();
            Wagon newWagon = train.GetCurrentWagon();

            //Assert
            Assert.AreNotEqual(currentWagon, newWagon);
            Assert.AreEqual(1, train.GetAllWagons().Count);
        }

        [Test]
        public void GetCurrentWagon_ReturnsCurrentWagon()
        {
            //Arrange
            Train train = new Train();
            Wagon currentWagon = new Wagon();
            train.CurrentWagon = currentWagon;

            //Act
            Wagon result = train.GetCurrentWagon();

            //Assert
            Assert.AreEqual(currentWagon, result);
        }

        [Test]
        public void GetAllWagons_ReturnsAllWagons()
        {
            //Arrange
            Train train = new Train();
            Wagon firstWagon = new Wagon();
            Wagon secondWagon = new Wagon();
            train.Wagons.Add(firstWagon);
            train.Wagons.Add(secondWagon);

            //Act
            List<Wagon> result = train.GetAllWagons();

            //Assert
            Assert.Contains(firstWagon, result);
            Assert.Contains(secondWagon, result);
            Assert.AreEqual(2, result.Count);
        }
    }
}