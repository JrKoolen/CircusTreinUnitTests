using CircusTrein.Domein;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class WagonTests
{
    private List<Animal> animals;
    private List<Wagon> wagons;
    private const int Capacity = 10; 

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void AddAnimalsToWagons_Success()
    {
        //act 
        Wagon wagon = new Wagon();
        Animal animal = new Animal(5, true);

        //arrange
        wagon.AddAnimal(animal);

        //assert
        Assert.That(wagon.Animals.Count, Is.EqualTo(1));
    }

    [Test]
    public void AddAnimalsToWagons_FullWagons()
    {
        //act 
        Wagon wagon = new Wagon();
        Animal animal1 = new Animal(3, false);
        Animal animal2 = new Animal(5, true);
        Animal animal3 = new Animal(5, true);

        //arrange
        wagon.AddAnimal(animal1);
        wagon.AddAnimal(animal2);
        wagon.AddAnimal(animal3);

        //assert
        Assert.That(wagon.Animals.Count, Is.EqualTo(2));

    }

    [Test]
    public void AnimalsInWagon_ReturnCorrectCurrentSize()
    {
        //act
        Wagon wagon = new Wagon();
        Animal animal1 = new Animal(3, false);
        Animal animal2 = new Animal(5, true);

        //arrange
        wagon.AddAnimal(animal1);
        wagon.AddAnimal(animal2);

        //assert 
        Assert.That(wagon.CurrentSize, Is.EqualTo(8));
    }
}
