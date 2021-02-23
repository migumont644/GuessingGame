using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    
    public partial class titleLabel : Form
    {
        Random randGen = new Random();
        int userguess, randomNumber;

        public titleLabel()
        {
            InitializeComponent();
            randomNumber = randGen.Next(1, 101);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int userguess = Convert.ToInt32(numberInput.Text);
          

            if (userguess > randomNumber)
            {
                answerOutput.Text = $"Too High!";
            }

            if(userguess < randomNumber)
            {
                answerOutput.Text = $"Too Low!";
            }

            if(userguess == randomNumber)
            {
                answerOutput.Text = $"You Got it!";
            }

        }
    }
}
