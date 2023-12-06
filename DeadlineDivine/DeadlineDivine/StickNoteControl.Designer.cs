namespace DeadlineDivine
{
    partial class StickNoteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.deadlineTextBox = new System.Windows.Forms.TextBox();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(4, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(49, 6);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(238, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // deadlineTextBox
            // 
            this.deadlineTextBox.Location = new System.Drawing.Point(83, 32);
            this.deadlineTextBox.Name = "deadlineTextBox";
            this.deadlineTextBox.ReadOnly = true;
            this.deadlineTextBox.Size = new System.Drawing.Size(204, 20);
            this.deadlineTextBox.TabIndex = 2;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLabel.Location = new System.Drawing.Point(4, 30);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(76, 20);
            this.deadlineLabel.TabIndex = 3;
            this.deadlineLabel.Text = "Deadline:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(4, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(8, 78);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(279, 127);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = "";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(49, 211);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(238, 25);
            this.datePicker.TabIndex = 7;
            this.datePicker.Visible = false;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.timePicker.CustomFormat = "HH:mm tt";
            this.timePicker.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(191, 242);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(96, 26);
            this.timePicker.TabIndex = 8;
            this.timePicker.Visible = false;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // StickNoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.deadlineTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "StickNoteControl";
            this.Size = new System.Drawing.Size(296, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox deadlineTextBox;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}
