using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct Birthday
    {
        public DateTime Birthdate { get; set; }

        public Birthday(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DayOfWeek GetDayOfWeekOfBirth()
        {
            return Birthdate.DayOfWeek;
        }

        public DayOfWeek GetDayOfWeekInYear(int year)
        {
            DateTime birthdayInYear = new DateTime(year, Birthdate.Month, Birthdate.Day);
            return birthdayInYear.DayOfWeek;
        }

        public int DaysUntilNextBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, Birthdate.Month, Birthdate.Day);

            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);

            TimeSpan timeUntilNextBirthday = nextBirthday - today;

            return timeUntilNextBirthday.Days;
        }
    }

}
