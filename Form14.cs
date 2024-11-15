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
    public partial class Form14 : Form
    {
        private List<Feedback> feedbackList = new List<Feedback>();
        public Form14()
        {
            InitializeComponent();
            comboBoxFeedbackType.Items.Add("Bug Report");
            comboBoxFeedbackType.Items.Add("Suggestion");
            comboBoxFeedbackType.Items.Add("Other");

            comboBoxFeedbackType.SelectedIndex = 0; 
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMessage.Text))
            {
                MessageBox.Show("Please enter a feedback message.");
                return;
            }

           
            Feedback newFeedback = new Feedback
            {
                Type = comboBoxFeedbackType.SelectedItem.ToString(),
                Message = textBoxMessage.Text
            };

          
            feedbackList.Add(newFeedback);

            
            textBoxMessage.Clear();

            
            UpdateFeedbackList();
        }
        private void UpdateFeedbackList()
        {
            // Clear existing items
            listBoxFeedback.Items.Clear();

            // Add each feedback entry to the ListBox
            foreach (var feedback in feedbackList)
            {
                listBoxFeedback.Items.Add(feedback);
            }
        }
    }
    public class Feedback
    {
        public string Type { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{Type}: {Message}";
        }
    }
}
