using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    internal class InventoryItem
    {
        public string Name { get; set; }
        public int PartNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + ", " + PartNumber + ", " + Price + ", " + Quantity + ".";
        }
    }
}
