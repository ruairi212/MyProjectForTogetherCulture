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
    public partial class Form5 : Form
    {
        public Form5(string text)
        {
            InitializeComponent();
            richTextBox1.Text = text; 

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
