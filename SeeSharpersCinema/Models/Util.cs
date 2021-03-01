using System;

namespace SeeSharpersCinema.Models
{
    public static class Util
    {
        public static string GetDay()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            return today.ToString();
        }
    }
}
