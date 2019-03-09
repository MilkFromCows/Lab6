using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;

namespace DeckTester
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDeckAll();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("END OF PROGRAM");
            Console.ReadLine();
        }

        static void TestDeckAll()
        {
            TestConstructors();
        }

        static void TestConstructors()
        {
            Console.WriteLine("Testing constructor...");
            Deck deck = new Deck();
            Console.WriteLine("Expecting that I just instantiated a Deck object ");
            Console.WriteLine(deck);
            Console.WriteLine("Testing numCards: expecting 52 " + deck.NumCards.ToString());
            //Console.WriteLine("Testing individual cards: " + deck[0]);

        }
    }
}
