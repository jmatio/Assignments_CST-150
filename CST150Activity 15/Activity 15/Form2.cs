using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form2 : Form
    {

        //initializes instance to recieve data from Form1
        public static Form2 instance;
        public Label label;

        //acquire int variable for lucky number from Form1
        public int luckyNumber { get; set; }
        public Form2()
        {
            InitializeComponent();
            instance = this;
            label = luckyNumberLabel;
        }
        
        //displays data from Form1 on Form2, in this case it is the lucky number, when the form loads
        private void Form2_Load(object sender, EventArgs e)
        {

            //converts lucky number variable to string and displays in label
            luckyNumberLabel.Text = luckyNumber.ToString();

            
        }
    }
}
