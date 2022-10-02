using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculates the input on click
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //initializes variables
                double input = Convert.ToDouble(inputTermsTextBox.Text);
                int odd = 1;
                double pi = 0.0;

                //runs through loop and calculates pi based on number of terms given
                for (int i = 1; i <= input; i++)
                {
                    double currentTerm = 0.0;

                    //checks if even or odd and calculates correct pi formula
                    if (i % 2 == 0)
                    {
                        currentTerm = (double)-4 / odd;
                    }
                    else
                    {
                        currentTerm = (double)4 / odd;
                    }

                    //updates variables
                    odd = odd + 2;
                    pi = pi + currentTerm;


                }

                //outputs result to textbox
                outputCalculationLabel.Text = "Approximate value of pi after " + inputTermsTextBox.Text + " terms \n = " + pi.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
