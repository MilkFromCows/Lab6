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
            TestCount();
            TestIsEmpty();
            TestToString();
            TestDeal();
            TestShuffle();
        }

        static void TestConstructors()
        {
            Deck deck = new Deck();
            Console.WriteLine("Testing constructor: expecting a bunch of cards\n" + deck);
            Console.WriteLine();
        }

        static void TestCount()
        {
            Deck deck = new Deck();
            Console.WriteLine("Testing Count: expecting 52 " + deck.Count.ToString());
            Console.WriteLine();
        }

        static void TestIsEmpty()
        {
            Deck deck = new Deck();
            Console.WriteLine("Testing IsEmpty(): expecting False " + deck.IsEmpty());
            for (int i = 0; i < 52; i++)
            {
                Card card = deck.Deal();
                Console.WriteLine(card + " has been dealt");
            }
            Console.WriteLine("Testing IsEmpty(): expecting True " + deck.IsEmpty());
            Console.WriteLine("After dealing, deck has " + deck.Count + " cards.");
            Console.WriteLine();
        }

        static void TestToString()
        {
            Deck deck = new Deck();
            Console.WriteLine("Testing ToString(): expecting a bunch of cards\n");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
        }

        static void TestDeal()
        {
            Deck deck = new Deck();
            Console.WriteLine("Testing Deal: expecting 52 " + deck.Count);
            Card card = deck.Deal();
            Console.WriteLine("Testing Deal: expecting 51 " + deck.Count);   
            Console.WriteLine("Testing Deal: expecting ace of clubs " + card);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void TestShuffle()
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine("Testing Shuffle: expecting a shuffled deck\n" + deck);
            
        }
    }
}
