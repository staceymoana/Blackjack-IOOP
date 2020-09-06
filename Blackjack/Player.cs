using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        //Properties
        private string name = "Player 1";
        private int score = 0;
        private List<Card> hand;
        private int wins = 0;
        private bool standing = false;
        private bool turn = false;
        private int winPercent = 0;

        //Constructor
        public Player(string name, int score, List<Card> hand, int wins, bool standing, bool turn, int winPercent)
        {
            this.name = name;
            this.score = score;
            this.hand = hand;
            this.wins = wins;
            this.standing = standing;
            this.turn = turn;
            this.winPercent = winPercent;
        }

        /// <summary>
        /// Sets player's name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets player's name
        /// </summary>
        /// <returns>player name: string</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Sets player's score
        /// </summary>
        /// <param name="score"></param>
        public void setScore(int score)
        {
            this.score = score;
        }

        /// <summary>
        /// Gets player's score
        /// </summary>
        /// <returns>player's score: int</returns>
        public int getScore()
        {
            return score;
        }


        /// <summary>
        /// Increases score by inputted value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>updated score: int</returns>
        public int increaseScore(int value)
        {
            score += value;

            return value;
        }

        /// <summary>
        /// Sets player's cards in their hand
        /// </summary>
        /// <param name="hand"></param>
        public void setHand(List<Card> hand)
        {
            this.hand = hand;   
        }

        /// <summary>
        /// Returns player's cards in their hand
        /// </summary>
        /// <returns>List of cards in player hand: List of Cards</returns>
        public List<Card> getHand()
        {
            return hand;
        }
        
        /// <summary>
        /// Set's amount of player's wins
        /// </summary>
        /// <param name="wins"></param>
        public void setWins(int wins)
        {
            this.wins = wins;
        }

        /// <summary>
        /// Gets amount of player's wins
        /// </summary>
        /// <returns>Number of player wins: int</returns>
        public int getWins()
        {
            return wins;
        }

        /// <summary>
        /// Increases wins by 1
        /// </summary>
        public void increaseWins()
        {
            int newWins = getWins();
            newWins += 1;
            setWins(newWins);
        }

        /// <summary>
        ///  Set's player as "standing"
        /// </summary>
        /// <param name="standing"></param>
        public void setStanding(bool standing)
        {
            this.standing = standing;
        }

        /// <summary>
        /// Get's player's "standing" bool
        /// </summary>
        /// <returns>If standing: true, else: false: bool</returns>
        public bool getStanding()
        {
            return standing;
        }

        /// <summary>
        /// Set's a players turn
        /// </summary>
        /// <param name="turn"></param>
        public void setTurn(bool turn)
        {
            this.turn = turn;
        }

        /// <summary>
        /// Gets player's "turn" bool
        /// </summary>
        /// <returns>If its their turn: true, else: false: bool</returns>
        public bool getTurn()
        {
            return turn;
        }
        
        /// <summary>
        /// Set's a player's win percent 
        /// </summary>
        /// <param name="winPercent"></param>
        public void setWinPercent(int winPercent)
        {
            this.winPercent = winPercent;
        } 

        /// <summary>
        /// Get's player's win percent
        /// </summary>
        /// <returns>Player's win percent: int</returns>
        public int getWinPercent()
        {
            return winPercent;
        }
    }
}
