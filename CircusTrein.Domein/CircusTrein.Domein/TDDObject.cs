namespace CircusTrein.Domein
{
    public class TDDObject
    {
        public int TotalAmount { get; set; }
        public string Name = "Object";

        public TDDObject(int totalAmount) 
        {
            TotalAmount = totalAmount;
        }

        public Boolean IsItAboveTotalAmount(int i)
        {
            TotalAmount += i;
            if (i < TotalAmount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int ResetAmount() 
        {
            TotalAmount = 0;
            return TotalAmount; 
        }

        public Boolean IsItAboveForAll(List<TDDObject> list, int amount)
        {
            bool result;
            foreach (TDDObject obj in list)
            {
                result = obj.IsItAboveTotalAmount(amount);
                if (result)
                {
                    return false ;
                }
            }
            return true;
        }
    }
}
