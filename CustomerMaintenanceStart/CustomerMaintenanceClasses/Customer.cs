using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        // fields
        private string firstName;
        private string lastName;
        private string email;

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                this.email = value;
            }
        }

        // Method
        public string GetDisplayText() => firstName + " " + lastName + ", " + email;

        // Constructors
        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}
