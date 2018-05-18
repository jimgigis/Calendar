using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class RecurringAppointmentForm : Form
    {
        RecurringAppointment recurringApp;
        DateTime day;

        public RecurringAppointmentForm(DateTime day)
        {
            InitializeComponent();
            this.day = day;
            recurringApp = null;
        }

        public RecurringAppointmentForm(DateTime day , RecurringAppointment recurringApp)
        {
            InitializeComponent();
            this.day = day;
            this.recurringApp = recurringApp;
            subjectTextBox.Text = recurringApp.Subject;
            locationTextBox.Text = recurringApp.Location;
            occurenceTextBox.Text = recurringApp.NumberOfRecurrence.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int numberOfOccurence = 0;
            if (occurenceTextBox.Text.Trim() != "")
            {
                try
                {
                    numberOfOccurence = int.Parse(occurenceTextBox.Text);
                    if (numberOfOccurence > 999 || numberOfOccurence < 2)
                    {
                        MessageBox.Show("Please select a number between 2 and 999 to specify the recurring number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        occurenceTextBox.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("Please select a number between 2 and 999 to specify te recurring number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    occurenceTextBox.Text = "";
                }
            }
            Time duration = (Time)lengthComboBox.Items[lengthComboBox.SelectedIndex];
            int length = (duration.Hours * 60) + duration.Minutes;
            TimeSpan timespan = (TimeSpan)timeComboBox.Items[timeComboBox.SelectedIndex];
            day = day.AddHours(timespan.TotalHours);
            RecurrenceType type = (RecurrenceType)frequencyComboBox.Items[frequencyComboBox.SelectedIndex];
            if (numberOfOccurence == 0)
            {
                MessageBox.Show("Please specify the number of recurrence for this appointment", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            recurringApp = new RecurringAppointment(numberOfOccurence, type, day, length, subjectTextBox.Text, locationTextBox.Text);
            this.Close();
        }

        private void LoadTimes()
        {
            DateTime tempday = day;
            DateTime nextday = day.AddDays(1.0);
            while (tempday != nextday)
            {
                timeComboBox.Items.Add(tempday.TimeOfDay);
                tempday = tempday.AddMinutes(30.0);
            }
        }

        private void LoadDurations()
        {
            Time time = new Time();
            time.Minutes = 30;
            time.Hours = 0;
            while (time.Hours <= 24)
            {
                lengthComboBox.Items.Add(time);
                if (time.Hours == 24)
                    return;
                time.Minutes = time.Minutes + 30;
            }
        }

        private void LoadRecurrenceTypes()
        {
            frequencyComboBox.Items.Add(RecurrenceType.Daily);
            frequencyComboBox.Items.Add(RecurrenceType.Weekly);
            frequencyComboBox.Items.Add(RecurrenceType.Monthly);
            frequencyComboBox.Items.Add(RecurrenceType.Yearly);
        }

        private void RecurringAppointmentForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = day.ToLongDateString();
            LoadDurations();
            LoadTimes();
            LoadRecurrenceTypes();
            timeComboBox.SelectedIndex = 0;
            lengthComboBox.SelectedIndex = 0;
            frequencyComboBox.SelectedIndex = 0;
            frequencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lengthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        public RecurringAppointment ReccuringApp
        {
            get { return recurringApp; }
            set { ReccuringApp = value; }
        }

    }
}
