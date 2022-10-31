using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
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
                InventoryManager manager = new InventoryManager();

                //sets values to object from user input
                item.Name = nameTextBox.Text;
                item.Department = departmentTextBox.Text;
                item.PartNumber = Convert.ToInt32(partNumberTextBox.Text);
                item.Price = Convert.ToDouble(priceTextBox.Text);
                item.Qty = Convert.ToInt32(quantityTextBox.Text);

                
                //adds object to listbox
                inventoryListBox.Items.Add(item);

                //adds object to inventory manager list
                manager.AddItem();
            }
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        //method that will execute when remove button is clicked
        public void btnRemove_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
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

        //adds a search function
        private void searchNameButton_Click(object sender, EventArgs e)
        {
            inventoryListBox.SelectedIndex = inventoryListBox.FindString(searchNameTextBox.Text);

            
        }

        //adds an update function to restock inventory
        private void updateButton_Click(object sender, EventArgs e)
        {
            InventoryManager manager = new InventoryManager();
            InventoryItem item = new InventoryItem();

            if (inventoryListBox.SelectedIndex > -1)
            {
                try
                {
                    inventoryListBox.Items.RemoveAt(inventoryListBox.SelectedIndex);
                    //implements the InventoryItem class and creates a new object
                    InventoryItem item2 = new InventoryItem();

                    //sets values to object from user input
                    item2.Name = nameTextBox.Text;
                    item2.Department = departmentTextBox.Text;
                    item2.PartNumber = Convert.ToInt32(partNumberTextBox.Text);
                    item2.Price = Convert.ToDouble(priceTextBox.Text);
                    item2.Qty = Convert.ToInt32(quantityTextBox.Text);

                    //adds object to listbox
                    inventoryListBox.Items.Add(item2);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }
        }

       
    }
    }

