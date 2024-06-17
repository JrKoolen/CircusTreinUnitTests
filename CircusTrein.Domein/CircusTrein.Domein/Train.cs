namespace CircusTrein.Domein
{
    public class Train
    {
        public List<Wagon> Wagons = new();
        public Wagon CurrentWagon;

        public Wagon GetNewWagon(Wagon wagon)
        {
            int result = wagon.ContainsCarnivore();
            int currentsize = wagon.GetCurrentWagonSize();
            if (result == 0)
            {
                return wagon;
            }
            else if (result == 5 || result == 3 && currentsize == 8) 
            {
                Wagons.Add(CurrentWagon);
                Wagon newWagon = new Wagon();
                CurrentWagon = newWagon;
                return newWagon;
            }
            return CurrentWagon;
        }

        public void ForceGetNewWagon() 
        { 
            Wagons.Add (CurrentWagon);
            Wagon newWagon = new Wagon();
            CurrentWagon = newWagon;
        }  

        public Wagon GetCurrentWagon() 
        {
            return CurrentWagon;
        }

        public List<Wagon> GetAllWagons() 
        {
            return Wagons;
        }
    }
}
