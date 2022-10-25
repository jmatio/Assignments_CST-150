using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        //creates a 2d array and initializes with 3 rows and 3 columns
        int[,] gameArray = new int[3,3];

        int row, col;

        public Form1()
        {
            InitializeComponent();
        }

        //method checks all score variables
        public void checkScore()
        {

            int firstPlayer = 0;
            int secondPlayer = 0;

            //checks first row

            if (A1.Text != "" && A2.Text != "" && A3.Text != "")
            {

                if (A1.Text == A2.Text && A2.Text == A3.Text)
                {
                    if (A1.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }    
            }

            //checks second row

            if (B1.Text != "" && B2.Text != "" && B3.Text != "")
            {

                if (B1.Text == B2.Text && B2.Text == B3.Text)
                {

                    if (B1.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks third row

            if (C1.Text != "" && C2.Text != "" && C3.Text != "")
            {

                if (C1.Text == C2.Text && C2.Text == C3.Text)
                {

                    if (C1.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks top left to bottom right diagonal

            if (A1.Text != "" && B2.Text != "" && C3.Text != "")
            {
                
                if (A1.Text == B2.Text && B2.Text == C3.Text)
                {

                    if (A1.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks top right to bottom left diagonal

            if (A3.Text != "" && B2.Text != "" && C1.Text != "")
            {

                if (A3.Text == B2.Text && B2.Text == C1.Text)
                {

                    if (A3.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks first column

            if (A1.Text != "" && B1.Text != "" && C1.Text != "")
            {

                if (A1.Text == B1.Text && B1.Text == C1.Text)
                {

                    if (A1.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks second column

            if (A2.Text != "" && B2.Text != "" && C2.Text != "")
            {

                if (A2.Text == B2.Text && B2.Text == C2.Text)
                {

                    if (A2.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks third column

            if (A3.Text != "" && B3.Text != "" && C3.Text != "")
            {

                if (A3.Text == B3.Text && B3.Text == C3.Text)
                {

                    if (A3.Text == "X")
                    {
                        firstPlayer++;
                    }

                    else
                    {
                        secondPlayer++;
                    }
                }
            }

            //checks score to determine which player won the game and displays winner

            if (firstPlayer == secondPlayer)
            {
                MessageBox.Show("It's a Draw!");
            }

            else if (firstPlayer > secondPlayer)
            {
                MessageBox.Show("Player One Wins!");
            }

            else if (firstPlayer < secondPlayer)
            {
                MessageBox.Show("Player Two Wins!");
            }

        }

        //displays when "About" button is clicked in menu
        private void aboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Justin Matioschat");
        }

        //simulates a game of tic tac toe on click
        private void simulateButton_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            for (row = 0; row < 3; row++)
            {

                for (col = 0; col < 3; col++)
                {

                    //generates a random number for each element in array
                    gameArray[row, col] = random.Next(0, 2);
                }
            }

            //checks numbers and displays either "X" if ==1 or "O" if !=1
            if (gameArray[0, 0] == 1)
            {
                A1.Text = "X";
            }
            
            else
            {
                A1.Text = "O";
            }

            if (gameArray[0, 1] == 1)
            {
                A2.Text = "X";
            }

            else
            {
                A2.Text = "O";
            }

            if (gameArray[0, 2] == 1)
            {
                A3.Text = "X";
            }

            else
            {
                A3.Text = "O";
            }

            if (gameArray[1, 0] == 1)
            {
                B1.Text = "X";
            }

            else
            {
                B1.Text = "O";
            }

            if (gameArray[1, 1] == 1)
            {
                B2.Text = "X";
            }

            else
            {
                B2.Text = "O";
            }

            if (gameArray[1, 2] == 1)
            {
                B3.Text = "X";
            }

            else
            {
                B3.Text = "O";
            }

            if (gameArray[2, 0] == 1)
            {
                C1.Text = "X";
            }

            else
            {
                C1.Text = "O";
            }

            if (gameArray[2, 1] == 1)
            {
                C2.Text = "X";
            }

            else
            {
                C2.Text = "O";
            }

            if (gameArray[2, 2] == 1)
            {
                C3.Text = "X";
            }

            else
            {
                C3.Text = "O";
            }
        }

        //runs the checkScore method when clicked
        private void checkScoresButton_Click(object sender, EventArgs e)
        {
            checkScore();
        }

        //closes the application
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
