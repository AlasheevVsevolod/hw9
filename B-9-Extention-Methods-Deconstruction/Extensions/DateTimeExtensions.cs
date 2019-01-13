using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Extensions
{
    public static class DateTimeExtensions
    {
        public static void Deconstruct(this DateTime tmpDT, out int year, out int month,
        out int day, out int hour, out int minute, out int second)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }
    }
}
