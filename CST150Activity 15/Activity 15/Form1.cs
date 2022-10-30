using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity_15
{
    public partial class Form1 : Form
    {

        //variables
        int dayMax;
        int luckyNumber;

        public Form1()
        {
            InitializeComponent();
        }

        //method for creating birthday
        public void birthDay()
        {

            //sets months in the selected indexes to have a total of 31 days
            dayMax = 0;
            if (monthComboBox.SelectedIndex == 0 || monthComboBox.SelectedIndex == 2 || monthComboBox.SelectedIndex == 4 ||
                monthComboBox.SelectedIndex == 6 || monthComboBox.SelectedIndex == 7 || monthComboBox.SelectedIndex == 9 ||
                monthComboBox.SelectedIndex == 11)
            {
                dayMax = 31;
            }

            //checks to see if the month of february falls into a leap year
            else if (monthComboBox.SelectedIndex == 1)
            {
                int year = Int32.Parse(yearComboBox.Text);
                

                if (year % 400 == 0)
                    dayMax = 29;
                
                if (year % 100 == 0)
                    dayMax = 28;
                
                if (year % 4 == 0)
                    dayMax = 29;
                else
                    dayMax = 28;
            }
            else
                dayMax = 30;

            //makes sure a month is selected, then adds the maximum amount of allowed days to be selected for that month into the day selection
            if (monthComboBox.SelectedIndex != -1)
            {
                dayComboBox.Items.Clear();
                for (int i = 0; i < dayMax; i++)
                {
                    dayComboBox.Items.Add(i + 1);
                }
                dayComboBox.Text = dayMax.ToString();
            }
        }

        //click event for "Show lucky number" button
        private void luckyNumberButton_Click(object sender, EventArgs e)
        {

            //checks to see if all required indexes are selected, then calculates and shows solution on new form
            if (yearComboBox.SelectedIndex != -1 && monthComboBox.SelectedIndex != -1 && dayComboBox.SelectedIndex != -1 && colorComboBox.SelectedIndex != -1)
            {
                //calculation for lucky number
                luckyNumber = (yearComboBox.SelectedIndex + monthComboBox.SelectedIndex + dayComboBox.SelectedIndex + colorComboBox.SelectedIndex);

                //creates a new form and sends lucky number as a string
                Form2 form2 = new Form2();
                Form2.instance.label.Text = luckyNumber.ToString();
                form2.Show();

                
            }

            //executes in messagebox if missing parameters
            else
            {
                MessageBox.Show("Must select from all fields");
            }
        }

        //sends the selected index choice to birthDay function
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();
        }

        //sends the selected index choice to birthDay function
        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay();
        }

        
    }
}
