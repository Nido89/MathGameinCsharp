using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        // creating the random number object
        Random randomizer = new Random();
        // Two variables to store random addition number values
        int addNum1;
        int addNum2;
        // Lets create the mthod to pass values to int variables
        public void startQuiz()
        {
            addNum1 = randomizer.Next(100);
            addNum2 = randomizer.Next(100);

            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum1.ToString();

            sum.Value = 0;
        }

    


    public Form1()
        {
            InitializeComponent();
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }
    }
}
