using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssociationRelationshipApp
{
    public partial class CustomerAndAccountUI : Form
    {
        private Customer aCustomer;
        public CustomerAndAccountUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account anAccount = new Account();
            anAccount.AccountNumber = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = openingDateEntryTextBox.Text;

            aCustomer = new Customer();
            aCustomer.CustomerName = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            aCustomer.CustomerAccount = anAccount;

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.GetDeposit(amount);
                MessageBox.Show("Deposited Successfully..");
            }
            else
            {
                MessageBox.Show("Create An Account First...!!!!!!!!!!!!");
            }
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.GetWithdraw(amount);
                MessageBox.Show("Withdrawn Successfully..");
            }
            else
            {
                MessageBox.Show("Create An Account First...!!!!!!!!!!!!");
            }
           
        }

        private void showMeDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameDetailsTextBox.Text = aCustomer.CustomerName;
            emailDetailsTextBox.Text = aCustomer.Email;
            accountNumberDetailsTextBox.Text = aCustomer.CustomerAccount.AccountNumber;
            openingDateDetailsTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
