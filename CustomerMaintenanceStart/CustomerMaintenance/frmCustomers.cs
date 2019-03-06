using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        // Step 9.
        private List<Customer> customers = null;

        // Step 11.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a new instance of the Add Customer form
            frmAddCustomer newAddCustomerForm = new frmAddCustomer();
            Customer customer = newAddCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        // Step 10.
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }
        // Also Step 10.
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

        // Step 12
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = "Are you sure you want to delete "
                    + customer.GetDisplayText() + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}