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

namespace Blackjack
{
    public partial class Blackjack : Form
    {
        //Declare common variables for the game
        //public static Start start;

        //Deck
        static Deck deck = new Deck();
        
        //New player, their score and hand
        static List<Card> playerHand = new List<Card>();
        static Player newPlayer = new Player("", 0, playerHand, 0, false, false, 0);

        //The computer, their score and hand
        static List<Card> computerHand = new List<Card>();
        static Player computer = new Player("computer", 0, computerHand, 0, false, false, 0);

        //List of players in game (newPlayer & computer)
        static List<Player> players = new List<Player>(2);

        //Lists of names and scores for highscores
        static List<string> playerNames = new List<string>();
        static List<int> playerScores = new List<int>();

        //gameTotal for highscore calculations
        static int gameTotal = 0;

        public Blackjack()
        {
            InitializeComponent();
            
            //Displays start screen
            startForm();
            
            //Changes label to players name
            newPlayer.setName(playerLbl.Text);
            //Add to players list
            players.Add(newPlayer);
            players.Add(computer);
            
            //Create and shuffle deck
            deck.createDeck();
            deck.shuffle();

            //Check if shuffles
            //label8.Text = deck.toString();
           
            //deals first card
            dealFirstCard(players, deck);
            //Decides who goes first
            decideFirstTurn(players);
        }

        /// <summary>
        /// Show a pop up messagebox when player clicks pause.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseLbl_Click(object sender, EventArgs e)
        {
            DialogResult dialog2 = MessageBox.Show("Game Paused. Resume?",
             "Pause");
        }

