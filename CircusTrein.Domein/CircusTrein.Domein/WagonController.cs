using System;
using System.Collections.Generic;

namespace CircusTrein.Domein
{
    public class WagonController
    {
        private List<Animal> Carnivores = new List<Animal>();
        private List<Animal> Herbivores = new List<Animal>();

        public Train Train { get; private set; } = new Train();

        public void SplitAnimalList(List<Animal> animals)
        {
            foreach (Animal anim in animals)
            {
                if (anim.IsItACarnivore())
                {
                    Carnivores.Add(anim);
                }
                else if (!anim.IsItACarnivore())
                {
                    Herbivores.Add(anim);
                }
            }
        }

        public List<Animal> GetCarnivores()
        {
            return Carnivores;
        }

        public List<Animal> GetHerbivores()
        {
            return Herbivores;
        }

        public List<Wagon> FillAnimalInWagons(List<Animal> animals)
        {
            Train.ForceGetNewWagon(); 
            foreach (Animal anim in animals)
            {
                Train.GetCurrentWagon().AddAnimalToWagon(anim);
                Train.ForceGetNewWagon();
            }

            return Train.GetAllWagons();
        }
    }
}
