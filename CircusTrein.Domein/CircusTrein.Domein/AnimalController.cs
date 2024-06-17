namespace CircusTrein.Domein
{
    public class AnimalController
    {
        private List<Animal> animals;

        public AnimalController()
        {
            animals = new List<Animal>(); 
        }

        public List<Animal> CreateAnimal(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3);
                if (randomNumber == 1)
                {
                    randomNumber = random.Next(1, 4);
                    if (randomNumber == 1)
                    {
                        Carnivore carnivore = new Carnivore(5);
                        animals.Add(carnivore);
                    }
                    else if (randomNumber == 2)
                    {
                        Carnivore carnivore = new Carnivore(3);
                        animals.Add(carnivore);
                    }
                    else if (randomNumber == 3)
                    {
                        Carnivore carnivore = new Carnivore(1);
                        animals.Add(carnivore);
                    }
                }
                else
                {
                    randomNumber = random.Next(1, 4);
                    if (randomNumber == 1)
                    {
                        Herbivore herbivore = new Herbivore(5);
                        animals.Add(herbivore);
                    }
                    else if (randomNumber == 2)
                    {
                        Herbivore herbivore = new Herbivore(3);
                        animals.Add(herbivore);
                    }
                    else if (randomNumber == 3)
                    {
                        Herbivore herbivore = new Herbivore(1);
                        animals.Add(herbivore);
                    }
                }
            }
            return animals;
        }
    }

}


