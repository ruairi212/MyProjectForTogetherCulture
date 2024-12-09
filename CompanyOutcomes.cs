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
    public partial class CompanyOutcomes : Form
    {

        private dataBaseHelper _dbHelper;

        public CompanyOutcomes()
        {
            InitializeComponent();
            _dbHelper = new dataBaseHelper();
            LoadCompanyMetrics();

        }
        private void LoadCompanyMetrics()
        {
            string query = @"
                SELECT 
                    c.CompanyName,
                    COUNT(co.OutcomeID) AS TotalOutcomes,
                    SUM(co.RevenueGenerated) AS TotalRevenueGenerated
                FROM 
                    Company c
                LEFT JOIN 
                    CompanyOutcomes co ON c.CompanyID = co.CompanyID
                GROUP BY 
                    c.CompanyName
                ORDER BY 
                    TotalRevenueGenerated DESC";

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection conn = dbConnection.get_Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(table);

                        dgvCompanyOutcomes.DataSource = table;

                        // Customize DataGridView appearance
                        dgvCompanyOutcomes.Columns["CompanyName"].HeaderText = "Company Name";
                        dgvCompanyOutcomes.Columns["TotalOutcomes"].HeaderText = "Total Ventures";
                        dgvCompanyOutcomes.Columns["TotalRevenueGenerated"].HeaderText = "Revenue Generated ($)";
                        dgvCompanyOutcomes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading metrics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}