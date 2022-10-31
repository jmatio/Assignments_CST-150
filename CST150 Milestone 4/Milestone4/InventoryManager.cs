using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Milestone4
{
    internal class InventoryManager
    {
        //list to hold inventory items
        List<InventoryItem> list = new List<InventoryItem>();

        //method to add a new item
        public void AddItem()
        {

            //creates new item with user parameters
            InventoryItem item = new InventoryItem();

            //adds new item to list
            list.Add(item);

        }
    }
}
