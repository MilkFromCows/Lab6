using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;

namespace CardTester
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConstructors();
            TestSuit();
            TestSuits();
            TestValue();
            TestValues();
            TestToString();
            TestIsClub();
            TestIsDiamond();
            TestIsHeart();
            TestIsSpade();

            Console.WriteLine("END OF PROGRAM");
            Console.ReadLine();
        }

        static void TestConstructors()
        {
            Console.WriteLine("Testing default constructor...");
            Card card2S = new Card();

            Console.WriteLine("Expecting: 0\t" + card2S.Value);


            Console.WriteLine("Expecting: 0\t" + card2S.Suit);

            Console.WriteLine("Testing overloaded constructor...");
            Card qH = new Card(12, 3);
            Console.WriteLine("Expecting: queen\t" + Card.values[qH.Value]);
            Console.WriteLine("Expecting: hearts\t" + Card.suits[qH.Suit]);
        }

        static void TestSuit()
        {
            Console.WriteLine("Testing Suit...");

            Card c1 = new Card(7, 1); // make a 7 of clubs
            Console.WriteLine("Expecting: clubs\t" + Card.suits[c1.Suit]);
            c1.Suit = 2; // change it to diamonds
            Console.WriteLine("Expecting: diamonds\t" + Card.suits[c1.Suit]);

        }

        static void TestSuits()
        {
            Console.WriteLine("Testing suits...");
            Console.WriteLine("Expecting: ???? clubs diamonds hearts spades");
            Console.Write("           "); // for formatting
            for (int i = 0; i < Card.suits.Length; i++)
            {
                Console.Write(Card.suits[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void TestValue()
        {
            Console.WriteLine("Testing Value...");

            Card c1 = new Card(1, 1); // make a 7 of clubs
            Console.WriteLine("Expecting: ace\t" + Card.values[c1.Value]);
            c1.Value = 4; // change it to diamonds
            Console.WriteLine("Expecting: 4\t" + Card.values[c1.Value]);

        }

        static void TestValues()
        {
            Console.WriteLine("Testing values...");
            Console.WriteLine("Expecting: ???? ace 2 3 4 5 6 7 8 9 10 jack queen king");
            Console.Write("           ");
            for (int i = 0; i < Card.values.Length; i++)
            {
                Console.Write(Card.values[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void TestToString()
        {
            Console.WriteLine("Testing ToString...");
            Card c1 = new Card();     // make a default card
            Card c2 = new Card(7, 1); // make a 7 of clubs
            Console.WriteLine("Expecting: ???? of ????\t" + c1.ToString());
            Console.WriteLine("Expecting: 7 of clubs\t" + c2.ToString());
        }

        static void TestIsClub()
        {
            // tests the IsClub method in the Card class
            Console.WriteLine("Testing IsClub...");

            // make 2 cards, one a club, one not
            Card c1 = new Card(2, 1); // make a 2 of clubs
            Card c2 = new Card(3, 3); // make a 3 of hearts

            // test them both. Should get a true and a false.
            string output1 = (c1.IsClub()) ? "true" : "false";
            string output2 = (c2.IsClub()) ? "true" : "false";

            // write the results to the screen
            Console.WriteLine("Expecting: true\t\t" + output1);
            Console.WriteLine("Expecting: false\t" + output2);
        }

        static void TestIsDiamond()
        {
            // tests the IsDiamond method in the Card class
            Console.WriteLine("Testing IsDiamond...");

            // make 2 cards, one a diamond, one not
            Card c1 = new Card(2, 2); // make a 2 of diamonds
            Card c2 = new Card(3, 3); // make a 3 of hearts

            // test them both. Should get a true and a false.
            string output1 = (c1.IsDiamond()) ? "true" : "false";
            string output2 = (c2.IsDiamond()) ? "true" : "false";

            // write the results to the screen
            Console.WriteLine("Expecting: true\t\t" + output1);
            Console.WriteLine("Expecting: false\t" + output2);
        }

        static void TestIsHeart()
        {
            // tests the IsHeart method in the Card class
            Console.WriteLine("Testing IsHeart...");

            // make 2 cards, one a heart, one not
            Card c1 = new Card(2, 3); // make a 2 of hearts
            Card c2 = new Card(3, 2); // make a 3 of diamonds

            // test them both. Should get a true and a false.
            string output1 = (c1.IsHeart()) ? "true" : "false";
            string output2 = (c2.IsHeart()) ? "true" : "false";

            // write the results to the screen
            Console.WriteLine("Expecting: true\t\t" + output1);
            Console.WriteLine("Expecting: false\t" + output2);
        }

        static void TestIsSpade()
        {
            // tests the IsSpade method in the Card class
            Console.WriteLine("Testing IsSpade...");

            // make 2 cards, one a spade, one not
            Card c1 = new Card(2, 4); // make a 2 of spades
            Card c2 = new Card(3, 2); // make a 3 of diamonds

            // test them both. Should get a true and a false.
            string output1 = (c1.IsSpade()) ? "true" : "false";
            string output2 = (c2.IsSpade()) ? "true" : "false";

            // write the results to the screen
            Console.WriteLine("Expecting: true\t\t" + output1);
            Console.WriteLine("Expecting: false\t" + output2);
        }
    }
}
