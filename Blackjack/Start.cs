using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            //Hide minimize, maximise and exit buttons on window.
            ControlBox = false;
        }
        /// <summary>
        /// Get's players name from text box
        /// </summary>
        /// <returns>Player's name</returns>
        public string getText()
        {
            return playerName.Text;
        }

        /// <summary>
        /// Check's if text is in text box
        /// </summary>
        /// <returns>bool: true</returns>
        public bool checkForName()
        {
            return true;
        }
        
        /// <summary>
        /// Displays instructions in a message box when clicking instructions label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionsLbl_Click(object sender, EventArgs e)
        {
            //Display game rules
            string title = "Instructions";
            string message = "The game starts with the player and the computer both recieving one card each.\n" +
                "The game will randomly decide who's turn is first. Turns are represented by a border around the respective cards.\n" +
                "The deck of cards holds 52 cards (4 suits of 13). Each card's number is its value, except for Jack, Queen and King. Their values are 10. Each card's value" +
                " in a player's hand will be added to each score. e.g Ace = 1, Two = 2, King = 10.\n" +
                "Players can choose to hit (be dealt a card from the deck) or stand(not be dealt a card).\n" +
                "The aim of the game is to get a total score of 21.\n" +
                "If a player's score is more than 21, they will lose.\n" +
                "If both players are standing, the game will end. Whoever is closest to 21, wins." +
                "Highscores are based off of percentage of games won";
            MessageBox.Show(message, title);
        }

        /// <summary>
        /// Changes colour of text on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionsLbl_MouseEnter(object sender, EventArgs e)
        {
            instructionsLbl.ForeColor = Color.MediumPurple;
        }

        /// <summary>
        /// Changes colour back to original when leaving hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionsLbl_MouseLeave(object sender, EventArgs e)
        {
            instructionsLbl.ForeColor = Color.White;
        }

        /// <summary>
        /// Displays highscores window when highscores label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highscoresLbl_Click(object sender, EventArgs e)
        {
            Highscores highscores = new Highscores();
            highscores.Show();
        }

        /// <summary>
        /// Changes colour of text on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highscoresLbl_MouseEnter(object sender, EventArgs e)
        {
            highscoresLbl.ForeColor = Color.MediumPurple;
        }

        /// <summary>
        /// Changes colour back to original when leaving hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highscoresLbl_MouseLeave(object sender, EventArgs e)
        {
            highscoresLbl.ForeColor = Color.White;
        }

        /// <summary>
        /// Quits the game when quit label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitLbl_Click(object sender, EventArgs e)
        {
            //Ask for user confirmation
            string title = "Quit the game?";
            string message = "Are you sure you want to quit?";

            var result = MessageBox.Show(title, message, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Changes colour of text on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitLbl_MouseEnter(object sender, EventArgs e)
        {
            quitLbl.ForeColor = Color.MediumPurple;
        }

        /// <summary>
        /// Changes colour back to original when leaving hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitLbl_MouseLeave(object sender, EventArgs e)
        {
            quitLbl.ForeColor = Color.White;
        }

        /// <summary>
        /// Enters new game when start label is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startLbl_Click(object sender, EventArgs e)
        {
            //Checks if text input is empty, show messagebox until user enters a name
            if (playerName != null)
            {
                if (string.IsNullOrEmpty(playerName.Text))
                {
                    MessageBox.Show("Please enter a name.", "Enter a name");
                }
                else
                {
                    //Open the Blackjack form
                    //Application.Run(new Blackjack());
                    //Program.blackjack.Show();
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// Changes colour of text on hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startLbl_MouseEnter(object sender, EventArgs e)
        {
            startLbl.ForeColor = Color.MediumPurple;
        }

        /// <summary>
        /// Changes colour back to original when leaving hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startLbl_MouseLeave(object sender, EventArgs e)
        {
            startLbl.ForeColor = Color.White;
        }
    }
}
