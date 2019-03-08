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
        private int count;

        // properties
        public int Count
        {
            get
            {
                return count;
            }
        }

        // constructors
        public Deck()
        {
            // default constructor
            for(int suit = 0; suit < 4; suit++)
            {
                for(int value = 0; value < 13; value++)
                {
                    // make a card

                    // add it to the deck
                }
            }
        }
    }
}
