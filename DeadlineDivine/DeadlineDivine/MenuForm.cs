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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm form = new AddTaskForm();
            form.Show();           
        }

        private void viewTasksButton_Click(object sender, EventArgs e)
        {
           ViewTaskForm form = new ViewTaskForm();
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
    }
}
