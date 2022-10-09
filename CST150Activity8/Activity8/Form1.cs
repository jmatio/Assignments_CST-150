using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sets all inputs and outputs to empty strings on click
        //runs when reset button is clicked
        private void resetButton_Click(object sender, EventArgs e)
        {
            enterFatTextBox.Text = "";
            enterCarbsTextBox.Text = "";
            outputCaloriesFromFat.Text = "";
            outputCaloriesFromCarbs.Text = "";
            outputTotalCalories.Text = "";
        }

        //runs code when submit button is clicked
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converts both inputs into doubles
                double fat = Convert.ToDouble(enterFatTextBox.Text);
                double carbs = Convert.ToDouble(enterCarbsTextBox.Text);

                //determines calorie count from input and stores in a new variable
                double fatCalories = fat * 9;
                double carbsCalories = carbs * 4;
                double totalCalories = fatCalories + carbsCalories;

                //converts calorie count to strings and outputs to label
                outputCaloriesFromFat.Text = fatCalories.ToString();
                outputCaloriesFromCarbs.Text = carbsCalories.ToString();
                outputTotalCalories.Text = totalCalories.ToString();
            }

            catch (FormatException)
            {
                //displays to text boxes when anything other than a number is entered
                enterFatTextBox.Text = "Must enter a number";
                enterCarbsTextBox.Text = "Must enter a number";
            }
        }
    }
}
