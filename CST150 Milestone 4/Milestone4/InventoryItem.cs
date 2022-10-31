using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4
{
    //defines the InventoryItem class
    internal class InventoryItem
    {
        //sets variables with getters and setters
        public string Name { get; set; }
        public string Department { get; set; }
        public int PartNumber { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }



        //method to convert all outputs to string and orders them how they will appear in list box
        public override string ToString()
        {
            return Name + ", " + Department + ", " + PartNumber + ", " + Price + ", " + Qty + ".";
        }
    }
}
