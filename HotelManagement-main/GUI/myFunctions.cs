using System;

namespace GUI
{
    public class myFunctions
    {
        public static DateTime GetFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
    }
}
