using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        //Properties
        private int cardValue;
        private int imgNum;
        private string suit;
        private PictureBox image;

        //Constructor
        public Card(int cardValue, int imgNum, string suit, PictureBox image)
        {
            this.cardValue = cardValue;
            this.imgNum = imgNum;
            this.suit = suit;
            this.image = image;
        }

        /// <summary>
        /// Sets the value
        /// </summary>
        /// <param name="cardValue"></param>
        public void setCardValue(int cardValue)
        {
            this.cardValue = cardValue;
        }

        /// <summary>
        /// Gets the value
        /// </summary>
        /// <returns>cardValue (int)</returns>
        public int getCardValue()
        {
            return cardValue;
        }
        
        /// <summary>
        /// Sets image number
        /// </summary>
        /// <param name="imgNum"></param>
        public void setImgNum(int imgNum)
        {
            this.imgNum = imgNum;
        }

        /// <summary>
        /// Gets image number
        /// </summary>
        /// <returns>imgNum(int)</returns>
        public int getImgNum()
        {
            return imgNum;
        }

        /// <summary>
        /// Gets the suit
        /// </summary>
        /// <param name="suit"></param>
        public void setSuit(string suit)
        {
            this.suit = suit;
        }

        /// <summary>
        /// Sets the suit
        /// </summary>
        /// <returns>suit(string)</returns>
        public string getSuit()
        {
            return suit;
        }

        /// <summary>
        /// Set the image
        /// </summary>
        /// <param name="image"></param>
        public void setImage(PictureBox image)
        {
            this.image = image;
        }

        //Get the image
        public PictureBox getImage()
        {
            return image;
        }
    }
}
