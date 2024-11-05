using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace member_space
{
    public partial class Form9 : Form
    {
        public event EventHandler PaymentConfirmed;
        public Form9(string cardholderName, string cardNumber, string expirationDate, string amount)
        {
            InitializeComponent();
            // Display payment details in labels
            label1.Text = "Cardholder Name: " + cardholderName;
            label2.Text = "Card Number: " + cardNumber;
            label3.Text = "Expiration Date: " + expirationDate;
            label4.Text = "Amount: $" + amount;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show confirmation message
            MessageBox.Show("Payment has been processed successfully!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Raise the PaymentConfirmed event to notify Form2
            PaymentConfirmed?.Invoke(this, EventArgs.Empty);

            this.Close(); // Close the confirmation form
        }
    }
}
