using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DeadlineDivine
{
    public partial class AddTaskForm : Form
    {
        private ViewTaskForm viewForm = null;
        public AddTaskForm()
        {             
            InitializeComponent();
            datePicker.MinDate = DateTime.Now;
            timePicker.MinDate = DateTime.Now.AddMinutes(1);                     
        }

        public AddTaskForm(ViewTaskForm form)
        {
            InitializeComponent();
            ViewForm = form;
            datePicker.MinDate = DateTime.Now;
            timePicker.MinDate = DateTime.Now.AddMinutes(1);
        }

        private ViewTaskForm ViewForm { get { return viewForm; } set { viewForm = value; } }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null; 
            try
            {
                string title = titleTextBox.Text;
                string description = commentTextBox.Text;
                DateTime date = datePicker.Value;
                DateTime time = timePicker.Value;
                DateTime deadline =DateTime.Parse(date.ToString("d") + " " + time.ToString("T"));
                Task task = new Task(title, deadline, description);
                string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                connection = new SqlConnection(cnString);
                string query = "insert into Task values ('" + title + "','" + description + "','" + deadline.ToString("g") + "');";
                cmd = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read()) { }
                if(viewForm != null)
                {
                    viewForm.loadTaskDataIntoList();
                    viewForm.display();
                }
                MessageBox.Show("Task Added Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(connection != null) { connection.Dispose(); }
                if(cmd != null) { cmd.Dispose(); }
                this.Dispose();
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if(datePicker.Value.Day > DateTime.Now.Day) {
                timePicker.MinDate = datePicker.Value.Date;
                timePicker.Value = datePicker.Value;
            }
        }
    }
}
