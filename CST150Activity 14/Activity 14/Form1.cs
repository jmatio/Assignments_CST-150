using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //runs code when clicked, adding all selected items to the list box in a single string
        private void addButton_Click(object sender, EventArgs e)
        {

            //variables
            String sauce = "";
            String toppings = "";

            

            
            //detects which sauce will be added to variable
            if(pizzaSauceRadioButton.Checked)
            {
                sauce = "Pizza Sauce";
            }

            else if(barbequeSauceRadioButton.Checked)
            {
                sauce = "Barbeque Sauce";
            }

            else if(alfredoSauceRadioButton.Checked)
            {
                sauce = "Alfredo Sauce";
            }

            else if(buffaloSauceRadioButton.Checked)
            {
                sauce = "Alfredo Sauce";
            }

            else
            {
                sauce = "No Sauce";
            }


            //detects which toppings have been selected and adds to expanding toppings string
            if(cheeseCheckBox.Checked)
            {
                toppings += "Cheese, ";
            }

            if(pepperoniCheckBox.Checked)
            {
                toppings += "Pepperoni, ";
            }

            if(sausageCheckBox.Checked)
            {
                toppings += "Sausage, ";
            }

            if (baconCheckBox.Checked)
            {
                toppings += "Bacon, ";
            }

            if (chickenCheckBox.Checked)
            {
                toppings += "Chicken, ";
            }

            if (hamCheckBox.Checked)
            {
                toppings += "Ham, ";
            }

            if (tomatoesCheckBox.Checked)
            {
                toppings += "Tomatoes, ";
            }

            if (pineappleCheckBox.Checked)
            {
                toppings += "Pineapple, ";
            }

            if (mushroomsCheckBox.Checked)
            {
                toppings += "Mushrooms, ";
            }

            if (olivesCheckBox.Checked)
            {
                toppings += "Olives, ";
            }

            if (bellPeppersCheckBox.Checked)
            {
                toppings += "Bell Peppers, ";
            }

            if (onionsCheckBox.Checked)
            {
                toppings += "Onions, ";
            }


            //adds all selected items to listbox in a single string
            finishedPizzaListBox.Items.Add(crustComboBox.SelectedItem + ", " + sauce + ", " + toppings);

            //resets all selection parameters
            crustComboBox.Text = "";
            pizzaSauceRadioButton.Checked = false;
            barbequeSauceRadioButton.Checked = false;
            buffaloSauceRadioButton.Checked = false;
            alfredoSauceRadioButton.Checked = false;
            cheeseCheckBox.Checked = false;
            pepperoniCheckBox.Checked = false;
            sausageCheckBox.Checked = false;
            baconCheckBox.Checked = false;
            chickenCheckBox.Checked = false;
            hamCheckBox.Checked = false;
            tomatoesCheckBox.Checked = false;
            pineappleCheckBox.Checked = false;
            mushroomsCheckBox.Checked = false;
            olivesCheckBox.Checked = false;
            bellPeppersCheckBox.Checked = false;
            onionsCheckBox.Checked = false;
        }

        
        //removes a selected item from the listbox
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (finishedPizzaListBox.SelectedItem != null)
            {
                finishedPizzaListBox.Items.Remove(finishedPizzaListBox.SelectedItem);
            }
            
            else
            {
                MessageBox.Show("Please select an item to be removed");
            }
             
        }
    }
}
