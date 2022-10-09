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

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryItem item = new InventoryItem();

                item.Name = nameTextBox.Text;
                item.PartNumber = Convert.ToInt32(partNumberTextBox.Text);
                item.Price = Convert.ToDecimal(priceTextBox.Text);
                item.Quantity = Convert.ToInt32(quantityTextBox.Text);

                inventoryListBox.Items.Add(item);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryListBox.Items.RemoveAt(inventoryListBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Must select an item for removal");
            }
        }
    }
}
