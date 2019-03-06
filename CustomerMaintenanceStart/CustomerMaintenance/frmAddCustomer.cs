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

    public partial class frmAddCustomer : Form
    {

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        // Step 5. 
        private Customer customer = null;

        // Step 6.
        public Customer GetNewCustomer()
        {
            // Display the form as a dialog box
            // and return a customer object
            this.ShowDialog();
            return customer;
        }

        // Step 7.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        // Also Step 7.
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                   Validator.IsPresent(txtLastName)  &&
                   Validator.IsPresent(txtEmail)     &&
                   Validator.IsValidEmail(txtEmail);
        }

        // Step 8. Just close the form if they hit cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}