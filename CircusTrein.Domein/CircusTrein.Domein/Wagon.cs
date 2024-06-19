using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CircusTrein.Domein
{
    public class Wagon
    {
        private readonly int Capacity = 10;
        public List<Animal> Animals { get; private set; } = new List<Animal>();
        public int CurrentSize => Animals.Sum(Animals => Animals.Size);
        public bool IsFull => CurrentSize > Capacity;

        public int CarnivoreSize => Animals.Where(animal => animal.IsCarnivore).Sum(animal => animal.Size);

        public bool AddAnimal(Animal animal)
        {
            if (animal != null && CurrentSize + animal.Size <= Capacity)
            {
                Animals.Add(animal);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
