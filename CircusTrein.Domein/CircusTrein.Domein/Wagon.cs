using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Domein
{
    public class Wagon
    {
        private int MaxSize = 10;
        private List<Animal> animals = new List<Animal>();
        private int CurrentSize = 0;
        private Boolean IsFull {  get; set; }

        public Wagon() { }

        public int GetCurrentWagonSize()
        {
            return CurrentSize;
        }

        public Boolean DoesTheAnimalFit(Animal animal)
        {
            int currentSize = GetCurrentWagonSize();
            currentSize += animal.GetSize();
            if (currentSize < MaxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Compatible(Animal animal)
        {
            foreach (Animal anim in animals)
            {
                if(anim.IsCarnivore)
                {
                    if(anim.GetSize() < animal.GetSize())
                    {
                        return true;
                    }
                }
            }

            foreach (Animal anim in animals)
            {
                if (!anim.IsCarnivore)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            CurrentSize += animal.GetSize();
            
        }

        public int AmountOfAnimalsInWagon()
        {
            int count = 0;
            foreach (var item in animals)
            {
                count++;  
            }
            return count;
        }

        public int ContainsCarnivore()
        {
            foreach (var item in animals)
            {
                if (item.IsCarnivore)
                {
                    return item.GetSize();
                }
            }
            return 0;
        }
    }
}
