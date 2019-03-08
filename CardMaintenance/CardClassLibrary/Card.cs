using System;

namespace CardClassLibrary
{
    public class Card
    {
        // fields
        private int suit; // suit can range from 1 - 4
        public static string[] suits = new string[5] {"????", "clubs", "diamonds", "hearts", "spades" };
        private int value; // value can range from 1 - 13
        public static string[] values = new string[14] { "????", "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

        // properties
        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                this.suit = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        // methods

        public Card()
        {
            // ...default constructor
        }

        public Card(int value, int suit)
        {
            // ...overloaded constructor
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            // returns a string for the value and suit.
            // for example: 7 of clubs 
            return Card.values[value] + " of " + Card.suits[suit];
        }

        public bool IsClub()
        {
            // returns true if the card is a club,
            // false if it isn't
            return (Card.suits[suit] == "clubs") ? true : false;
        }

        public bool IsDiamond()
        {
            // returns true if the card is a Diamond,
            // false if it isn't
            return (Card.suits[suit] == "diamonds") ? true : false;
        }


        public bool IsHeart()
        {
            // returns true if the card is a Heart,
            // false if it isn't
            return (Card.suits[suit] == "hearts") ? true : false;
        }

        public bool IsSpade()
        {
            // returns true if the card is a Spade,
            // false if it isn't
            return (Card.suits[suit] == "spades") ? true : false;
        }

    }
}
