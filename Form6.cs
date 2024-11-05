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
    public partial class Form6 : Form
    {
        public Form6(string textToDisplay, string textToDisplay1, string textToDisplay2, string textToDisplay3, string textToDisplay4)
        {
            InitializeComponent();
            textBox1.Text = textToDisplay;
            textBox2.Text = textToDisplay1;
            textBox3.Text = textToDisplay2;
            textBox4.Text = textToDisplay3;
            textBox5.Text = textToDisplay4;

            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
