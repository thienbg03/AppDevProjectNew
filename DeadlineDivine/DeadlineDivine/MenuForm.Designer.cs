namespace DeadlineDivine
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.viewTasksButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.upcomingLabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveClock1 = new DeadlineDivine.LiveClock();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(53, 33);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(278, 45);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Deadline Tracker";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(84, 226);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(193, 41);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Add a Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // viewTasksButton
            // 
            this.viewTasksButton.Location = new System.Drawing.Point(84, 309);
            this.viewTasksButton.Name = "viewTasksButton";
            this.viewTasksButton.Size = new System.Drawing.Size(193, 41);
            this.viewTasksButton.TabIndex = 3;
            this.viewTasksButton.Text = "View your Tasks";
            this.viewTasksButton.UseVisualStyleBackColor = true;
            this.viewTasksButton.Click += new System.EventHandler(this.viewTasksButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(84, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(193, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(385, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(634, 473);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // upcomingLabel
            // 
            this.upcomingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upcomingLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingLabel.Location = new System.Drawing.Point(558, 24);
            this.upcomingLabel.Name = "upcomingLabel";
            this.upcomingLabel.Size = new System.Drawing.Size(327, 63);
            this.upcomingLabel.TabIndex = 6;
            this.upcomingLabel.Text = "Upcoming Deadlines";
            this.upcomingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // liveClock1
            // 
            this.liveClock1.AutoSize = true;
            this.liveClock1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveClock1.Location = new System.Drawing.Point(113, 90);
            this.liveClock1.Margin = new System.Windows.Forms.Padding(6);
            this.liveClock1.Name = "liveClock1";
            this.liveClock1.Size = new System.Drawing.Size(164, 30);
            this.liveClock1.TabIndex = 7;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1031, 575);
            this.Controls.Add(this.liveClock1);
            this.Controls.Add(this.upcomingLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewTasksButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button viewTasksButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label upcomingLabel;
        private System.Windows.Forms.Timer Time;
        private LiveClock liveClock1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

