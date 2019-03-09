using System;
using System.Collections.Generic;
using System.Text;

namespace CardClassLibrary
{
    public class Deck
    {
        // Deck()
        // Count
        // isEmpty()
        // Card Deal()
        // Shuffle()
        // string ToString()

        // fields
        private List<Card> deck;

        // properties
        public int Count
        {
            get
            {
                return deck.Count;
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
                }
            }
        }

        // methods
        public bool IsEmpty()
        {
            bool isEmpty = false;
            if(deck.Count == 0)
            {
                isEmpty = true;
            }
            return isEmpty;
        }
        
        public Card Deal()
        {
            Card card;
            if (deck.Count > 0)
            {
                card = deck[0];
                deck.Remove(card);
            }
            else
            {
                card = null;
            }
            return card;
        }

        public void Shuffle()
        {
            // shuffles the deck
            // make a random number generator
            // LOOP
            //  get a random number
            //  temp gets card1
            //  card1 gets random card
            //  random card gets temp
            // END LOOP
            
            Random generator = new Random();
            int size = deck.Count;
            for (int i = 0; i < size; i++)
            {
                int rand = generator.Next(1, size);
                
                Card temp = deck[i]; // temp gets card1
                deck[i] = deck[rand]; // card1 gets random card
                deck[rand] = temp; // random card gets temp
            }

        }

        public override string ToString()
        {
            string cards = "";
            for(int i = 0; i < deck.Count; i++)
            {
                cards += deck[i].ToString();
                cards += "\n";
            }
            return cards;
        }
    }
}
