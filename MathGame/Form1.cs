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
    public partial class mathGame : Form
    {
        // creating the random number object
        Random randomizer = new Random();
        // Two variables to store random addition number values
        int addNum1;
        int addNum2;

        int minusNum1;
        int minusNum2;

        int multipluNum1;
        int multiplyNum2;

        int divideNum1;
        int divideNum2;

        //Defining the clock variable
        int clock;
        // Lets create the mthod to pass values to int variables
        public void StartQuiz()
        {
            addNum1 = randomizer.Next(50);
            addNum2 = randomizer.Next(51);

            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();

            sum.Value = 0;


            minusNum1 = randomizer.Next(1, 101);

            minusNum2 = randomizer.Next(1, minusNum1);


            minusLeftLabel.Text = minusNum1.ToString();
            minusRightLabel.Text = minusNum2.ToString();

            difference.Value = 0;

            multipluNum1 = randomizer.Next(2, 11);
            multiplyNum2 = randomizer.Next(1, 11);

            timesLeftLabel.Text = multipluNum1.ToString();
            timesRightLabel.Text = multiplyNum2.ToString();

            product.Value = 0;


            divideNum2 = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);

            divideNum1 = divideNum2 * temporaryQuotient;


            dividedLeftLabel.Text = divideNum1.ToString();
            dividedRightLabel.Text = divideNum2.ToString();

            quotient.Value = 0;

            clock = 10;
            timeLabel.Text = "10 Seconds";
            timer1.Start();

        }
        private bool CheckAnswer
        {
            get
            {
                if ((((addNum1 + addNum2 == sum.Value)
                    && (minusNum1 - minusNum2 == difference.Value))
                    && (multipluNum1 * multiplyNum2 == product.Value))
                    && (divideNum1 / divideNum2 == quotient.Value))

                    return true;
             
            else
                    return false;
               
            }
        }

        public mathGame()
        {
            InitializeComponent();
        }

     

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                // Displaying the new Time left
                // By Updating the Time Left Label
                clock -= 1;
                timeLabel.Text = clock + "seconds";
            }
            else
            {
                // If the user run out of time,stop the time, show
                // A messageBox, and fill in the answers
                timer1.Stop();
                timeLabel.Text = "Time Over";
                MessageBox.Show("You could not Finnish The Test in Time.Press enter to see correct answers");

                // Correct answers
                sum.Value = addNum1 + addNum2;
                difference.Value = minusNum1 - minusNum2;
                product.Value = multipluNum1 * multiplyNum2;
                quotient.Value = divideNum1 / divideNum2;
                startButton.Enabled = true;
                MessageBox.Show("These were the correct answers");
            }
        }

        private void Answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in Numeric updown control


            if (sender is NumericUpDown answerBox)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Answer_Enter2(object sender, EventArgs e)
        {
            // Select the whole answer in Numeric updown control
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Answer_Enter3(object sender, EventArgs e)
        {
            // Select the whole answer in Numeric updown control
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Answer_Enter4(object sender, EventArgs e)
        {
            // Select the whole answer in Numeric updown control


            if (sender is NumericUpDown answerBox)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
           
        }

        private void endButton_Click(object sender, EventArgs e)
        {

            if(CheckAnswer == true)
            {
                MessageBox.Show("Well Done");
            }
            else if (CheckAnswer== false){
                MessageBox.Show("Try Again");
            }
            timer1.Stop();
            timeLabel.Text = "You Finished it";
            MessageBox.Show("You could not Finnish The Test in Time.Press enter to see correct answers");
            // Correct answers
            sum.Value = addNum1 + addNum2;
            difference.Value = minusNum1 - minusNum2;
            product.Value = multipluNum1 * multiplyNum2;
            quotient.Value = divideNum1 / divideNum2;
            startButton.Enabled = true;

        }
    }
}
