namespace CircusTrein.Domein
{
    public abstract class Animal
    {
        public int Size {  get; set; }
        public Boolean IsCarnivore { get; set; }

        public abstract int GetSize();
        public abstract Boolean IsItACarnivore();
    }
}
