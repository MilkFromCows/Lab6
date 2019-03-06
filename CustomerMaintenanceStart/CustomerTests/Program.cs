using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {

            EmailTester();
            FirstNameTester();
            LastNameTester();
            TestGetDisplayText();

            Console.WriteLine("END OF PROGRAM");
            Console.ReadLine();
        }

        static void EmailTester()
        {
            try
            {
                Console.WriteLine("Testing email");

                Customer c1 = new Customer(); // make a new customer using default constructor
                Console.WriteLine("expecting a null character.  ");
                if (c1.Email == null)
                {
                    Console.WriteLine("Email value is null");
                }
                Customer c2 = new Customer("Bob", "Wiggles", "bloopybloop@yahoo.com");
                Console.WriteLine("expecting bloopybloop@yahoo.com\t" + c2.Email);
                c1.Email = "meow@moogles.com";
                Console.WriteLine("expecting meow@moogles.com\t" + c1.Email);
                c2.Email = "meow@moogles.com";
                Console.WriteLine("expecting meow@moogles.com\t" + c2.Email);
                Console.WriteLine("Testing setters exceptions");
                Console.WriteLine("Expecting exception for email");
                c2.Email = "123456789101234567891012345678910@something.com";
            }
            catch(ArgumentException)
            {
                Console.WriteLine("caught the email length exception.");
            }
            

       

        }


        static void FirstNameTester()
        {
            Console.WriteLine("Testing firstName");
            Customer c1 = new Customer(); // make a new customer using default constructor
            Console.WriteLine("FirstName: expecting a null character.  ");
            if (c1.FirstName == null)
            {
                Console.WriteLine("FirstName value is null");
            }
            Customer c2 = new Customer("Bob", "Wiggles", "bloopybloop@yahoo.com");
            Console.WriteLine("expecting Bob\t" + c2.FirstName);

            c1.FirstName = "Susan";
            Console.WriteLine("expecting Susan\t" + c1.FirstName);
            c2.FirstName = "Susan";
            Console.WriteLine("expecting Susan\t" + c2.FirstName);
        }

        static void LastNameTester()
        {
            Console.WriteLine("Testing lastName");
            Customer c1 = new Customer(); // make a new customer using default constructor
            Console.WriteLine("expecting a null character.  ");
            if (c1.LastName == null)
            {
                Console.WriteLine("LastName value is null");
            }
            Customer c2 = new Customer("Bob", "Wiggles", "bloopybloop@yahoo.com");
            Console.WriteLine("expecting Wiggles\t" + c2.LastName);
            c1.LastName = "Susans";
            Console.WriteLine("expecting Susans\t" + c1.LastName);
            c2.LastName = "Susans";
            Console.WriteLine("expecting Susans\t" + c2.LastName);
        }

        static void TestGetDisplayText()
        {
            Console.WriteLine("Testing getDisplayText method");

            Customer c1 = new Customer(); // make a new customer using default constructor
            Customer c2 = new Customer("Bob", "Wiggles", "bloopybloop@yahoo.com");

            Console.WriteLine("Expecting null null, null:\t" + c1.GetDisplayText());
            Console.WriteLine("Expecting Bob Wiggles, bloopybloop@yahoo.com:\t" 
                               + c2.GetDisplayText());
        }

    }
}
