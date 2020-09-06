using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        //Properties
        private List<Card> cards;

        //Constructor
        public Deck()
        {
            cards = new List<Card>(52);
        }
        
        /// <summary>
        /// Gets the deck
        /// </summary>
        /// <returns>cards(list)</returns>
        public List<Card> getDeck()
        {
            return cards;
        }

        /// <summary>
        /// creates the deck (adds cards to cards list)
        /// </summary>
        public void createDeck()
        {
            int valueHolder = 1;
            int imgNum = 1;
            
            for (int cardindex = 0; cardindex <= 12; cardindex++)
            {
                string[] suit = { "clubs", "spades", "diamonds", "hearts" };

                PictureBox newCardImage = new PictureBox();
                
                for (int suitindex = 0; suitindex <= 3; suitindex++)
                {
                    if (valueHolder > 10)
                    {
                        valueHolder = 10;
                    }

                    Card newCard = new Card(valueHolder, imgNum, suit[suitindex], newCardImage);
                    cards.Add(newCard);
                    imgNum++;
                }
                valueHolder++;
            }
        }

        /// <summary>
        /// Adds the image to the picturebox
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public PictureBox addImage(PictureBox pb, int number)
        {
            PictureBox newPb = new PictureBox();

            for (int index = 0; index <= 52; index++)
            {
                if(index == number)
                {
                    Image image = Image.FromFile(@"..\..\Deck\" + number + ".png");

                    pb.Image = image;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    newPb = pb;
                }
            }
            return pb;
        }

        /* //For checking
        public string toString()
        {
            string report = "";

            foreach (Card card in cards)
            {
                report += card.getSuit() + " " + card.getCardValue().ToString() + " " + card.getImgNum().ToString() + "\n";
            }

            return report;
        }*/
        /// <summary>
        /// Shuffles by swapping the first random card with the second random card, repeating 52 times for 52 cards
        /// </summary>
        public void shuffle()
        {
            Random random = new Random();

            for (var index = 0; index <= 51; index++)
            {
                int firstCard = random.Next(0, 52);
                int secondCard = random.Next(0, 52);

                if (firstCard != secondCard)
                {
                    var holder = cards[firstCard];
                    cards[firstCard] = cards[secondCard];
                    cards[secondCard] = holder;
                }
            }
        }
    }
}
