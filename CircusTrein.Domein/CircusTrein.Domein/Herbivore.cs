using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Domein
{
    public class Herbivore : Animal
    {
        private Boolean IsCarnivore { get; set; }
        private int Size { get; set; }
        public Herbivore(int size)
        {
            this.IsCarnivore = false;
            this.Size = size;
        }

        public override int GetSize()
        {
            return Size;
        }

        public override bool IsItACarnivore()
        {
            return IsCarnivore;
        }
    }
}
