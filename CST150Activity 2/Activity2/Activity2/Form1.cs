namespace Activity_2
{
    public partial class ageInDaysCalculatorForm : Form
    {
        public ageInDaysCalculatorForm()
        {
            InitializeComponent();
        }

        //closes the form on click
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            int age = Convert.ToInt16(enterAgeTextBox.Text);
            int result = age * 365;

            ageInDaysTextBox.Text = result.ToString();
        }
    }
}