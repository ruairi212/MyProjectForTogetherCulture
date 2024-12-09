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
    }
}