        /// <summary>
        /// Show a pop up message box when player clicks stop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopLbl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to stop playing, " + playerLbl.Text + "?",
             "Stop", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
                //Move back to start
               // Blackjack.start.Show();
                //this.Hide();
            }
        }

        /// <summary>
        ///  Open's the highscore window, when clicking highscore label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highscoreLbl_Click(object sender, EventArgs e)
        {
            Highscores highscores = new Highscores();
            DialogResult dr = highscores.ShowDialog();
        }

        /// <summary>
        /// Opens the start form/screen.
        /// </summary>
        public void startForm()
        {
            Start start = new Start();

            DialogResult dr = start.ShowDialog();

            //Assign the entered text as player's name label
            if (start.checkForName() && start.getText() != "")
            {
                playerLbl.Text = start.getText();
                playerLbl.Update();
            }
        }
        
        /// <summary>
        /// Decides first turn of the game
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        private Player decideFirstTurn(List<Player> players)
        {
            Random r = new Random();
            int rNumber = r.Next(0, 2);

            Player firstPlayer = players[rNumber];
            firstPlayer.setTurn(true);


            return firstPlayer;
        }
        
        /// <summary>
        /// Hit method (deal a card)
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="player"></param>
        private void hit(Deck deck, Player player)
        {
            //topcard of deck
            Card card = deck.getDeck()[0];
            //adds card to hand
            player.getHand().Add(card);
            //removes from deck
            deck.getDeck().Remove(card);
            //adds card's value to score
            int cardValue = card.getCardValue();
            player.increaseScore(cardValue);

            //add images
            if (player == computer)
            {
                Card computerCard = computer.getHand()[0];
                int count = computer.getHand().Count;
                computerCard = computer.getHand()[count - 1];
                PictureBox computerCardImage = computerCard.getImage();
                deck.addImage(computerCardImage, computerCard.getImgNum());
                //
                switch (count)
                {
                    case 1:
                        computerFirstCard.Image = Properties.Resources.Back;
                        break;
                    case 2:
                        computerSecondCard.Image = Properties.Resources.Back;
                        break;
                    case 3:
                        computerThirdCard.Image = Properties.Resources.Back;
                        break;
                    case 4:
                        computerFourthCard.Image = Properties.Resources.Back;
                        break;
                    case 5:
                        computerFifthCard.Image = Properties.Resources.Back;
                        break;
                    case 6:
                        computerSixthCard.Image = Properties.Resources.Back;
                        break;
                    default:
                        break;
                }
            }
            else if (player == newPlayer)
            {
                Card playerCard = newPlayer.getHand()[0];
                int count = player.getHand().Count;
                playerCard = player.getHand()[count - 1];

                deck.addImage(playerCard.getImage(), playerCard.getImgNum());

                switch (count)
                {
                    case 1:
                        playerFirstCard.Image = playerCard.getImage().Image;
                        break;
                    case 2:
                        playerSecondCard.Image = playerCard.getImage().Image;
                        playerScoreLbl.Update();
                        playerSecondCard.Update();
                        break;
                    case 3:
                        playerThirdCard.Image = playerCard.getImage().Image;
                        playerThirdCard.Update();
                        break;
                    case 4:
                        playerFourthCard.Image = playerCard.getImage().Image;
                        playerFourthCard.Update();
                        break;
                    case 5:
                        playerFifthCard.Image = playerCard.getImage().Image;
                        playerFifthCard.Update();
                        break;
                    case 6:
                        playerSixthCard.Image = playerCard.getImage().Image;
                        playerSixthCard.Update();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Deal the first card
        /// </summary>
        /// <param name="players"></param>
        /// <param name="deck"></param>
        private void dealFirstCard(List<Player> players, Deck deck)
        {
            gameTotal++;

            for (int index = 0; index <= 1; index++)
            {
                hit(deck, players[index]);
                Card playerCard = players[index].getHand()[0];

            }
            playerScoreLbl.Text = newPlayer.getScore().ToString();
            computerScoreLbl.Text = computer.getScore().ToString();
            checkTurn(players);
        }

        /// <summary>
        /// Check for which player's turn
        /// </summary>
        /// <param name="players"></param>
        private void checkTurn(List<Player> players)
        {
            bool playerTurn = players[0].getTurn();
            if (playerTurn)
            {
                //Display border around panel of Player turn
                panel1.BorderStyle = BorderStyle.FixedSingle;
                panel2.BorderStyle = BorderStyle.None;
                hitLbl.Enabled = true;
                standLbl.Enabled = true;
            }
            else
            {
                //Display border around panel of Computer turn
                panel2.BorderStyle = BorderStyle.FixedSingle;
                panel1.BorderStyle = BorderStyle.None;
                //disable buttons if computer turn
                hitLbl.Enabled = false;
                standLbl.Enabled = false;
                decideComputerTurn();
            }
            computerScoreLbl.Text = "?";
        }
        
        /// <summary>
        /// When player clicks hit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitLbl_Click(object sender, EventArgs e)
        {
            //Call hit method, that deals card to the player
            hit(deck, newPlayer);
            
            //Disable and set turns
            newPlayer.setTurn(false);
            computer.setTurn(true);
            
            //Check the scores
            checkScore();

            //Swaps turn
            checkTurn(players);
        }

        private void standLbl_Click(object sender, EventArgs e)
        {
            newPlayer.setTurn(false);
            newPlayer.setStanding(true);
            computer.setTurn(true);
            checkTurn(players);
            checkScore();
        }

        private void decideComputerTurn()
        {
            Random random = new Random();
            bool randomBool = random.Next(0, 2) > 0;

            if (randomBool)
            {
                computer.setStanding(true);
                System.Threading.Thread.Sleep(1000);
                newPlayer.setTurn(true);
                checkTurn(players);
                checkScore();
            }
            else
            {
                //hit
                computer.setStanding(false);
                System.Threading.Thread.Sleep(1000);
                hit(deck, computer);
                computer.setTurn(false);
                newPlayer.setTurn(true);
                checkTurn(players);
                checkScore();
            }
        }

        /// <summary>
        /// Displays computer's score to GUI
        /// </summary>
        private void showComputerGUI()
        {
            //Display score
            string computerScore = computer.getScore().ToString();
            computerScoreLbl.Text = computerScore;

            //Display cards in computers hand
            Card computerCard = computer.getHand()[0];
            int count = computer.getHand().Count;
            computerCard = computer.getHand()[count - 1];
            PictureBox computerCardImage = computerCard.getImage();
            deck.addImage(computerCardImage, computerCard.getImgNum());
            //if count == case, display that amount of cards in hand
            switch (count)
            {
                case 1:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    break;
                case 2:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    computerSecondCard.Image = computer.getHand()[1].getImage().Image;
                    break;
                case 3:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    computerSecondCard.Image = computer.getHand()[1].getImage().Image;
                    computerThirdCard.Image = computer.getHand()[2].getImage().Image;
                    break;
                case 4:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    computerSecondCard.Image = computer.getHand()[1].getImage().Image;
                    computerThirdCard.Image = computer.getHand()[2].getImage().Image;
                    computerFourthCard.Image = computer.getHand()[3].getImage().Image;
                    break;
                case 5:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    computerSecondCard.Image = computer.getHand()[1].getImage().Image;
                    computerThirdCard.Image = computer.getHand()[2].getImage().Image;
                    computerFourthCard.Image = computer.getHand()[3].getImage().Image;
                    computerFifthCard.Image = computer.getHand()[4].getImage().Image;
                    break;
                case 6:
                    computerFirstCard.Image = computer.getHand()[0].getImage().Image;
                    computerSecondCard.Image = computer.getHand()[1].getImage().Image;
                    computerThirdCard.Image = computer.getHand()[2].getImage().Image;
                    computerFourthCard.Image = computer.getHand()[3].getImage().Image;
                    computerFifthCard.Image = computer.getHand()[4].getImage().Image;
                    computerSixthCard.Image = computer.getHand()[5].getImage().Image;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Checks both scores in case of game end
        /// </summary>
        private void checkScore()
        {
            string playerScore = newPlayer.getScore().ToString();
            playerScoreLbl.Text = playerScore;
            playerScoreLbl.Update();
            //Check each score
            foreach (Player player in players)
            {
                //Initialize variable for players score
                int score = player.getScore();

                //If the score is equal to 21, player wins.
                if (score == 21)
                {
                    showComputerGUI();
                    player.increaseWins();

                    string playerName = player.getName();
                    string message =  playerName + " wins! Play again?";
                    string title = "Both players are standing!";

                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                    if(result == DialogResult.Yes)
                    {
                        //Start a new game
                        startNewGame();
                    } else
                    {
                        //Highscore
                        updateHighScores();
                        Application.Exit();
                    }
                  //If the players score is more than 21, player loses.
                } else if (score > 21)
                {
                    //If the player is the computer
                    if (player == computer)
                    {
                        showComputerGUI();
                        newPlayer.increaseWins();
                        string playerName = newPlayer.getName();
                        string message = playerName + " wins! Play again?";
                        string title = "Both players are standing!";
                        DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //Reset Game, sus out wins percentage etc
                            startNewGame();
                        }
                        //else the player is the new player
                        else
                        {
                            //Highscore stuff
                            updateHighScores();
                            Application.Exit();
                        }
                      
                      //Else if the player is the new player  
                    } else
                    {
                        showComputerGUI();
                        computer.increaseWins();
                        string computerName = computer.getName();
                        string message = computerName + " wins! Play again?";
                        string title = "Both players are standing!";
                        DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            startNewGame();
                        }
                        else
                        {
                            updateHighScores();
                            //Highscore stuff
                            Application.Exit();
                        }
                    }
                }
            }
            //If both players are standing check whoever is closest to 21
            if(newPlayer.getStanding() == true && computer.getStanding() == true)
            {
                //if new player's score is more than computers score, new player wins
                if(newPlayer.getScore() > computer.getScore())
                {
                    showComputerGUI();
                    newPlayer.increaseWins();
                    string playerName = newPlayer.getName();
                    string message = playerName + " wins! You are closest to 21! Play again?";
                    string title = playerName + " wins!";
                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Reset Game, sus out wins percentage etc
                        startNewGame();
                    }
                    //else computer wins
                    else
                    {
                        //Highscore stuff
                        updateHighScores();
                        Application.Exit();
                    }
                    //if scores are tied, no one wins. 
                } else if (newPlayer.getScore() == computer.getScore())
                {
                    showComputerGUI();
                    string playerName = newPlayer.getName();
                    string message = "It's a draw! Play again?";
                    string title = "Sorry, " + playerName + "!";
                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Reset Game, sus out wins percentage etc
                        startNewGame();
                    }
                    else
                    {
                        //Highscore stuff
                        updateHighScores();
                        Application.Exit();
                    }
                    //else computers score is more than new players score
                } else
                {
                    showComputerGUI();
                    string computerName = computer.getName();
                    string message = computerName + " wins! Computer is closest to 21! Play again?";
                    string title = computerName + "wins!";
                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        startNewGame();
                    }
                    else
                    {
                        updateHighScores();
                        //Highscore stuff
                        Application.Exit();
                    }
                }
            }
        }
        
        /// <summary>
        /// Calculate the total score
        /// </summary>
        private void calculateTotalScore()
        {
            //NEW WAY TO CALCUALTE SCORE. 2 PTS PER WIN. -1 PT PER LOSS? IDK
            /*int playerWins = newPlayer.getWins();
            int playerLoss = gameTotal - playerWins;

            int totalScore = (playerWins * 2) - playerLoss;
            percentLbl.Text = Convert.ToString(totalScore);
            
            totalLbl.Text = Convert.ToString(newPlayer.getWins()) + "/" + gameTotal;*/

            int playerWins = newPlayer.getWins();
            double percent = Math.Round((double)playerWins / (double)gameTotal * 100, 0);
            newPlayer.setWinPercent(Convert.ToInt16(percent));
            
            percentLbl.Text = Convert.ToString(percent) + "%";
            totalLbl.Text = Convert.ToString(newPlayer.getWins()) + "/" + gameTotal;
        }

        /// <summary>
        /// Starts a new game
        /// </summary>
        private void startNewGame()
        {
            calculateTotalScore();
            newPlayer.setTurn(false);
            computer.setTurn(false);
            newPlayer.setStanding(false);
            computer.setStanding(false);

            computerFirstCard.Image = null;
            computerSecondCard.Image = null;
            computerThirdCard.Image = null;
            computerFourthCard.Image = null;
            computerFifthCard.Image = null;
            computerSixthCard.Image = null;
            playerFirstCard.Image = null;
            playerSecondCard.Image = null;
            playerThirdCard.Image = null;
            playerFourthCard.Image = null;
            playerFifthCard.Image = null;
            playerSixthCard.Image = null;

            newPlayer.setScore(0);
            computer.setScore(0);
            playerHand = new List<Card>();
            computerHand = new List<Card>();
            
            newPlayer.setHand(playerHand);
            computer.setHand(computerHand);

            deck = new Deck();
            deck.createDeck();
            deck.shuffle();
            
            dealFirstCard(players, deck);
            decideFirstTurn(players);
            checkScore();
        }

        /// <summary>
        /// Updates highscores.txt file to show on highscores form
        /// </summary>
        public void updateHighScores()
        {
            calculateTotalScore();
            //1. Retrieve new score
            string newName = playerLbl.Text;
            int newScore = newPlayer.getWinPercent();

            //2. Read highscoretxt.txt 
            //Open txt file, read data and load into these two lists
            StreamReader sr = new StreamReader("../../highscores.txt"); 

            //Read data line by line
            string line = "";
            while ((line = sr.ReadLine()) != null)//while not reaching the end 
            {
                //Extract name and score by which seperate themselves by ":" character
                string[] lineComponents = line.Split(':');
                if (lineComponents.Length > 0) //checks array has data
                {
                    playerNames.Add(lineComponents[0]);
                    playerScores.Add(Convert.ToInt16(lineComponents[1]));
                }
            }
            //Close stream
            sr.Close();

            //3. Compare to check if new score is high enough
            int minScore = playerScores.Min(); //Returns minimum score in scores list
            if (minScore >= newScore)
            {
                //new score is not high enough
                MessageBox.Show(newScore + "% is not high enough for a highscore. See you next time :)", "Sorry, " + newPlayer.getName() + "!");
            }
            else
            {
                //1. Remove lowest score and replace it by the new score
                for (int index = 0; index < playerScores.Count; index++)
                {
                    if (playerScores[index] == minScore)
                    {
                        playerScores[index] = newScore;
                        playerNames[index] = newName;
                        break;//Quit loop
                    }
                }
                //2. Implement bubble sorting algorithm to sort the highscores
                for (int index = 0; index < playerScores.Count - 1; index++)
                {
                    for (int j = 0; j < playerScores.Count - 1; j++)
                    {
                        //compare two scores[j] and scores[j+1] and swap if first is < second
                        if (playerScores[j] < playerScores[j + 1])
                        {
                            //Swap scores
                            int tempScore = playerScores[j];
                            playerScores[j] = playerScores[j + 1];
                            playerScores[j + 1] = tempScore;
                            //Swap names
                            string tempName = playerNames[j];
                            playerNames[j] = playerNames[j + 1];
                            playerNames[j + 1] = tempName;
                        }
                    }
                }
                //3. Save sorted scores back to txt file
                //Open stream
                StreamWriter sw = new StreamWriter("../../highscores.txt");
                //Write to txt file
                //Build a string containing all scores and names
                string scoreString = "";
                for (int index = 0; index < playerScores.Count; index++)
                {
                    scoreString += playerNames[index].ToUpper() + ":" + playerScores[index] + 
                        Environment.NewLine;//Adds new line
                }
                sw.Write(scoreString);
                //Close stream
                sw.Close();
                MessageBox.Show(newScore + "% is a new highscore! See you next time!", 
                    "Congratulations " + newPlayer.getName() + "!");
            }
        }

        //Change text of buttons when hovered on
        private void stopLbl_MouseEnter(object sender, EventArgs e)
        {
            stopLbl.ForeColor = Color.MediumPurple;
        }
        //Change text of buttons when hovered on
        private void stopLbl_MouseLeave(object sender, EventArgs e)
        {
            stopLbl.ForeColor = Color.White;
        }
        //Change text of buttons when hovered on
        private void pauseLbl_MouseEnter(object sender, EventArgs e)
        {
            pauseLbl.ForeColor = Color.MediumPurple;
        }
        //Change text of buttons when hovered on
        private void pauseLbl_MouseLeave(object sender, EventArgs e)
        {
            pauseLbl.ForeColor = Color.White;
        }
        //Change text of buttons when hovered on
        private void hitLbl_MouseEnter(object sender, EventArgs e)
        {
            hitLbl.ForeColor = Color.MediumPurple;
        }
        //Change text of buttons when hovered on
        private void hitLbl_MouseLeave(object sender, EventArgs e)
        {
            hitLbl.ForeColor = Color.White;
        }
        //Change text of buttons when hovered on
        private void standLbl_MouseEnter(object sender, EventArgs e)
        {
            standLbl.ForeColor = Color.MediumPurple;
        }
        //Change text of buttons when hovered on
        private void standLbl_MouseLeave(object sender, EventArgs e)
        {
            standLbl.ForeColor = Color.White;
        }

        private void highscoreLbl_MouseEnter(object sender, EventArgs e)
        {
            highscoreLbl.ForeColor = Color.MediumPurple;
        }

        private void highscoreLbl_MouseLeave(object sender, EventArgs e)
        {
            highscoreLbl.ForeColor = Color.White;
        }
    }
}
