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
    public partial class EventCreateForm : Form
    {
        public EventCreateForm()
        {
            InitializeComponent();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void BackToEventmanage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
            EventMethods eventMethods = new EventMethods();
            var newEvent = new EventData
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
            if (eventMethods.createEvent(newEvent)) 
            {
                MessageBox.Show("Event added","success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Failed to add event","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
