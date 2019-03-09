using System;
using System.Collections.Generic;
using System.Text;

namespace CardClassLibrary
{
    public class Deck
    {
        // Deck()
        // NumCards
        // isEmpty()
        // Card Deal()
        // Shuffle()
        // string ToString()

        // fields
        private List<Card> deck;
        private int numCards = 0;

        // properties
        public int NumCards
        {
            get
            {
                return numCards;
            }
        }

        // constructors
        public Deck()
        {
            // default constructor

            // instantiate the deck
            deck = new List<Card>();

            // loop through 52 cards to be
            for(int suit = 1; suit < 5; suit++)
            {
                for(int value = 1; value < 14; value++)
                {
                    // make a card
                    Card card = new Card(value, suit);

                    // add it to the deck
                    deck.Add(card);

                    // increment numCards
                    numCards++;
                }
            }
        }
    }
}
