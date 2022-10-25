using System;
public class Activity12
{
    public static void Main()
    {
        //variables
        int word = 0;
        int index = 0;
        string input = System.IO.File.ReadAllText("input.txt");
        
        //will loop until the end of string
        while (index <= input.Length - 1)
        {
            //checks the last character of each string for 't' or 'e' and the next space for punctuation or whitespace
            if ((input[index] == '.' || input[index] == ' ' || input[index] == '\t' || input[index] == '!' || input[index] == ',' || input[index] == '?' || input[index] == '\n') && (input[index - 1] == 't' || input[index - 1] == 'e'))
            {
                //increments variable to keep count of each word ending in 't' or 'e'
                word++;
            }

            index++;
        }

        //output to console
        Console.Write("There are {0} words ending in t or e", word);
    }
}