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
            TestCustomerAll();
            TestCustomerListAll();


            Console.WriteLine("END OF PROGRAM");
            Console.ReadLine();
        }

        // to call all the Customer tests
        static void TestCustomerAll()
        {
            EmailTester();
            FirstNameTester();
            LastNameTester();
            TestGetDisplayText();
        }

        // to call all the CustomerList tests
        static void TestCustomerListAll()
        {
            TestCustomerListConstructor();
            TestCustomerListAdd();
        }

        // test the constructor
        static void TestCustomerListConstructor()
        {
            CustomerList cList = new CustomerList();  // make a new CustomerList

            Console.WriteLine("Testing constructor");
            Console.WriteLine("Default constructor. Expecting Count of 0 " + cList.Count);
            Console.WriteLine("Default constructor. Expecting empty string " + cList);
            Console.WriteLine();
        }

        static void TestCustomerListAdd()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Simon", "Wiggle", "swiggle@wiggles.com");
            Customer c3 = new Customer("Lachy", "Wiggle", "lwiggle@wiggles.com");

            Console.WriteLine("Testing Add...");
            cList.Add(c1);
            Console.WriteLine("Add that takes a customer parameter");
            Console.WriteLine("Expecting count of 1 " + cList.Count);
            Console.WriteLine("Expecting List of 1 customers:\n" + cList);
            cList.Add("Henry", "TheOctopus", "hoctopus@wiggles.com");
            Console.WriteLine("Add that takes the 3 customer parameters");
            Console.WriteLine("Expecting count of 2: " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers:\n" + cList);
            cList += c3;
            Console.WriteLine("Testing overloaded + operator");
            Console.WriteLine("Expecting count of 3 " + cList.Count);
            
            Console.WriteLine("Expecting list of 3 customers:\n" + cList);
            Console.WriteLine();
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
