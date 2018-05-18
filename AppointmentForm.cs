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
    public partial class AppointmentForm : Form
    {
        Appointment app;
        DateTime day;

        public AppointmentForm(DateTime day)
        {
            this.day = day;
            InitializeComponent();
            app = null;
        }

        public AppointmentForm(DateTime day,Appointment app)
        {
            this.day = day;
            InitializeComponent();
            this.app = app;
            subjectTextBox.Text = app.Subject;
            locationTextBox.Text = app.Location;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTimes()
        {
            DateTime tempday = day;
            DateTime nextday = day.AddDays(1.0);
            while ( tempday != nextday)
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

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = day.Date.ToLongDateString();
            LoadTimes();
            LoadDurations();
            timeComboBox.SelectedIndex = 0;
            lengthComboBox.SelectedIndex = 0;
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lengthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Time duration = (Time)lengthComboBox.Items[lengthComboBox.SelectedIndex];
            int length = (duration.Hours * 60) + duration.Minutes;
            TimeSpan timespan = (TimeSpan)timeComboBox.Items[timeComboBox.SelectedIndex];            
            day = day.AddHours(timespan.TotalHours);
            app = new Appointment(day, length, subjectTextBox.Text, locationTextBox.Text);
            this.Close();
        }

        public Appointment App
        {
            set { app = value; }
            get { return app; }
        }


    }
}
