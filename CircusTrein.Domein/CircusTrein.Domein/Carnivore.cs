using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Domein
{
    public class Carnivore : Animal
    {
        private Boolean IsCarnivore { get; set; }
        private int Size { get; set; }
        public Carnivore(int size) 
        {
            this.IsCarnivore = true;
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
