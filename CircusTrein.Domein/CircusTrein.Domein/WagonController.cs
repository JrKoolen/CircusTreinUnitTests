using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace CircusTrein.Domein
{
    public class WagonController
    {
        public WagonController() { }

        public List<Wagon> DistributeAnimals(List<Animal> Animals)
        {
            List<Wagon> Wagons = new List<Wagon>();

            // PUT ALL CARNIVORES IN THEIR OWN WAGON
            Console.WriteLine("Distributing carnivores");
            foreach (var animal in Animals.ToList())  
            {
                if (animal.IsCarnivore)
                {
                    Console.WriteLine("Found Carnivore");
                    Wagon wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    Wagons.Add(wagon);
                    Animals.Remove(animal);
                }
            }

            // IF THERE WHERE NO CARNIVORES CREATE A DEFEAULT WAGON
            if (Wagons.Count == 0)
            {
                Console.WriteLine("There was no existing wagon");
                Wagons.Add(new Wagon());
            }

            // PUT THE REMAINING HERBIVORES IN THE WAGONS
            bool animalsAddedToWagons = true;
            Wagons.Sort((wagon1, wagon2) => wagon2.CarnivoreSize.CompareTo(wagon1.CarnivoreSize));

            while (Animals.Count > 0)
            {
                animalsAddedToWagons = false;  

                foreach (var wagon in Wagons.ToList())  
                {
                    Console.WriteLine($"animal count: {Animals.Count}, wagon count {Wagons.Count}");
                    if (!wagon.IsFull)
                    {
                        Console.WriteLine($"wagon is not full, Checking for animals with size > {wagon.CarnivoreSize}");
                        var animalToAdd = Animals.Where(animal => animal.Size > wagon.CarnivoreSize).FirstOrDefault();
                        if (animalToAdd != null)
                        {
                            Console.WriteLine($"Found animal: {animalToAdd.Size}, wagon size {wagon.CurrentSize}");
                            wagon.AddAnimal(animalToAdd);
                            Animals.Remove(animalToAdd);
                        }
                        else if (animalToAdd == null)
                        {
                            var Herbivores = Animals.Where(animal => !animal.IsCarnivore).FirstOrDefault();
                            var CompatibleWagon = Wagons.Where(wagon => wagon.CarnivoreSize == 0).FirstOrDefault();
                            if(CompatibleWagon == null)
                            {
                                Wagons.Add(new Wagon());
                            }
                        }
                    }
                }
            }
            return Wagons;
        }

    }
}
