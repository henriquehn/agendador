using System;

namespace Agendador
{
    public class AlarmEvent : IComparable<AlarmEvent>
    {
        public DateTime AlarmTime { get; set; }
        public DateTime EventTime { get; set; }
        public string Description { get; set; } = "";

        public AlarmEvent()
        {
        }

        public AlarmEvent(DateTime alarmTime,DateTime eventTime,string description)
        {
            this.AlarmTime = alarmTime;
            this.EventTime = eventTime;
            this.Description = description;
        }

        public int CompareTo(AlarmEvent other)
        {
            int result = 0;
            if (other == null)
            {
                result = 1;
            }
            else
            {
                result = this.AlarmTime.CompareTo(other.AlarmTime);
                if (result==0)
                {
                    result = this.EventTime.CompareTo(other.EventTime);
                    if (result == 0)
                    {
                        if (this.Description == null)
                        {
                            if (other.Description == null)
                            {
                                result = 0;
                            }
                            else
                            {
                                result = -1;
                            }
                        }
                        else
                        {
                            result = this.Description.CompareTo(other.Description);
                        }
                    }
                }
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            try
            {
                return this.CompareTo((AlarmEvent)obj) == 0;
            }
            catch
            {
                return false;
            }
        }
    }
}