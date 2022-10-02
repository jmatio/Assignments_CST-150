using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //resets the fields of text boxes on click
        private void resetButton_Click(object sender, EventArgs e)
        {
            enterAgeTextBox.Text = "";
            ageInDaysTextBox.Text = "";
        }

        //converts the age entered into days and displays in textbox below on click
        private void convertButton_Click(object sender, EventArgs e)
        {
            //checks user input to ensure a valid number was entered
            try
            {
                int age = Convert.ToInt16(enterAgeTextBox.Text);
                int result = age * 365;

                ageInDaysTextBox.Text = result.ToString("#.000");
            }
            //informs the user that an invalid input was given
            catch (FormatException)
            {

                ageInDaysTextBox.Text = "Must enter a number";
            }
        }
        
        //closes the form on click
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
