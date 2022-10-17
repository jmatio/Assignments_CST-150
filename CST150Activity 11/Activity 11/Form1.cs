using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //implements a die class
        class Die
        {
            //initializes variable for number of sides on die
            private int numSides;

            //allows use of random numbers
            private Random random = new Random();

            //constructor that takes an integer between 4 and 20, inclusive and sets the number of sides of the die 
            public Die(int numSides)
            {
                if (numSides < 4 || numSides > 20)
                {
                    throw new ArgumentException("Should be in range [4, 20]");
                }

                this.numSides = numSides;
            }

            //method to roll die and return a random number
            public int RollDie()
            {
                return random.Next(1, numSides + 1);
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            //creates two die objects
            Die die1 = new Die(6);
            Die die2 = new Die(6);

            //initializes variables for rolls
            int roll1;
            int roll2;
            int numRolls = 0;

            //method continues to roll both die as long as snake eyes has not been rolled and counts how each roll
            do
            {
                roll1 = die1.RollDie();
                roll2 = die2.RollDie();

                numRolls++;
            } while (roll1 != 1 && roll2 != 1);

            //displays number rolled in textboxes
            dieOneTextBox.Text = Convert.ToString(roll1);
            dieTwoTextBox.Text = Convert.ToString(roll2);

            //displays a window with how many rolls it took to get snake eyes
            MessageBox.Show("Snake Eyes! It took " + numRolls + " rolls to get snake eyes.");
            
        }
    }
}
