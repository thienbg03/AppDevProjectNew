﻿namespace DeadlineDivine
{
    partial class ViewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTaskForm));
            this.displayListView = new System.Windows.Forms.ListView();
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadlineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.sortDeadlineButton = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.removePassedButton = new System.Windows.Forms.Button();
            this.stickNoteControl = new DeadlineDivine.StickNoteControl();
            this.SuspendLayout();
            // 
            // displayListView
            // 
            this.displayListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.displayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader,
            this.deadlineHeader,
            this.descriptionHeader});
            this.displayListView.GridLines = true;
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(12, 12);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(423, 314);
            this.displayListView.TabIndex = 0;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.View = System.Windows.Forms.View.Details;
            this.displayListView.SelectedIndexChanged += new System.EventHandler(this.displayListView_SelectedIndexChanged);
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 125;
            // 
            // deadlineHeader
            // 
            this.deadlineHeader.Text = "Deadline";
            this.deadlineHeader.Width = 140;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 160;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(314, 334);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(148, 36);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Task";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sortDeadlineButton
            // 
            this.sortDeadlineButton.Location = new System.Drawing.Point(158, 334);
            this.sortDeadlineButton.Name = "sortDeadlineButton";
            this.sortDeadlineButton.Size = new System.Drawing.Size(150, 36);
            this.sortDeadlineButton.TabIndex = 4;
            this.sortDeadlineButton.Text = "Sort By Deadline";
            this.sortDeadlineButton.UseVisualStyleBackColor = true;
            this.sortDeadlineButton.Click += new System.EventHandler(this.sortDeadlineButton_Click);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(12, 334);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(140, 36);
            this.addTask.TabIndex = 5;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(459, 266);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(291, 38);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // removePassedButton
            // 
            this.removePassedButton.Location = new System.Drawing.Point(468, 334);
            this.removePassedButton.Name = "removePassedButton";
            this.removePassedButton.Size = new System.Drawing.Size(298, 36);
            this.removePassedButton.TabIndex = 7;
            this.removePassedButton.Text = "Remove Passed Deadline";
            this.removePassedButton.UseVisualStyleBackColor = true;
            this.removePassedButton.Click += new System.EventHandler(this.removePassedButton_Click);
            // 
            // stickNoteControl
            // 
            this.stickNoteControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stickNoteControl.Enabled = false;
            this.stickNoteControl.Location = new System.Drawing.Point(441, 12);
            this.stickNoteControl.Name = "stickNoteControl";
            this.stickNoteControl.Size = new System.Drawing.Size(325, 314);
            this.stickNoteControl.TabIndex = 2;
            // 
            // ViewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 380);
            this.Controls.Add(this.removePassedButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.sortDeadlineButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.stickNoteControl);
            this.Controls.Add(this.displayListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader deadlineHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private StickNoteControl stickNoteControl;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sortDeadlineButton;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button removePassedButton;
    }
}