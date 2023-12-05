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
    }
}
