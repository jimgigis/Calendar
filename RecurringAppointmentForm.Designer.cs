namespace Calendar
{
    partial class RecurringAppointmentForm
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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.occurenceLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.frequencyComboBox = new System.Windows.Forms.ComboBox();
            this.occurenceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(25, 33);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(49, 13);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject :";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(25, 68);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(154, 99);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 13);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "00/00/2014";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(424, 99);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(46, 13);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Length :";
            // 
            // occurenceLabel
            // 
            this.occurenceLabel.AutoSize = true;
            this.occurenceLabel.Location = new System.Drawing.Point(401, 171);
            this.occurenceLabel.Name = "occurenceLabel";
            this.occurenceLabel.Size = new System.Drawing.Size(90, 13);
            this.occurenceLabel.TabIndex = 4;
            this.occurenceLabel.Text = "How many times :";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(90, 26);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(545, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(90, 61);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(545, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(92, 126);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(174, 21);
            this.timeComboBox.TabIndex = 7;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(154, 171);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(63, 13);
            this.frequencyLabel.TabIndex = 8;
            this.frequencyLabel.Text = "Frequency :";
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.Location = new System.Drawing.Point(343, 126);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(162, 21);
            this.lengthComboBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(461, 247);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(579, 247);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // frequencyComboBox
            // 
            this.frequencyComboBox.FormattingEnabled = true;
            this.frequencyComboBox.Location = new System.Drawing.Point(90, 190);
            this.frequencyComboBox.Name = "frequencyComboBox";
            this.frequencyComboBox.Size = new System.Drawing.Size(176, 21);
            this.frequencyComboBox.TabIndex = 12;
            // 
            // occurenceTextBox
            // 
            this.occurenceTextBox.Location = new System.Drawing.Point(343, 191);
            this.occurenceTextBox.Name = "occurenceTextBox";
            this.occurenceTextBox.Size = new System.Drawing.Size(162, 20);
            this.occurenceTextBox.TabIndex = 13;
            // 
            // RecurringAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 282);
            this.Controls.Add(this.occurenceTextBox);
            this.Controls.Add(this.frequencyComboBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lengthComboBox);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.occurenceLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.subjectLabel);
            this.Name = "RecurringAppointmentForm";
            this.Text = "New Recurring Appointment";
            this.Load += new System.EventHandler(this.RecurringAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label occurenceLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox frequencyComboBox;
        private System.Windows.Forms.TextBox occurenceTextBox;
    }
}