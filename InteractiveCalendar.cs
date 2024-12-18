using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ServiceStack.Text.RecyclableMemoryStreamManager;

namespace member_space
{
    public partial class InteractiveCalendar : Form
    {
        string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";

        public void ConnectionCheck() 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MessageBox.Show("connected successfully");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public InteractiveCalendar()
        {
            
            ConnectionCheck();
            InitializeComponent();
            calendar_creator(DateTime.Now.Year, DateTime.Now.Month);
        }
        private void calendar_creator(int year, int month)
        {
            //This will clear the previous controls
            Calendar.Controls.Clear();

            //This will get the first day of the month so we can create the ordering of the panels off of it
            DateTime month_Start = new DateTime(year, month, 1);

            //This will calculate the days in the current month to get number of panels needed
            int days_In_Month = DateTime.DaysInMonth(year, month);

            //This gets the day of the week of the first date
            int first_Day = (int)month_Start.DayOfWeek ;
            
            int panel_Width = 156;
            int panel_Height = 100;
            EventMethods eventMethods = new EventMethods();
            DateTime month_End = new DateTime(year, month, days_In_Month);
            List<EventData> monthEvents = eventMethods.getEventsByMonth(month_Start, month_End);
           
            //This will loop through the days in the month creating a button for each day
            for (int i = 1; i <= days_In_Month; i++) {
                //Calc the rows needed
                int col = (first_Day + i - 1) % 7;
                int row = (first_Day + i - 1) / 7;
                DateTime buttonDate = new DateTime(year,month,i);
                List<EventData> events = monthEvents.Where(e => e.Date.Date == buttonDate).ToList();
                string suffix = eventMethods.suffixHelp(i);
                //Create the new button each iteration
                Button day_Button = new Button
                {
                    Size = new Size(panel_Width - 5, panel_Height - 5),
                    Location = new Point(col * panel_Width, row * panel_Height),
                    Text = i.ToString() + suffix,
                    TextAlign = ContentAlignment.TopLeft,
                    
              
                    BackColor = Color.IndianRed,
                    Tag = new DateTime(year, month, i)
                };
                if (events.Count > 0 )
                {
                    string eventName = string.Join(",", events.Select(e => e.EventName));
                    day_Button.Text = $"{i}\n\n{  eventName}";
                 }
                DateTime currentDate = new DateTime(year, month, i);
                
                day_Button.Click += day_Button_Click;
                
            
            Calendar.Controls.Add(day_Button);
            
            }

        }
        private void day_Button_Click(object sender, EventArgs e) 
        {
            //If a button is clicked to indicate a booking it will open the bookingform
            Button clicked = sender as Button; 
            if (clicked != null) 
            {  
                DateTime date_Selected = (DateTime)clicked.Tag;
                EventMethods eventMethods = new EventMethods();
                List <EventData> events = eventMethods.getEventsByMonth(date_Selected,date_Selected);
                string event_Name;
                if (events.Count > 0)
                {
                    event_Name = ""; // Initialize an empty string
                    foreach (var i in events)
                    {
                        if (!string.IsNullOrEmpty(event_Name))
                        {
                            event_Name += ", "; // Add a separator between event names
                        }
                        event_Name += i.EventName; // Append the event name
                    }
                }
                else
                {
                    event_Name = "No events for this date"; // Default message
                }
                EventBooking booking = new EventBooking(date_Selected,event_Name);
                booking.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InteractiveCalendar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
