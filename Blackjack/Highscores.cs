using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
            //Hide minimize, maximise and exit buttons on window.
            ControlBox = false;
            
            displayHighscores();
        }

        /// <summary>
        /// Close the highscore window when back label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backLbl_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Displays highscores.txt as text on highscore window. Uses stream reader to read from .txt file
        /// </summary>
        private void displayHighscores()
        {
            //Display Highscores
            //1: Open input stream from text file to application
            StreamReader sr = new StreamReader("../../highscores.txt"); 
            //2: Read data line by line
            string line = "";
            string scores = "";
            for (int index = 1; index <= 10; index++)
            {
                while ((line = sr.ReadLine()) != null)//while not reaching the end 
                {
                    scores += index++ + ". " + line + "%" + Environment.NewLine;
                }
            }
            //Set text as .txt text
            scoresLbl.Text = scores;

            //3: Close stream reader.
            sr.Close();
        }

        /// <summary>
        /// Changes colour of text on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backLbl_MouseEnter(object sender, EventArgs e)
        {
            backLbl.ForeColor = Color.MediumPurple;
        }

        /// <summary>
        /// Changes colour back to original when leaving hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backLbl_MouseLeave(object sender, EventArgs e)
        {
            backLbl.ForeColor = Color.White;
        }
        
    }
}
