using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace member_space
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            // Set the text in the TextBox to the received text
            textBox1.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
