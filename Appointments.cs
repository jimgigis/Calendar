using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Calendar
{
    public class Appointments : IAppointments
    {
        #region Data Members

        IList<IAppointment> list;

        #endregion

        #region Constructors

        public Appointments(IList<IAppointment> list)
        {
            this.list = list;
        }

        public Appointments():this(new List<IAppointment>()) { }  

        #endregion

        #region Implementation of IEnumerable<T>

        public IEnumerator<IAppointment> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator<IAppointment> IEnumerable<IAppointment>.GetEnumerator()
        {
            return GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<T>
        public void Add(IAppointment item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(IAppointment item)
        {
            return list.Contains(item);
        }

        public void CopyTo(IAppointment[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool Remove(IAppointment item)
        {
            return list.Remove(item);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return list.IsReadOnly; }
        }

        #endregion

        #region Implementation of IList<T>

        public int IndexOf(IAppointment item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, IAppointment item)
        {
            list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public IAppointment this[int index]
        {
            get { return this[index]; }
            set { list[index] = value; }
        }
        #endregion

        #region Implementation of IAppointments

        public IEnumerable<IAppointment> GetAppointmentsOnDate(DateTime date)
        {
            foreach (IAppointment item in list)
            {
                if (item.OccursOnDate(date))
                {
                    yield return item;
                }
            }
        }

        public bool Save()
        {
            return false;
        }

        public bool Load()
        {
            return false;
        }

        #endregion

    }
}
