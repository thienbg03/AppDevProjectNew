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

        public void setText(string title, string deadline, string description)
        {
            titleTextBox.Text = title;
            deadlineTextBox.Text = deadline;
            descriptionTextBox.Text = description;
            if (deadline.Equals(""))
            {
                datePicker.Visible = false;
                datePicker.Visible = false;
            }
            else
            {
                datePicker.Value = DateTime.Parse(deadline);
                datePicker.MinDate = DateTime.Now;

                timePicker.Value = DateTime.Parse(deadline);
                timePicker.MinDate = DateTime.Now.AddMinutes(1);



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
            if (datePicker.Value.Day > DateTime.Now.Day)
            {
                timePicker.MinDate = datePicker.Value.Date;
                timePicker.Value = datePicker.Value;
            }else if(datePicker.Value.Day  == DateTime.Now.Day)
            {
                timePicker.MinDate = DateTime.Now.AddMinutes(1);
                timePicker.Value = DateTime.Now.AddMinutes(1);
            }
            deadlineTextBox.Text = timePicker.Value.ToString("G");
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            deadlineTextBox.Text = timePicker.Value.ToString("G");
        }
    }
}
