﻿using System;
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
    public partial class EventSearch : Form
    {
        public EventSearch()
        {
            InitializeComponent();
            load_Events();
        }
        public void load_Events() 
            //load the events found using  GetEvents into the dataSource displayed 
        {
            EventMethods eventMethods = new EventMethods();
            var events = eventMethods.GetEvents();
            EventDatadisplay.DataSource = events.Select(e => new 
            {
            e.EventID,
            e.Date,
            e.EventName,
            e.Description,
            e.Type,
            e.Duration,
            e.Address,
            e.BuildingName,
            e.Postcode,
            e.AdminID,
            e.MaxCapacity}).ToList();
             
        }

        public bool ValidateEventInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(EventIDtextbox.Text))
            {
                errorMessage = "No event selected. Please select one and try again.";
                return false;
            }

            if (!int.TryParse(EventIDtextbox.Text, out int createdID))
            {
                errorMessage = "Event ID must be a valid number.";
                return false;
            }
            int originalID = int.Parse(EventIDtextbox.Text);
            
            if (originalID != createdID && EventIDExists(createdID))
            {
                errorMessage = "The Event ID already exists. Please try again";
                return false;
            }

            if (string.IsNullOrEmpty(AdminIDText1.Text) ||
                string.IsNullOrEmpty(AddressTB.Text) ||
                string.IsNullOrEmpty(PostcodeTB.Text) ||
                string.IsNullOrEmpty(BuildingnameTB.Text) ||
                string.IsNullOrEmpty(EventtypeTB.Text) ||
                string.IsNullOrEmpty(EventCapTB.Text) ||
                string.IsNullOrEmpty(EventDuraTB.Text) ||
                string.IsNullOrEmpty(EventNameTB.Text) ||
                string.IsNullOrEmpty(descTB.Text))
            {
                errorMessage = "All fields must be filled out.";
                return false;
            }

            if (!int.TryParse(EventDuraTB.Text, out _) || !int.TryParse(EventCapTB.Text, out _))
            {
                errorMessage = "Duration and Max Capacity must be valid numbers.";
                return false;
            }

            return true;
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EventID1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void createbutton_Click(object sender, EventArgs e)
        {
            EventCreateForm createevent = new EventCreateForm();
            createevent.Show();
        }

        public void editbutton_Click(object sender, EventArgs e)
        {
            
                if (EventDatadisplay.SelectedRows.Count == 0) 
                {
             
                   MessageBox.Show("Please Select an event to edit from the display","No event Selected",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = EventDatadisplay.SelectedRows[0];
                var eventName = selectedRow.Cells["EventName"].Value.ToString();

                var confirmName = MessageBox.Show($"Is this the event you want to edit '{eventName}'?","confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmName == DialogResult.Yes)
                {
                    EventIDtextbox.Text = selectedRow.Cells["EventID"].Value.ToString();
                    AdminIDText1.Text = selectedRow.Cells["AdminID"].Value.ToString();
                    AddressTB.Text = selectedRow.Cells["Address"].Value.ToString();
                    PostcodeTB.Text = selectedRow.Cells["PostCode"].Value.ToString();
                    BuildingnameTB.Text = selectedRow.Cells["BuildingName"].Value.ToString();
                    EventNameTB.Text = selectedRow.Cells["EventName"].Value.ToString();
                    EventtypeTB.Text = selectedRow.Cells["Type"].Value.ToString();
                    EventCapTB.Text = selectedRow.Cells["MaxCapacity"].Value.ToString();
                    EventDuraTB.Text = selectedRow.Cells["Duration"].Value.ToString();
                    descTB.Text = selectedRow.Cells["Description"].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells["Date"].Value.ToString());
                    MessageBox.Show(" press 'Save Changes' to update when finished", "Edit Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
        }


        public bool EventIDExists(int eventID)
        {
            //Checks if input ID exists
            EventMethods eventMethods = new EventMethods();
            var events = eventMethods.GetEvents();  // Get the list of events

            // Check if any event has the same EventID
            return events.Any(e => e.EventID == eventID);
        }
        public void savechangesbutton_Click(object sender, EventArgs e)
        {
            if (!ValidateEventInputs(out string errorMessage)) 
            {   
                MessageBox.Show(errorMessage,"Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure you want to save the changes to this event?","Confirm Save Changes",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes) 
            {
                var EventMethods = new EventMethods();
                var updatedEvent = new EventData
                {
                    EventID = int.Parse(EventIDtextbox.Text),
                    AdminID = int.Parse(AdminIDText1.Text),
                    Address = AddressTB.Text,
                    Postcode = PostcodeTB.Text,
                    BuildingName = BuildingnameTB.Text,
                    Type = EventtypeTB.Text,
                    Description = descTB.Text,
                    Date = dateTimePicker1.Value,
                    Duration = int.Parse(EventDuraTB.Text),
                    MaxCapacity = int.Parse(EventCapTB.Text),
                    EventName = EventNameTB.Text
                };
                var eventMethods = new EventMethods();
                if (eventMethods.UpdateEvent(updatedEvent)) 
                {
                    MessageBox.Show("Event Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Events();
                }
                else 
                {
                    MessageBox.Show("Errpr Updating Event","Errpr",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            load_Events();
        }
    }
}
