using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //method that will execute when add button is clicked
        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //implements the InventoryItem class and creates a new object
                InventoryItem item = new InventoryItem();

                //sets values to object from user input
                item.Name = nameTextBox.Text;
                item.Department = departmentTextBox.Text;
                item.PartNumber = Convert.ToInt32(partNumberTextBox.Text);
                item.Price = Convert.ToDecimal(priceTextBox.Text);
                item.Quantity = Convert.ToInt32(quantityTextBox.Text);

                //adds object to listbox
                inventoryListBox.Items.Add(item);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        //method that will execute when remove button is clicked
        public void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //removes the selected item from the listbox
                inventoryListBox.Items.RemoveAt(inventoryListBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Must select an item for removal");
            }
        }
    }
}
