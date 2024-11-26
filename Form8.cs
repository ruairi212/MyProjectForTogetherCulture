using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace member_space
{
    public partial class Form8 : Form
    {
        public event EventHandler PaymentCompleted;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if required fields are filled
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter your full name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus(); // Set focus to the empty field
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter your 16 digit card number.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (textBox3.Text.Length != 16 || !Is16DigitsOnly(textBox3.Text))
            {
                MessageBox.Show("Card number must be 16 digits.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
           

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter the expiration date.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter the CVV.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            // Prompt user for payment details
            string purpose = PromptForPurpose(); // Get the purpose of payment
            if (string.IsNullOrEmpty(purpose)) return;

            string memberId = PromptForMemberID(); // Get the member ID
            if (string.IsNullOrEmpty(memberId)) return;


            // Retrieve payment details
            string cardholder_Name = textBox2.Text;
            string cardNumber = textBox3.Text;
            string expiration_Date = textBox4.Text;
            string CVV = textBox5.Text;
            // Save payment to the database
            SavePaymentToDatabase(memberId, Pay_for);

            // Open confirmation form with payment details
            Form9 confirmationForm = new Form9(cardholder_Name, cardNumber, expiration_Date, CVV);
            confirmationForm.PaymentConfirmed += ConfirmationForm_PaymentConfirmed; // Event handler for confirmation
            confirmationForm.Show();
        }
        private bool Is16DigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        private void ConfirmationForm_PaymentConfirmed(object sender, EventArgs e)
        {
            // Raise the PaymentCompleted event to notify Form1
            PaymentCompleted?.Invoke(this, EventArgs.Empty);
            this.Close(); // Close Form after confirmation
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
