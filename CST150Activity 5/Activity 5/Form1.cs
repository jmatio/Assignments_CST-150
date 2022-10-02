using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //functions for when the upload button is clicked
        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //creates the function which allows user to upload a file by clicking the button
                OpenFileDialog ofd = new OpenFileDialog();

                //filters which file types will be accepted
                ofd.Title = "Open Text File";
                ofd.Filter = "Text File|*.txt|Word File|*.docx";

                //initializes variables for calculations
                int wordValue = 0;
                int newWordCount = 0;
                int numVowels = 0;
                int newVowelCount = 0;




                //checks if file was uploaded was successfully uploaded for use
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //creates a streamreader to read the contents of the uploaded file
                    StreamReader inputFile = new StreamReader(File.OpenRead(ofd.FileName));

                    //creates a streamwriter to output results to a declared filepath
                    StreamWriter writer = new StreamWriter(Application.StartupPath + "\\output.txt");
                    
                        //reads all contents in file to the end and adds names into an array, then sorts them
                        String data = System.IO.File.ReadAllText(ofd.FileName);
                        string[] names = data.Split(' ');
                        Array.Sort(names);
                        
                        
                        
                    //runs all names in file through both if statements
                    for (int i = 0; i < names.Length - 1; i++)
                    {
                        //checks each name length and updates variable to the new longest word on finish
                        if (wordValue < names[i].Length)
                        {
                            wordValue = names[i].Length;
                            newWordCount = i;
                        }

                        //checks total vowels in each name and updates variable to the word with most vowels on finish
                        if (numVowels < TotalVowels(names[i]))
                        {
                            numVowels = TotalVowels(names[i]);
                            newVowelCount = i;
                        }

                    }

                    //formula for checking vowels in each word
                    int TotalVowels(string word)
                    {
                        int vowels = 0;
                        for (int i = 0; i < word.Length - 1; i++)
                        {
                            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                            {
                                vowels = vowels + 1;
                            }
                        }
                        return vowels;
                    }

                    //outputs all results to text boxes in program
                    lowerCaseOutputTextBox.Text = data.ToLower();
                    firstNameTextBox.Text = names[0];
                    lastNameTextBox.Text = names[names.Length - 1];
                    longestNameTextBox.Text = names[newWordCount];
                    nameMostVowelsTextBox.Text = names[newVowelCount];

                    //declares what will be written in output file
                    writer.WriteLine("Lowercase Output: " + lowerCaseOutputTextBox.Text);
                    writer.WriteLine("First Alphabetical Word: " + firstNameTextBox.Text);
                    writer.WriteLine("Last Alphabetical Word: " + lastNameTextBox.Text);
                    writer.WriteLine("Longest Word: " + longestNameTextBox.Text);
                    writer.WriteLine("Word with Most Vowels: " + nameMostVowelsTextBox.Text);

                    //informs user of successful operation
                    MessageBox.Show("Output Successful!");

                    //sends output contents to output file in bin/debug folder
                    writer.Flush();

                    //closes stream writer and disposes of input file
                    inputFile.Close();
                    writer.Close();
                    ofd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;


            }
        }
    }
}
