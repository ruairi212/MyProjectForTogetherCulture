using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace member_space
{
    public partial class BillingHistory : Form
    {
        private string connectionString = "server=localhost;user=Dheerajk;password=;database=together_culture;";
        private int memberId;
        public BillingHistory(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId; // Store the Member ID for filtering
            LoadBillingHistory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Load billing history when the form loads
            LoadBillingHistory();
        }
        private void LoadBillingHistory()
        {
            string query = @"
                SELECT 
                    member.MemberID AS 'Member ID',
                    member.FirstName AS 'Name',
                    member.Email AS 'Email',
                    billings.PaymentID AS 'Billing ID',
                    billings.PaymentType AS 'Type',
                    billings.Payment_Date AS 'Payment Date'
                FROM 
                    member
                LEFT JOIN 
                    billings 
                ON 
                    member.MemberID = billings.MemberID
                WHERE 
                    member.MemberID = @MemberID
                ORDER BY 
                    billings.Payment_Date DESC" ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
