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

        class Die
        {
            private int numSides;

            private Random random = new Random();

            public Die(int numSides)
            {
                if (numSides < 4 || numSides > 20)
                {
                    throw new ArgumentException("Should be in range [4, 20]");
                }

                this.numSides = numSides;
            }
            public int RollDie()
            {
                return random.Next(1, numSides + 1);
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Die die1 = new Die(6);
            Die die2 = new Die(6);

            int roll1;
            int roll2;
            int numRolls = 0;

            do
            {
                roll1 = die1.RollDie();
                roll2 = die2.RollDie();

                numRolls++;
            } while (roll1 != 1 && roll2 != 1);

            dieOneTextBox.Text = Convert.ToString(roll1);
            dieTwoTextBox.Text = Convert.ToString(roll2);

            MessageBox.Show("Snake Eyes! It took " + numRolls + " rolls to get snake eyes.");
            
        }
    }
}
