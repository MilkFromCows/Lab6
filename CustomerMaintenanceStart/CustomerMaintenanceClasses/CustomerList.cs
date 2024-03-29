﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        // fields
        private List<Customer> customers;

        // constructors
        public CustomerList()
        {
            customers = new List<Customer>();
        }

        // indexer
        public Customer this[int i]
        {
            get
            {
                if (i < 0 || i >= customers.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());    
                }
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        // properties
        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        // expression bodied methods Fill() and Save()
        public void Fill() => customers = CustomerDB.GetCustomers();

        public void Save() => CustomerDB.SaveCustomers(customers);

        public void Add(Customer customer)
        {
            customers.Add(customer);
            //Changed(this);
        }

        public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            customers.Add(c);
            //Changed(this); 
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            //Changed(this);
        }

        // overloaded + operator
        public static CustomerList operator + (CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        // overloaded - operator
        public static CustomerList operator - (CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer c in customers)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
    }
}
