using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadlineDivine
{
    public partial class StickNoteControl : UserControl
    {
        public StickNoteControl()
        {           
            InitializeComponent();
        }

        //Set Text For Sticky Note 
        public void setText(string title, string deadline, string description)
        {
            titleTextBox.Text = title;
            deadlineTextBox.Text = deadline;
            descriptionTextBox.Text = description;
            if (deadline.Equals(""))
            {
                datePicker.Visible = false;
                timePicker.Visible = false;
            }
            else
            {
                datePicker.MinDate = DateTime.Parse(deadline);
                datePicker.Value = DateTime.Parse(deadline);


                timePicker.MinDate = DateTime.Parse("0:00:00 AM");
                timePicker.Value = DateTime.Parse(deadline);
                






                datePicker.Visible = true;
                timePicker.Visible = true;
            }
                      
        }

        public String getTitleText()
        {
            return titleTextBox.Text;
        }

        public String getDescriptionText()
        {
            return descriptionTextBox.Text;
        }

        public DateTime getDeadline()
        {
            return DateTime.Parse(deadlineTextBox.Text);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
           if(datePicker.Value > DateTime.Now)
            {
                datePicker.MinDate = DateTime.Now;
            }
            deadlineTextBox.Text = datePicker.Value.ToString("G");
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            deadlineTextBox.Text = timePicker.Value.ToString("G");
        }
    }
}
