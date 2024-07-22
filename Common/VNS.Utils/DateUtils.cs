using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.Utils
{
    public class DateUtils
    {
    }

    public class Week
    {
        public static Week FromDate(DateTime date)
        {
            return new Week(date);
        }
        public static Week FromWeekNumber(int weekNumber, int year)
        {
            return new Week(weekNumber,year);
        }

        public Week(int week, int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            DayOfWeek firstDayOfWeek = date.DayOfWeek;
            DateTime firstStartDate;
            this.weekNumber = week;
            if (firstDayOfWeek > DayOfWeek.Thursday )
            {
                firstStartDate = date.AddDays(8 - (int)date.DayOfWeek);
            }
            else if (firstDayOfWeek == DayOfWeek.Sunday)
            {
                firstStartDate = date.AddDays(1);
            }
            else
            {
                firstStartDate = date.AddDays(1 - (int)date.DayOfWeek);
            }
            this.startDate = firstStartDate.AddDays((this.weekNumber-1) * 7);
            this.endDate = this.startDate.AddDays(6);
        }
        public Week(DateTime date)
        {
            
            int dayOfYear = date.DayOfYear;
            DayOfWeek firstDayOfWeek = date.AddDays(-date.DayOfYear+1).DayOfWeek;
            this.weekNumber = (int)(Math.Ceiling(dayOfYear/7.0));
            if (firstDayOfWeek > DayOfWeek.Thursday || firstDayOfWeek == DayOfWeek.Sunday)
            {
                this.weekNumber -= 1;
            }

            this.startDate = date.AddDays(date.DayOfWeek != DayOfWeek.Sunday ? 1 - (int)date.DayOfWeek:-6 );
            this.endDate = this.startDate.AddDays(6);
            
        }
        
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private int weekNumber;

        public int WeekNumber
        {
            get { return weekNumber; }
            set { weekNumber = value; }
        }
	
	
    }
}
