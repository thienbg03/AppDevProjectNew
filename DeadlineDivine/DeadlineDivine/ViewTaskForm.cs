using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeadlineDivine
{
    public partial class ViewTaskForm : Form
    {
        List<Task> taskList = new List<Task>();
        int sortDeadline = 0;
        public ViewTaskForm()
        {          
            InitializeComponent();
            loadTaskDataIntoList();
            display();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            display();
        }

        //Populate displayListView with task data
        public void display()
        {
            displayListView.Items.Clear();
            if (taskList.Count > 0)
            {
                foreach (var task in taskList)
                {
                    ListViewItem item = new ListViewItem(task.Title);
                    item.Tag = task.Id;
                    item.SubItems.Add(task.Deadline.ToString("G"));
                    item.SubItems.Add(task.Description);

                    //If the task day is due today, change item color to red
                    if (DateTime.Now.Day == task.Deadline.Day)
                    {
                        item.BackColor = Color.Red;
                    }
                    else if (task.Deadline.Day > DateTime.Now.Day && task.Deadline.Day < DateTime.Now.AddDays(5).Day)
                    {
                        item.BackColor = Color.Yellow;
                    }
                    else
                        item.BackColor = Color.LightGreen;

                    displayListView.Items.Add(item);
                }
            }
        }

        private void displayStickNote()
        {
                ListViewItem selected =  displayListView.SelectedItems[0];
                string title = selected.SubItems[0].Text;
                string deadline = selected.SubItems[1].Text;              
                string description = selected.SubItems[2].Text;
                stickNoteControl.setText(title, deadline, description);

        }

        //Load database to list (Finished)
        public void loadTaskDataIntoList()
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            try
            {
                string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                connection = new SqlConnection(cnString);
                string query = "Select * From Task";
                cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(taskList.Count > 0 ) { taskList.Clear(); }

                while(reader.Read()) {
                    int id = Convert.ToInt32(reader["ID"]);
                    String title = reader.GetString(1);
                    String description = reader.GetString(2);
                    DateTime deadline = reader.GetDateTime(3);
                    Task task = new Task(id, title, deadline, description);
                    taskList.Add(task);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null) { connection.Close(); }
                if (cmd != null) { cmd.Dispose(); }
            }
        }

        private void displayListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(displayListView.SelectedItems.Count > 0)
            {
                saveButton.Enabled = true;
                stickNoteControl.Enabled = true;
                displayStickNote();
            }
            else
            {
                stickNoteControl.setText("", "", "");
            }
            
        }

        //Remove Task From List (Finished)
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (displayListView.SelectedItems.Count > 0)
            {
                int id = (int)displayListView.SelectedItems[0].Tag;
                //Selected Item Tag Contains Task Id
                SqlConnection connection = null;
                SqlCommand cmd = null;
                try
                {
                    string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                    connection = new SqlConnection(cnString);
                    string query = "DELETE From Task WHERE Id ='" + id + "';";
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) { }
                    displayListView.Items.Remove(displayListView.SelectedItems[0]);
                    loadTaskDataIntoList();
                    MessageBox.Show("Task Completed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                    if (cmd != null) { cmd.Dispose(); }
                   
                }
            }
        }

        //Sort The task by deadline asc
        private void sortDeadlineAsc()
        {
            taskList.Sort((task1, task2)=> task1.Deadline.CompareTo(task2.Deadline));
        }

        private void sortDeadlineDesc()
        {
            taskList.Sort((task1, task2) => task2.Deadline.CompareTo(task1.Deadline));
        }

        private void sortDeadlineButton_Click(object sender, EventArgs e)
        {
            if(sortDeadline == 0)
            {
                sortDeadline= 1;
                sortDeadlineDesc();
                display();
            }
            else
            {
                sortDeadline = 0; 
                sortDeadlineAsc(); 
                display();
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this);
            addTaskForm.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (displayListView.SelectedItems.Count > 0)
            {
                int id = (int)displayListView.SelectedItems[0].Tag;
                Task foundTask = taskList.Find(task => task.Id == id);
                //IF the values in the stick note changes, execute the save 
                if (!foundTask.Title.Equals(stickNoteControl.getTitleText()) || 
                    !foundTask.Description.Equals(stickNoteControl.getDescriptionText()) ||
                    foundTask.Deadline != stickNoteControl.getDeadline()){
                    //Selected Item Tag Contains Task Id
                    SqlConnection connection = null;
                    SqlCommand cmd = null;
                    try
                    {
                        string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                        connection = new SqlConnection(cnString);
                        string query = "UPDATE Task SET Title ='" + stickNoteControl.getTitleText() +"', Description='" + stickNoteControl.getDescriptionText() + "', Deadline ='" + stickNoteControl.getDeadline().ToString("G") + "' WHERE Id =" + id + ";"; 
                        cmd = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) { }
                        loadTaskDataIntoList();
                        stickNoteControl.setText("", "", "");
                        display();
                        MessageBox.Show("Saved");                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (connection != null) { connection.Close(); }
                        if (cmd != null) { cmd.Dispose(); }

                    }
                }
                else
                {
                    MessageBox.Show("No new changes to save");
                }
                
            }
        }
    }
}
    