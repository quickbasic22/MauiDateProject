using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDateProject
{
    public class WeekNumberExtension : IMarkupExtension
    {
        public CalendarWeekRule CalendarWeekRule { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
       public object ProvideValue(IServiceProvider serviceProvider)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Today, CalendarWeekRule, DayOfWeek);
        }
    }
}
