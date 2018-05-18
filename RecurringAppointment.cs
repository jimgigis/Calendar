using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    public class RecurringAppointment : Appointment
    {
        #region Data Members

        int numberOfRecurrence;
        RecurrenceType recurrenceType;

        #endregion

        #region Constructors

        public RecurringAppointment(int numberOfRecurrence,RecurrenceType type, DateTime date, int length, string description, string location)
            : base(date, length, description, location)
        {
            this.numberOfRecurrence = numberOfRecurrence;
            this.recurrenceType = type;
        }

        public RecurringAppointment()
            : this(0,RecurrenceType.Daily, System.DateTime.Now, 0, "", "")
        { }

        #endregion

        #region Appointment Class Implementation

        public override string DisplayableDescription
        {
            get { return "Subject : " + subject + " Location : " + location + " Occuring: " + numberOfRecurrence + " times " + recurrenceType.ToString(); }
        }

        public override bool OccursOnDate(DateTime date)
        {
            int i = numberOfRecurrence;
            DateTime tempdate = start;
            while (i > 0)
            {
                if (recurrenceType == RecurrenceType.Daily)
                {
                    if (tempdate.Date == date.Date)
                        return true;
                    tempdate = tempdate.AddDays(1.0);
                }
                if (recurrenceType == RecurrenceType.Weekly)
                {
                    if (tempdate.Date == date.Date)
                        return true;
                    tempdate = tempdate.AddDays(7.0);
                }
                if (recurrenceType == RecurrenceType.Monthly)
                {
                    if (tempdate.Date == date.Date)
                        return true;
                    tempdate = tempdate.AddMonths(1);
                }
                if (recurrenceType == RecurrenceType.Yearly)
                {
                    if (tempdate.Date == date.Date)
                        return true;
                    tempdate = tempdate.AddYears(1);
                }
                i--;
            }
            return false;
        }

        #endregion

        #region Properties

        public int NumberOfRecurrence
        {
            set { numberOfRecurrence = value; }
            get { return numberOfRecurrence; }
        }

        public RecurrenceType RecurrenceType
        {
            get { return recurrenceType; }
            set { recurrenceType = value; }
        }
        
        #endregion
    }
}
