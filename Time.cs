using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar
{
    public struct Time
    {
        int hours;
        int minutes;
        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                minutes = value;
                if (Minutes / 60 == 1)
                {
                    this.Hours ++;
                    Minutes = 0;
                }

            }
            get { return minutes; }
        }
        public override string ToString()
        {
            return hours + " Hours " + " : " + minutes + " Minutes";
        }

    }
}
