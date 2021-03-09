using System;

namespace SeeSharpersCinema.Infrastructure
{
    public static class DateHelper
    {
        public static string GetDay()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            return today.ToString();
        }
    }
}
