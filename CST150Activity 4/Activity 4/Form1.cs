using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //initializes textbox
        private void secondsElapsedTextBox_TextChanged(object sender, EventArgs e)
        { 
            //program would not run without this
        }

        //conversion process
        private void convertButton_Click(object sender, EventArgs e)
        {
            //validates parse and initializes new integer variable
            if (int.TryParse(secondsElapsedTextBox.Text, out int secondsElapsed))
            {
                //tests integer variable and converts for each possible output
                if (secondsElapsed >= 86400)
                {
                    int result = secondsElapsed / 86400;
                    convertedTimeTextBox.Text = result.ToString() + " days";
                }

                else if (secondsElapsed >= 3600)
                {
                    int result = secondsElapsed / 3600;
                    convertedTimeTextBox.Text = result.ToString() + " hours";
                }

                else if (secondsElapsed >= 60)
                {
                    int result = secondsElapsed / 60;
                    convertedTimeTextBox.Text = result.ToString() + " minutes";
                }

                else
                {
                    convertedTimeTextBox.Text = "Input cannot be simplified";
                }
            }
        }

        //clears all textboxes and resets focus when clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            secondsElapsedTextBox.Text = "";
            convertedTimeTextBox.Text = "";

            secondsElapsedTextBox.Focus();
        }

        //closes the form when clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
