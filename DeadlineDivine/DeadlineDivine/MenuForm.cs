using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DeadlineDivine
{
    public partial class MenuForm : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<Task> taskList = new List<Task>();
        public MenuForm()
        {
            InitializeComponent();
            player.URL = "bg-music.mp3";
            loadTaskDataIntoList();
            display();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm form = new AddTaskForm(this);
            form.ShowDialog();
                     
        }

        private void viewTasksButton_Click(object sender, EventArgs e)
        {
            ViewTaskForm form = new ViewTaskForm(this);
            form.Show();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Deadline Divine. " +
                "\nYou can use this application to Add " +
                "\nRemove or Track your task deadlines.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            player.controls.play();
            player.settings.volume = 10;
            player.settings.setMode("loop", true);
            
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            mainLabel.ForeColor = Color.Black;
            upcomingLabel.ForeColor = Color.Black;
            dateLabel.ForeColor = Color.Black;
            liveClock1.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            mainLabel.ForeColor = Color.Red;
            upcomingLabel.ForeColor = Color.Red;
            dateLabel.ForeColor = Color.Red;
            liveClock1.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            mainLabel.ForeColor = Color.Green;
            upcomingLabel.ForeColor = Color.Green;
            dateLabel.ForeColor = Color.Green;
            liveClock1.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            mainLabel.ForeColor = Color.Blue;
            upcomingLabel.ForeColor = Color.Blue;
            dateLabel.ForeColor = Color.Blue;
            liveClock1.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            arialToolStripMenuItem.Checked = false;
            comicSansMSToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            timesNewRomanToolStripMenuItem.Checked = false;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            mainLabel.Font = new Font(mainLabel.Font, mainLabel.Font.Style ^ FontStyle.Bold);
            upcomingLabel.Font = new Font(upcomingLabel.Font, upcomingLabel.Font.Style ^ FontStyle.Bold);
            dateLabel.Font = new Font(dateLabel.Font, dateLabel.Font.Style ^ FontStyle.Bold);
            liveClock1.Font = new Font(liveClock1.Font, liveClock1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            mainLabel.Font = new Font(mainLabel.Font, mainLabel.Font.Style ^ FontStyle.Italic);
            upcomingLabel.Font = new Font(upcomingLabel.Font, upcomingLabel.Font.Style ^ FontStyle.Italic);
            dateLabel.Font = new Font(dateLabel.Font, dateLabel.Font.Style ^ FontStyle.Italic);
            liveClock1.Font = new Font(liveClock1.Font, liveClock1.Font.Style ^ FontStyle.Italic);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            arialToolStripMenuItem.Checked = true;
            mainLabel.Font = new Font("Arial", 24, mainLabel.Font.Style);
            upcomingLabel.Font = new Font("Arial", 24, upcomingLabel.Font.Style);
            dateLabel.Font = new Font("Arial", 16, dateLabel.Font.Style);
            liveClock1.Font = new Font("Arial", 16, liveClock1.Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timesNewRomanToolStripMenuItem.Checked = true;
            mainLabel.Font = new Font("Times New Roman", 24, mainLabel.Font.Style);
            upcomingLabel.Font = new Font("Times New Roman", 24, upcomingLabel.Font.Style);
            dateLabel.Font = new Font("Times New Roman", 16, dateLabel.Font.Style);
            liveClock1.Font = new Font("Times New Roman", 16, liveClock1.Font.Style);
        }

        private void comicSansMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSansMSToolStripMenuItem.Checked = true;
            mainLabel.Font = new Font("Comic Sans MS", 24, mainLabel.Font.Style);
            upcomingLabel.Font = new Font("Comic Sans MS", 24, upcomingLabel.Font.Style);
            dateLabel.Font = new Font("Comic Sans MS", 16, dateLabel.Font.Style);
            liveClock1.Font = new Font("Comic Sans MS", 16, liveClock1.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierToolStripMenuItem.Checked = true;
            mainLabel.Font = new Font("Courier", 24, mainLabel.Font.Style);
            upcomingLabel.Font = new Font("Courier", 24, upcomingLabel.Font.Style);
            dateLabel.Font = new Font("Courier", 16, dateLabel.Font.Style);
            liveClock1.Font = new Font("Courier", 16, liveClock1.Font.Style);
        }

        private void muteUnmuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
            } else
            {
                player.controls.play();
            }
        }

        private void raiseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.settings.volume += 10;
        }

        private void lowerVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.settings.volume -= 10;
        }

        public void loadTaskDataIntoList()
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            try
            {
                string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                connection = new SqlConnection(cnString);
                string query = "SELECT * FROM Task WHERE CONVERT(DATE, Deadline) = CONVERT(DATE, GETDATE()) AND Deadline >= GETDATE()";

                cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (taskList.Count > 0) { taskList.Clear(); }

                while (reader.Read())
                {
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

        public void display()
        {        
            upcomingDeadlines.Items.Clear();
            foreach (Task task in taskList)
            {
                upcomingDeadlines.Items.Add(task.ToString());
            }
        }

        private void upcomingDeadlines_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            upcomingDeadlines.BeginInvoke(new Action(() =>
            {
                var task = upcomingDeadlines.SelectedIndex;
                if (task != -1)
                {
                    var item = taskList[task].Id;
                    SqlConnection connection = null;
                    SqlCommand cmd = null;

                    try
                    {
                        string cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TaskDatabase.mdf;Integrated Security=True";
                        connection = new SqlConnection(cnString);
                        string query = "DELETE FROM TASK WHERE Id = '" + item + "';";

                        cmd = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        upcomingDeadlines.Items.RemoveAt(task);
                        loadTaskDataIntoList();
                        display();
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
            }));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < upcomingDeadlines.Items.Count; i++)
            {
                var task = taskList[i];
                var deadline = task.Deadline;

             
                if (deadline < DateTime.Now)
                {
 
                    taskList.RemoveAt(i);

   
                    upcomingDeadlines.Items.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
