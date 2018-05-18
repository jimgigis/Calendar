using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    public class Appointment : IAppointment
    {
        #region Data members

        protected DateTime start;
        protected int length;
        protected string subject;
        protected string location;
        #endregion

        #region Constructors

        public Appointment() : this(System.DateTime.Now,0,"","")
        {
        }

        public Appointment(DateTime start, int length, string subject, string location)
        {
            this.start = start;
            this.length = length;
            this.subject = subject;
            this.location = location;
        }

        #endregion

        #region IAppointment Implementation

        public DateTime Start
        {
            get { return start; }
        }

        public int Length
        {
            get { return length; }
        }

        public virtual string DisplayableDescription
        {
            get { return "Subject : " + subject + " Location : " + location; }
        }

        public virtual bool OccursOnDate(DateTime date)
        {
            return start.Date == date.Date;
        }

        #endregion

        #region Properties

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        
        #endregion

        #region Class Methods

        public bool OccursOnTime(DateTime startDate , int length)
        {
            DateTime end = start.AddMinutes((double)this.length);
            DateTime endDate = startDate.AddMinutes((double)length);
            if (startDate.TimeOfDay < start.TimeOfDay && endDate.TimeOfDay <= start.TimeOfDay)
            {
                return false;
            }
            if (endDate.TimeOfDay > end.TimeOfDay && startDate.TimeOfDay >= end.TimeOfDay)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
